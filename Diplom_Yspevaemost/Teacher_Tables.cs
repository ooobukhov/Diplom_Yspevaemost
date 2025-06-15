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
    public partial class Teacher_Tables : Form
    {
        public Teacher_Tables()
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
            GradesTE frm = new GradesTE();

            frm.Show();
            this.Hide();
        }

        private void Attendance_button_Click(object sender, EventArgs e)
        {
            AttendanceTE frm = new AttendanceTE();
            frm.Show();
            this.Hide();
        }

        private void documentBT_Click(object sender, EventArgs e)
        {
            DocumentsTE frm = new DocumentsTE();
            frm.Show();
            this.Hide();
        }

        private void sheduleBT_Click(object sender, EventArgs e)
        {
            SheduleTE frm = new SheduleTE();
            frm.Show();
            this.Hide();
        }

        private void FinalGrades_button_Click(object sender, EventArgs e)
        {
            FinalGradesTE frm = new FinalGradesTE();
            frm.Show();
            this.Hide();
        }

        private void prepod_button_Click(object sender, EventArgs e)
        {
            TeachersTE frm = new TeachersTE();
            frm.Show();
            this.Hide();
        }

        private void subjectsBT_Click(object sender, EventArgs e)
        {
            SubjectsTE frm = new SubjectsTE();
            frm.Show();
            this.Hide();
        }

        private void classes_button_Click(object sender, EventArgs e)
        {
            ClassesTE frm = new ClassesTE();
            frm.Show();
            this.Hide();
        }

        private void parentsBT_Click(object sender, EventArgs e)
        {
            ParentsTE frm = new ParentsTE();   
            frm.Show();
            this.Hide();
        }

        private void studentsBT_Click(object sender, EventArgs e)
        {
            StudentsTE frm = new StudentsTE();
            frm.Show();
            this.Hide();
        }

        private void zaprosiBT_Click(object sender, EventArgs e)
        {
            Zaprosi frm = new Zaprosi();
            frm.Show();
            this.Hide();
        }
    }
}
