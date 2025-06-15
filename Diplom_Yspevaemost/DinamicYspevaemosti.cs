using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Diplom_Yspevaemost
{
    public partial class DinamicYspevaemosti : Form
    {
        public DinamicYspevaemosti()
        {
            InitializeComponent();
        }
        private void DinamicYspevaemosti_Load(object sender, EventArgs e)
        {
            // Заполняем ComboBox'ы данными при загрузке формы
            PopulateStudentsComboBox();
            PopulateClassesComboBox();
            // По умолчанию выбираем "По ученику" и отображаем соответствующий ComboBox
            radioButtonStudent.Checked = true;
            comboBoxClasses.Visible = false;
            // Привязываем обработчики после того, как ComboBox'ы заполнены
            // Отображаем график для первого ученика при загрузке формы (если есть ученики)
            if (comboBoxStudents.Items.Count > 0)
            {
                comboBoxStudents.SelectedIndex = 0;
                // Вызываем DisplayGradeDistributionChartForStudent напрямую для первоначального отображения
                if (comboBoxStudents.SelectedValue != null)
                {
                    if (int.TryParse(comboBoxStudents.SelectedValue.ToString(), out int selectedStudentId))
                    {
                        DisplayGradeDistributionChartForStudent(selectedStudentId);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при загрузке формы (ученики): Некорректное значение SelectedValue в ComboBox.");
                    }
                }
            }
            else if (comboBoxClasses.Items.Count > 0)
            {
                radioButtonClass.Checked = true;
                comboBoxStudents.Visible = false;
                comboBoxClasses.Visible = true;
                comboBoxClasses.SelectedIndex = 0;
                // Вызываем DisplayGradeDistributionChartForClass напрямую для первоначального отображения
                if (comboBoxClasses.SelectedValue != null)
                {
                    if (int.TryParse(comboBoxClasses.SelectedValue.ToString(), out int selectedClassId))
                    {
                        DisplayGradeDistributionChartForClass(selectedClassId);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при загрузке формы (классы): Некорректное значение SelectedValue в ComboBox.");
                    }
                }
            }
            // *** Привязываем обработчики событий SelectedIndexChanged ПОСЛЕ всей логики загрузки ***
            // Это гарантирует, что обработчики не сработают преждевременно при установке SelectedIndex
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged_1;
            comboBoxClasses.SelectedIndexChanged += comboBoxClasses_SelectedIndexChanged_1;
        }
        // Метод для заполнения ComboBoxStudents (без изменений)
        private void PopulateStudentsComboBox()
        {
            string connectionString = "Data Source=WIN-RGCFO3057QU;Initial Catalog=Diplom_Yspevaemost;Integrated Security=True;";
            string sqlQuery = "SELECT StudentID, Name + ' ' + Surname AS FullName FROM Students ORDER BY FullName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dtStudents = new DataTable();
                        dataAdapter.Fill(dtStudents);
                        comboBoxStudents.DataSource = dtStudents;
                        comboBoxStudents.DisplayMember = "FullName";
                        comboBoxStudents.ValueMember = "StudentID";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке списка учеников: " + ex.Message);
                    }
                }
            }
        }
        // Метод для заполнения ComboBoxClasses (без изменений)
        private void PopulateClassesComboBox()
        {
            string connectionString = "Data Source=WIN-RGCFO3057QU;Initial Catalog=Diplom_Yspevaemost;Integrated Security=True;";
            string sqlQuery = "SELECT ClassID, ClassName FROM Classes ORDER BY ClassName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dtClasses = new DataTable();
                        dataAdapter.Fill(dtClasses);
                        comboBoxClasses.DataSource = dtClasses;
                        comboBoxClasses.DisplayMember = "ClassName";
                        comboBoxClasses.ValueMember = "ClassID";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке списка классов: " + ex.Message);
                    }
                }
            }
        }
        // Методы отображения графиков (без изменений, так как они работают корректно после загрузки)
        // Метод для отображения распределения оценок по ученику
        private void DisplayGradeDistributionChartForStudent(int studentId)
        {
            string connectionString = "Data Source=WIN-RGCFO3057QU;Initial Catalog=Diplom_Yspevaemost;Integrated Security=True;";
            string sqlQuery = @"
                SELECT G.Grade, COUNT(G.Grade) AS GradeCount
                FROM Grades AS G INNER JOIN Students AS S ON G.StudentID = S.StudentID
                WHERE S.StudentID = @SelectedStudentID
                GROUP BY G.Grade ORDER BY G.Grade;";
            DataTable dtGradeDistribution = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@SelectedStudentID", studentId);
                    try { connection.Open(); SqlDataAdapter dataAdapter = new SqlDataAdapter(command); dataAdapter.Fill(dtGradeDistribution); }
                    catch (Exception ex) { MessageBox.Show("Ошибка при получении данных для распределения оценок ученика: " + ex.Message); return; }
                }
            }
            diagramChart.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series seriesDistribution = new System.Windows.Forms.DataVisualization.Charting.Series("Распределение оценок ученика");
            seriesDistribution.ChartType = SeriesChartType.Pie;
            if (dtGradeDistribution != null && dtGradeDistribution.Rows.Count > 0)
            {
                double totalGrades = dtGradeDistribution.AsEnumerable().Sum(row => row.Field<int>("GradeCount"));
                foreach (DataRow row in dtGradeDistribution.Rows)
                {
                    if (dtGradeDistribution.Columns.Contains("Grade") && dtGradeDistribution.Columns.Contains("GradeCount"))
                    {
                        if (row["Grade"] != DBNull.Value && row["GradeCount"] != DBNull.Value)
                        {
                            string gradeValue = row["Grade"].ToString();
                            int gradeCount = Convert.ToInt32(row["GradeCount"]);
                            string labelText = $"{gradeCount} ({(gradeCount / totalGrades):P0})";
                            string legendItemText = $"{gradeValue} - {gradeCount}";
                            DataPoint point = new DataPoint(0, gradeCount);
                            point.Label = labelText;
                            point.LegendText = legendItemText;
                            point.AxisLabel = gradeValue;
                            seriesDistribution.Points.Add(point);
                        }
                    }
                }
            }
            else { MessageBox.Show("Нет данных о распределении оценок для выбранного ученика."); }
            diagramChart.Series.Add(seriesDistribution);
            seriesDistribution.IsValueShownAsLabel = false;
            seriesDistribution.LegendText = "";
            diagramChart.Titles.Clear();
            string studentName = comboBoxStudents.Text;
            diagramChart.Titles.Add($"Оценки ученика: {studentName}");
            diagramChart.DataBind();
        }
        // Метод для отображения распределения оценок по классу
        private void DisplayGradeDistributionChartForClass(int classId)
        {
            string connectionString = "Data Source=WIN-RGCFO3057QU;Initial Catalog=Diplom_Yspevaemost;Integrated Security=True;";
            string sqlQuery = @"
                SELECT G.Grade, COUNT(G.Grade) AS GradeCount
                FROM Grades AS G INNER JOIN Students AS S ON G.StudentID = S.StudentID INNER JOIN Classes AS C ON S.ClassID = C.ClassID
                WHERE C.ClassID = @SelectedClassID GROUP BY G.Grade ORDER BY G.Grade;";
            DataTable dtGradeDistribution = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@SelectedClassID", classId);
                    try { connection.Open(); SqlDataAdapter dataAdapter = new SqlDataAdapter(command); dataAdapter.Fill(dtGradeDistribution); }
                    catch (Exception ex) { MessageBox.Show("Ошибка при получении данных для распределения оценок по классу: " + ex.Message); return; }
                }
            }
            diagramChart.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series seriesDistribution = new System.Windows.Forms.DataVisualization.Charting.Series("Оценки выбранного класса");
            seriesDistribution.ChartType = SeriesChartType.Column; // Вы можете выбрать Column или Pie
            if (dtGradeDistribution != null && dtGradeDistribution.Rows.Count > 0)
            {
                double totalGrades = dtGradeDistribution.AsEnumerable().Sum(row => row.Field<int>("GradeCount"));
                foreach (DataRow row in dtGradeDistribution.Rows)
                {
                    if (dtGradeDistribution.Columns.Contains("Grade") && dtGradeDistribution.Columns.Contains("GradeCount"))
                    {
                        if (row["Grade"] != DBNull.Value && row["GradeCount"] != DBNull.Value)
                        {
                            string gradeValue = row["Grade"].ToString();
                            int gradeCount = Convert.ToInt32(row["GradeCount"]);
                            DataPoint point = new DataPoint(0, gradeCount);
                            point.AxisLabel = gradeValue;
                            if (seriesDistribution.ChartType == SeriesChartType.Pie)
                            {
                                point.Label = $"{gradeCount} ({(gradeCount / totalGrades):P0})";
                                point.LegendText = $"{gradeValue} - {gradeCount}";
                            }
                            seriesDistribution.Points.Add(point);
                        }
                    }
                }
            }
            else { MessageBox.Show("Нет данных о распределении оценок для выбранного класса."); }
            diagramChart.Series.Add(seriesDistribution);
            if (seriesDistribution.ChartType == SeriesChartType.Pie)
            {
                seriesDistribution.IsValueShownAsLabel = false;
                seriesDistribution.LegendText = "";
            }
            diagramChart.Titles.Clear();
            string className = comboBoxClasses.Text;
            diagramChart.Titles.Add($"Оценки класса: {className}");
            diagramChart.DataBind();
        }
        // Обработчик события выбора ученика в ComboBox
        private void comboBoxStudents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue != null)
            {
                if (int.TryParse(comboBoxStudents.SelectedValue.ToString(), out int selectedStudentId))
                {
                    DisplayGradeDistributionChartForStudent(selectedStudentId);
                }
                else {  }
            }
        }
        // Обработчик события выбора класса в ComboBox
        private void comboBoxClasses_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxClasses.SelectedValue != null)
            {
                if (int.TryParse(comboBoxClasses.SelectedValue.ToString(), out int selectedClassId))
                {
                    DisplayGradeDistributionChartForClass(selectedClassId);
                }
                else {  }
            }
        }
        // Обработчики событий для RadioButtons
        private void radioButtonStudent_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked)
            {
                comboBoxStudents.Visible = true;
                comboBoxClasses.Visible = false;
                // При выборе "По ученику", отображаем график для текущего выбранного ученика
                if (comboBoxStudents.SelectedValue != null)
                {
                    if (int.TryParse(comboBoxStudents.SelectedValue.ToString(), out int selectedStudentId))
                    {
                        DisplayGradeDistributionChartForStudent(selectedStudentId);
                    }
                }
            }
        }
        private void radioButtonClass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonClass.Checked)
            {
                comboBoxStudents.Visible = false;
                comboBoxClasses.Visible = true;
                // При выборе "По классу", отображаем график для текущего выбранного класса
                if (comboBoxClasses.SelectedValue != null)
                {
                    if (int.TryParse(comboBoxClasses.SelectedValue.ToString(), out int selectedClassId))
                    {
                        DisplayGradeDistributionChartForClass(selectedClassId);
                    }
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            GradesAD frm = new GradesAD();
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

        private void Print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}