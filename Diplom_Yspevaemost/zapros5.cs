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

namespace Diplom_Yspevaemost
{
    public partial class zapros5 : Form
    {
        public zapros5()
        {
            InitializeComponent();
        }

        private void finalGradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finalGradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplom_YspevaemostDataSet1);

        }

        private void zapros5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet1.FinalGrades". При необходимости она может быть перемещена или удалена.
            this.finalGradesTableAdapter.Fill(this.diplom_YspevaemostDataSet1.FinalGrades);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WIN-RGCFO3057QU;Initial Catalog=Diplom_Yspevaemost;Integrated Security=True";
            string qwe = "SELECT AVG(FinalGrade) as Средний_балл FROM FinalGrades";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qwe, connection);
                    DataTable newTable = new DataTable();
                    adapter.Fill(newTable);
                    // --- ДОБАВЛЕНО ДЛЯ УСИЛЕНИЯ ПРИВЯЗКИ И ОБНОВЛЕНИЯ ---
                    // 1. очищаем DataSource
                    finalGradesDataGridView.DataSource = null;
                    // 2. Очищаем все существующие столбцы в DataGridView
                    // Это важно, если столбцы были настроены вручную или из другого источника данных
                    finalGradesDataGridView.Columns.Clear();
                    // 3. Устанавливаем новый DataTable как источник данных
                    finalGradesDataGridView.DataSource = newTable;
                    // 4. Позволяем DataGridView автоматически генерировать столбцы из DataSource
                    finalGradesDataGridView.AutoGenerateColumns = true;
                    // 5. Принудительно обновляем DataGridView
                    finalGradesDataGridView.Invalidate(); // Заставляет DataGridView перерисоваться
                    finalGradesDataGridView.Update();     // Обновляет отображение
                    finalGradesDataGridView.Refresh();    // Еще одно обновление

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении запроса:\n{ex.Message}", "Ошибка");
                finalGradesDataGridView.DataSource = null;
                finalGradesDataGridView.Columns.Clear(); // Очищаем столбцы при ошибке тоже
                finalGradesDataGridView.Invalidate();
                finalGradesDataGridView.Update();
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
