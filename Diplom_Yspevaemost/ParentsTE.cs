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
    public partial class ParentsTE : Form
    {
        public ParentsTE()
        {
            InitializeComponent();
        }

        private void ParentsTE_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet1.Parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter1.Fill(this.diplom_YspevaemostDataSet1.Parents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet.Parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.diplom_YspevaemostDataSet.Parents);

        }

        private void filterBT_Click(object sender, EventArgs e)
        {
            parentsBindingSource1.Filter = "Surname='" + filterCB.Text + "'";
        }

        private void pokazatVseBT_Click(object sender, EventArgs e)
        {
            parentsBindingSource1.Filter = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < parentsDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < parentsDataGridView.RowCount - 1; j++)
                {
                    parentsDataGridView[i, j].Style.BackColor = Color.White;
                    parentsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < parentsDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < parentsDataGridView.RowCount - 1; j++)
                {
                    if (parentsDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        parentsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        parentsDataGridView[i, j].Style.ForeColor = Color.Blue;
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
                parentsDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                parentsDataGridView.Sort(COL,
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
    }
}
