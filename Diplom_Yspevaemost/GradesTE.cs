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
    public partial class GradesTE : Form
    {
        public GradesTE()
        {
            InitializeComponent();
        }

        private void filterBT_Click(object sender, EventArgs e)
        {
            gradesBindingSource1.Filter = "GradeDate='" + filterCB.Text + "'";
        }

        private void pokazatVseBT_Click(object sender, EventArgs e)
        {
            gradesBindingSource1.Filter = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gradesDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < gradesDataGridView.RowCount - 1; j++)
                {
                    gradesDataGridView[i, j].Style.BackColor = Color.White;
                    gradesDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < gradesDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < gradesDataGridView.RowCount - 1; j++)
                {
                    if (gradesDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        gradesDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        gradesDataGridView[i, j].Style.ForeColor = Color.Blue;
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
                    case 6:
                    COL = dataGridViewTextBoxColumn7;
                    break;
            }
            if (radioButton1.Checked)
                gradesDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                gradesDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Teacher_Tables frm = new Teacher_Tables();
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

        private void GradesTE_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet1.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter1.Fill(this.diplom_YspevaemostDataSet1.Grades);

        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
"Подтверждение удаления",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                gradesBindingSource1.RemoveCurrent();
                MessageBox.Show("Запись успешно удалена!", "Удаление");
            }
            else
            {
                MessageBox.Show("Удаление отменено.", "Отмена");
            }
        }

        private void diagramBT_Click(object sender, EventArgs e)
        {
            DinamicYspevaemostiTeacher frm = new DinamicYspevaemostiTeacher();
            frm.Show();
            this.Hide();
        }

        private void gradesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Показываем сообщение об ошибке пользователю
            MessageBox.Show("Ошибка ввода данных. Пожалуйста, введите значение правильного типа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Можно отменить редактирование в текущей ячейке, чтобы пользователь мог исправить данные
            e.Cancel = true;
        }
    }
}
