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
    public partial class Admin_Tables : Form
    {
        public Admin_Tables()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Authorization frm = new Authorization();
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

        private void grades_button_Click(object sender, EventArgs e)
        {
            GradesAD frm = new GradesAD();
            frm.Show();
            this.Hide();
        }

        private void Attendance_button_Click(object sender, EventArgs e)
        {
            AttendanceAD frm = new AttendanceAD();
            frm.Show();
            this.Hide();
        }

        private void documentBT_Click(object sender, EventArgs e)
        {
            DocumentsAD frm = new DocumentsAD();
            frm.Show();
            this.Hide();
        }

        private void sheduleBT_Click(object sender, EventArgs e)
        {
            SheduleAD frm = new SheduleAD();
            frm.Show();
            this.Hide();
        }

        private void FinalGrades_button_Click(object sender, EventArgs e)
        {
            FinalGradesAD frm = new FinalGradesAD();
            frm.Show();
            this.Hide();
        }

        private void prepod_button_Click(object sender, EventArgs e)
        {
            TeachersAD frm = new TeachersAD();
            frm.Show();
            this.Hide();
        }

        private void subjectsBT_Click(object sender, EventArgs e)
        {
            SubjectsAD frm = new SubjectsAD();
            frm.Show();
            this.Hide();
        }

        private void classes_button_Click(object sender, EventArgs e)
        {
            ClassesAD frm = new ClassesAD();
            frm.Show();
            this.Hide();
        }

        private void parentsBT_Click(object sender, EventArgs e)
        {
            ParentsAD frm = new ParentsAD();
            frm.Show();
            this.Hide();
        }

        private void studentsBT_Click(object sender, EventArgs e)
        {
            StudentsAD frm = new StudentsAD();
            frm.Show();
            this.Hide();
        }
    }
}
