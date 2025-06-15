using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom_Yspevaemost
{
    public partial class ClassesSt : Form
    {
        public ClassesSt()
        {
            InitializeComponent();
        }

        private void ClassesSt_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.diplom_YspevaemostDataSet.Classes);

        }

        private void filterBT_Click(object sender, EventArgs e)
        {
            classesBindingSource.Filter = "ClassName='" + filterCB.Text + "'";

        }
        private void pokazatVseBT_Click(object sender, EventArgs e)
        {
            classesBindingSource.Filter = "";

        }
            private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < classesDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < classesDataGridView.RowCount - 1; j++)
                {
                    classesDataGridView[i, j].Style.BackColor = Color.White;
                    classesDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < classesDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < classesDataGridView.RowCount - 1; j++)
                {
                    if (classesDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        classesDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        classesDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }
        private System.Windows.Forms.DataGridViewColumn COL;
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
            }
            if (radioButton1.Checked)
                classesDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                classesDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void PoleSortirovki_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sortirovka.Enabled = true;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Student_Tables frm = new Student_Tables();
            frm.Show();
            this.Close();
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

        private void classesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Показываем сообщение об ошибке пользователю
            MessageBox.Show("Ошибка ввода данных. Пожалуйста, введите значение правильного типа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Можно отменить редактирование в текущей ячейке, чтобы пользователь мог исправить данные
            e.Cancel = true;
        }
    }
}
