namespace Diplom_Yspevaemost
{
    partial class DinamicYspevaemostiTeacher
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinamicYspevaemostiTeacher));
            this.lbFinalGrades = new System.Windows.Forms.Label();
            this.diagramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonClass = new System.Windows.Forms.RadioButton();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Print = new System.Drawing.Printing.PrintDocument();
            this.printBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagramChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFinalGrades
            // 
            this.lbFinalGrades.AutoSize = true;
            this.lbFinalGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFinalGrades.Location = new System.Drawing.Point(214, 28);
            this.lbFinalGrades.Name = "lbFinalGrades";
            this.lbFinalGrades.Size = new System.Drawing.Size(196, 24);
            this.lbFinalGrades.TabIndex = 96;
            this.lbFinalGrades.Text = "Диаграмма/график";
            this.lbFinalGrades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // diagramChart
            // 
            chartArea1.Name = "ChartArea1";
            this.diagramChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.diagramChart.Legends.Add(legend1);
            this.diagramChart.Location = new System.Drawing.Point(75, 55);
            this.diagramChart.Name = "diagramChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.diagramChart.Series.Add(series1);
            this.diagramChart.Size = new System.Drawing.Size(461, 249);
            this.diagramChart.TabIndex = 97;
            this.diagramChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Выберите по какому критерию вывести данные";
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonStudent.Location = new System.Drawing.Point(75, 333);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(320, 24);
            this.radioButtonStudent.TabIndex = 99;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Диаграмма успеваемости по ученикам";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.AutoSize = true;
            this.radioButtonClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonClass.Location = new System.Drawing.Point(75, 363);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(285, 24);
            this.radioButtonClass.TabIndex = 100;
            this.radioButtonClass.TabStop = true;
            this.radioButtonClass.Text = "График успеваемости по классам";
            this.radioButtonClass.UseVisualStyleBackColor = true;
            this.radioButtonClass.CheckedChanged += new System.EventHandler(this.radioButtonClass_CheckedChanged);
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(401, 337);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(126, 21);
            this.comboBoxStudents.TabIndex = 101;
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(401, 367);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(126, 21);
            this.comboBoxClasses.TabIndex = 102;
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.White;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(75, 396);
            this.back_button.MaximumSize = new System.Drawing.Size(200, 50);
            this.back_button.MinimumSize = new System.Drawing.Size(100, 50);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(150, 50);
            this.back_button.TabIndex = 103;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(281, 396);
            this.exit.MaximumSize = new System.Drawing.Size(200, 50);
            this.exit.MinimumSize = new System.Drawing.Size(100, 50);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 50);
            this.exit.TabIndex = 104;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Print
            // 
            this.Print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Print_PrintPage_1);
            // 
            // printBT
            // 
            this.printBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBT.BackColor = System.Drawing.Color.White;
            this.printBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBT.Location = new System.Drawing.Point(491, 396);
            this.printBT.MaximumSize = new System.Drawing.Size(200, 50);
            this.printBT.MinimumSize = new System.Drawing.Size(100, 50);
            this.printBT.Name = "printBT";
            this.printBT.Size = new System.Drawing.Size(150, 50);
            this.printBT.TabIndex = 105;
            this.printBT.Text = "Печать";
            this.printBT.UseVisualStyleBackColor = false;
            this.printBT.Click += new System.EventHandler(this.printBT_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // DinamicYspevaemostiTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.printBT);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.radioButtonClass);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagramChart);
            this.Controls.Add(this.lbFinalGrades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "DinamicYspevaemostiTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диаграмма/график оценок";
            this.Load += new System.EventHandler(this.DinamicYspevaemosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagramChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFinalGrades;
        private System.Windows.Forms.DataVisualization.Charting.Chart diagramChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonClass;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button exit;
        private System.Drawing.Printing.PrintDocument Print;
        private System.Windows.Forms.Button printBT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}