using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Yspevaemost
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            password_textBox.PasswordChar = '*'; // Скрываем пароль по умолчанию
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Glavnaya frm = new Glavnaya();
            frm.Show();
            this.Hide();
        }
        
        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
"Подтверждение выхода",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Отмена");
            }
        }
        private void vhod_button_Click(object sender, EventArgs e)
        {
            // Переменная для отслеживания успешной авторизации
            bool isAuthenticated = false;
            // Проверка логина и пароля для преподавателя
            if (login_textBox.Text == "teacher" && password_textBox.Text == "teacher")
            {
                Teacher_Tables frm = new Teacher_Tables();
                frm.Show();
                this.Hide();
                isAuthenticated = true;
            }
            // Проверка логина и пароля для студента
            else if (login_textBox.Text == "student" && password_textBox.Text == "student")
            {
                Student_Tables frm = new Student_Tables();
                frm.Show();
                this.Hide();
                isAuthenticated = true;
            }
            // Проверка логина и пароля для администратора
            else if (login_textBox.Text == "admin" && password_textBox.Text == "admin")
            {
                Admin_Tables frm = new Admin_Tables();
                frm.Show();
                this.Hide();
                isAuthenticated = true;
            }
            // Если авторизация не прошла, выводим сообщение об ошибке
            if (!isAuthenticated)
            {
                MessageBox.Show("Ошибка: Неверный логин или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            // Если пароль скрыт, показываем его
            if (password_textBox.PasswordChar == '*')
            {
                password_textBox.PasswordChar = '\0'; // Показываем пароль
                showPassword.Text = "Скрыть пароль"; // Меняем текст кнопки
            }
            else
            {
                password_textBox.PasswordChar = '*'; // Скрываем пароль
                showPassword.Text = "Показать пароль"; // Меняем текст кнопки
            }
        }
    }
}
