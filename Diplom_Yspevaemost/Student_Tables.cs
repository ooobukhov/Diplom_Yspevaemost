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
    public partial class Student_Tables : Form
    {
        public Student_Tables()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Authorization frm= new Authorization();
            this.Hide();
            frm.Show();
        }

        private void grades_button_Click(object sender, EventArgs e)
        {
            GradesSt frm = new GradesSt();
            this.Hide();
            frm.Show();
        }

        private void FinalGrades_button_Click(object sender, EventArgs e)
        {
            FinalGradesST frm = new FinalGradesST();
            this.Hide();
            frm.Show();
        }

        private void classes_button_Click(object sender, EventArgs e)
        {
            ClassesSt frm = new ClassesSt();
            this.Hide();
            frm.Show();
        }

        private void Attendance_button_Click(object sender, EventArgs e)
        {
            AttendanceST frm = new AttendanceST();
            this.Hide();
            frm.Show();
        }

        private void prepod_button_Click(object sender, EventArgs e)
        {
            TeachersST frm = new TeachersST();
            this.Hide();
                frm.Show();
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
