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
    public partial class zapros6 : Form
    {
        public zapros6()
        {
            InitializeComponent();
        }

        private void gradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.diplom_YspevaemostDataSet1);

        }

        private void zapros6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplom_YspevaemostDataSet1.Grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter.Fill(this.diplom_YspevaemostDataSet1.Grades);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WIN-RGCFO3057QU;Initial Catalog=Diplom_Yspevaemost;Integrated Security=True";
            string qwe = "SELECT \r\n    StudentID AS ИдентУченика, \r\n    AVG(Grade) AS СреднийБалл\r\nFROM \r\n    Grades \r\nGROUP BY \r\n    StudentID; ";
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
                    gradesDataGridView.DataSource = null;
                    // 2. Очищаем все существующие столбцы в DataGridView
                    // Это важно, если столбцы были настроены вручную или из другого источника данных
                    gradesDataGridView.Columns.Clear();
                    // 3. Устанавливаем новый DataTable как источник данных
                    gradesDataGridView.DataSource = newTable;
                    // 4. Позволяем DataGridView автоматически генерировать столбцы из DataSource
                    gradesDataGridView.AutoGenerateColumns = true;
                    // 5. Принудительно обновляем DataGridView
                    gradesDataGridView.Invalidate(); // Заставляет DataGridView перерисоваться
                    gradesDataGridView.Update();     // Обновляет отображение
                    gradesDataGridView.Refresh();    // Еще одно обновление

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении запроса:\n{ex.Message}", "Ошибка");
                gradesDataGridView.DataSource = null;
                gradesDataGridView.Columns.Clear(); // Очищаем столбцы при ошибке тоже
                gradesDataGridView.Invalidate();
                gradesDataGridView.Update();
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
    }
}
