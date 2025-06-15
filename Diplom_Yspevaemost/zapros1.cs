using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Yspevaemost
{
    public partial class zapros1 : Form
    {
        public zapros1()
        {
            InitializeComponent();
        }

        private void gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplom_YspevaemostDataSet1);

        }

        private void zapros1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet1.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.diplom_YspevaemostDataSet1.Grades);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gradesTableAdapter.FillBy(this.diplom_YspevaemostDataSet1.Grades);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Zaprosi frm = new Zaprosi();
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

        private void printBT_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument Print = new PrintDocument();
            Print.PrintPage += new PrintPageEventHandler(Print_PrintPage);
            printDialog.Document = Print;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                Print.Print();
            }
        }

        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
