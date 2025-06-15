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
    public partial class AttendanceAD : Form
    {
        public AttendanceAD()
        {
            InitializeComponent();
        }

        private void filterBT_Click(object sender, EventArgs e)
        {
            attendanceBindingSource1.Filter = "AttendanceID='" + filterCB.Text + "'";
        }

        private void pokazatVseBT_Click(object sender, EventArgs e)
        {
            attendanceBindingSource1.Filter = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < attendanceDataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < attendanceDataGridView1.RowCount - 1; j++)
                {
                    attendanceDataGridView1[i, j].Style.BackColor = Color.White;
                    attendanceDataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < attendanceDataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < attendanceDataGridView1.RowCount - 1; j++)
                {
                    if (attendanceDataGridView1[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        attendanceDataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        attendanceDataGridView1[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void PoleSortirovki_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sortirovka.Enabled = true;
        }

        private void Sortirovka_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();
            switch (PoleSortirovki.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                    case 3:
                        COL = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                    case 5:
                    COL = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
                attendanceDataGridView1.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                attendanceDataGridView1.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Admin_Tables frm = new Admin_Tables();
            frm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
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

        private void AttendanceAD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet1.Attendance". При необходимости она может быть перемещена или удалена.
            this.attendanceTableAdapter1.Fill(this.diplom_YspevaemostDataSet1.Attendance);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(attendanceDataGridView1.Size.Width + 10, attendanceDataGridView1.Size.Height + 10);
            attendanceDataGridView1.DrawToBitmap(bmp, attendanceDataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printBT_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
"Подтверждение удаления",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                attendanceBindingSource1.RemoveCurrent();
                MessageBox.Show("Запись успешно удалена!", "Удаление");
            }
            else
            {
                MessageBox.Show("Удаление отменено.", "Отмена");
            }
        }

        private void attendanceDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Показываем сообщение об ошибке пользователю
            MessageBox.Show("Ошибка ввода данных. Пожалуйста, введите значение правильного типа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Можно отменить редактирование в текущей ячейке, чтобы пользователь мог исправить данные
            e.Cancel = true;
        }
    }
}
