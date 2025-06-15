namespace Diplom_Yspevaemost
{
    partial class zapros5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zapros5));
            this.diplom_YspevaemostDataSet1 = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1();
            this.finalGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalGradesTableAdapter = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.FinalGradesTableAdapter();
            this.tableAdapterManager = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager();
            this.finalGradesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.attendanceTableAdapter1 = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.AttendanceTableAdapter();
            this.printBT = new System.Windows.Forms.Button();
            this.Print = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGradesDataGridView)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // diplom_YspevaemostDataSet1
            // 
            this.diplom_YspevaemostDataSet1.DataSetName = "Diplom_YspevaemostDataSet1";
            this.diplom_YspevaemostDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalGradesBindingSource
            // 
            this.finalGradesBindingSource.DataMember = "FinalGrades";
            this.finalGradesBindingSource.DataSource = this.diplom_YspevaemostDataSet1;
            // 
            // finalGradesTableAdapter
            // 
            this.finalGradesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.FinalGradesTableAdapter = this.finalGradesTableAdapter;
            this.tableAdapterManager.GradesTableAdapter = null;
            this.tableAdapterManager.ParentsTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // finalGradesDataGridView
            // 
            this.finalGradesDataGridView.AutoGenerateColumns = false;
            this.finalGradesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finalGradesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.finalGradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalGradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.finalGradesDataGridView.DataSource = this.finalGradesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.finalGradesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.finalGradesDataGridView.Location = new System.Drawing.Point(12, 73);
            this.finalGradesDataGridView.Name = "finalGradesDataGridView";
            this.finalGradesDataGridView.Size = new System.Drawing.Size(250, 99);
            this.finalGradesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FinalGrade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Итоговые оценки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(834, 25);
            this.fillBy1ToolStrip.TabIndex = 1;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(308, 22);
            this.fillBy1ToolStripButton.Text = "Подсчет ср. балла итоговых оценок старших классов";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "Подсчет среднего балла итоговых оценок в старших классах";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(270, 388);
            this.exit.MaximumSize = new System.Drawing.Size(200, 100);
            this.exit.MinimumSize = new System.Drawing.Size(100, 50);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 50);
            this.exit.TabIndex = 102;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.White;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(12, 388);
            this.back_button.MaximumSize = new System.Drawing.Size(200, 100);
            this.back_button.MinimumSize = new System.Drawing.Size(100, 50);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(150, 50);
            this.back_button.TabIndex = 101;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // printBT
            // 
            this.printBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBT.BackColor = System.Drawing.Color.White;
            this.printBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBT.ForeColor = System.Drawing.Color.Black;
            this.printBT.Location = new System.Drawing.Point(270, 332);
            this.printBT.MaximumSize = new System.Drawing.Size(200, 100);
            this.printBT.MinimumSize = new System.Drawing.Size(100, 50);
            this.printBT.Name = "printBT";
            this.printBT.Size = new System.Drawing.Size(150, 50);
            this.printBT.TabIndex = 103;
            this.printBT.Text = "Печать";
            this.printBT.UseVisualStyleBackColor = false;
            this.printBT.Click += new System.EventHandler(this.printBT_Click);
            // 
            // Print
            // 
            this.Print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Print_PrintPage);
            // 
            // zapros5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.printBT);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.finalGradesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "zapros5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсчет ср. балла в старших классах";
            this.Load += new System.EventHandler(this.zapros5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalGradesDataGridView)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Diplom_YspevaemostDataSet1 diplom_YspevaemostDataSet1;
        private System.Windows.Forms.BindingSource finalGradesBindingSource;
        private Diplom_YspevaemostDataSet1TableAdapters.FinalGradesTableAdapter finalGradesTableAdapter;
        private Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView finalGradesDataGridView;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back_button;
        private Diplom_YspevaemostDataSet1TableAdapters.AttendanceTableAdapter attendanceTableAdapter1;
        private System.Windows.Forms.Button printBT;
        private System.Drawing.Printing.PrintDocument Print;
    }
}