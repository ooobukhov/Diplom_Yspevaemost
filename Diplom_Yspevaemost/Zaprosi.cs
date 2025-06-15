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
    public partial class Zaprosi : Form
    {
        public Zaprosi()
        {
            InitializeComponent();
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

        private void zapros1_Click(object sender, EventArgs e)
        {
            zapros1 frm = new zapros1();
            frm.Show();
            this.Hide();
        }

        private void zapros4_Click(object sender, EventArgs e)
        {
            zapros4 frm = new zapros4();
            frm.Show();
            this.Hide();
        }

        private void zapros3BT_Click(object sender, EventArgs e)
        {
            zapros3 frm = new zapros3();
            frm.Show();
            this.Hide();
        }
        private void zapros2BT_Click(object sender, EventArgs e)
        {
            zapros2 frm = new zapros2();
            frm.Show();
            this.Hide();
        }

        private void zapros5_Click(object sender, EventArgs e)
        {
            zapros5 frm = new zapros5();
            frm.Show();
            this.Hide();
        }


        private void zapros6_Click(object sender, EventArgs e)
        {
            zapros6 frm = new zapros6();
            frm.Show();
            this.Hide();
        }
    }
}
