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
    public partial class GradesSt : Form
    {
        public GradesSt()
        {
            InitializeComponent();
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.diplom_YspevaemostDataSet.Grades);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.diplom_YspevaemostDataSet.Grades);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.diplom_YspevaemostDataSet.Grades);

        }

        private void gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplom_YspevaemostDataSet);

        }

        private void filterBT_Click(object sender, EventArgs e)
        {
            gradesBindingSource.Filter = "GradeDate='" + filterCB.Text + "'";
        }

        private void pokazatVseBT_Click(object sender, EventArgs e)
        {
            gradesBindingSource.Filter = "";
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
        private void PoleSortirovki_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sortirovka.Enabled = true;
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

        private void back_button_Click(object sender, EventArgs e)
        {
            Student_Tables frm = new Student_Tables();
            frm.Show();
            this.Hide();
        }

        private void gradesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplom_YspevaemostDataSet);

        }

        private void gradesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplom_YspevaemostDataSet);

        }
    }
}
