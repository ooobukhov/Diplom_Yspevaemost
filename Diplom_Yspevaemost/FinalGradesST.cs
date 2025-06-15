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
    public partial class FinalGradesST : Form
    {
        public FinalGradesST()
        {
            InitializeComponent();
        }

        private void finalGradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finalGradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplom_YspevaemostDataSet);

        }

        private void FinalGradesST_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet.FinalGrades". При необходимости она может быть перемещена или удалена.
            this.finalGradesTableAdapter.Fill(this.diplom_YspevaemostDataSet.FinalGrades);

        }

        private void filterBT_Click(object sender, EventArgs e)
        {
            finalGradesBindingSource.Filter = "FinalGradeID='" + filterCB.Text + "'";
        }

        private void pokazatVseBT_Click(object sender, EventArgs e)
        {
            finalGradesBindingSource.Filter = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < finalGradesDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < finalGradesDataGridView.RowCount - 1; j++)
                {
                    finalGradesDataGridView[i, j].Style.BackColor = Color.White;
                    finalGradesDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < finalGradesDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < finalGradesDataGridView.RowCount - 1; j++)
                {
                    if (finalGradesDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        finalGradesDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        finalGradesDataGridView[i, j].Style.ForeColor = Color.Blue;
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
                finalGradesDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                finalGradesDataGridView.Sort(COL,
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

        private void finalGradesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Показываем сообщение об ошибке пользователю
            MessageBox.Show("Ошибка ввода данных. Пожалуйста, введите значение правильного типа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Можно отменить редактирование в текущей ячейке, чтобы пользователь мог исправить данные
            e.Cancel = true;
        }
    }
}
