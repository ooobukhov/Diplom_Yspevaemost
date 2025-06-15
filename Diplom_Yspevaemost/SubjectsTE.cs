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
    public partial class SubjectsTE : Form
    {
        public SubjectsTE()
        {
            InitializeComponent();
        }

        private void SubjectsTE_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet1.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter1.Fill(this.diplom_YspevaemostDataSet1.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.diplom_YspevaemostDataSet.Subjects);

        }

        private void filterBT_Click(object sender, EventArgs e)
        {
            subjectsBindingSource1.Filter = "Name='" + filterCB.Text + "'";
        }

        private void pokazatVseBT_Click(object sender, EventArgs e)
        {
            subjectsBindingSource1.Filter = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < subjectsDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < subjectsDataGridView.RowCount - 1; j++)
                {
                    subjectsDataGridView[i, j].Style.BackColor = Color.White;
                    subjectsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < subjectsDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < subjectsDataGridView.RowCount - 1; j++)
                {
                    if (subjectsDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        subjectsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        subjectsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void PoleSortirovki_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sortirovka.Enabled = true;
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
            }
            if (radioButton1.Checked)
                subjectsDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                subjectsDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Teacher_Tables frm = new Teacher_Tables();
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

        private void lbFinalGrades_Click(object sender, EventArgs e)
        {

        }
    }
}
