namespace Diplom_Yspevaemost
{
    partial class SheduleAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheduleAD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbFinalGrades = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplom_YspevaemostDataSet1 = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filterBT = new System.Windows.Forms.Button();
            this.pokazatVseBT = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.PoleSortirovki = new System.Windows.Forms.ListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Sortirovka = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printBT = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.scheduleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleTableAdapter = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.ScheduleTableAdapter();
            this.tableAdapterManager = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager();
            this.scheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingNavigator)).BeginInit();
            this.scheduleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFinalGrades
            // 
            this.lbFinalGrades.AutoSize = true;
            this.lbFinalGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFinalGrades.Location = new System.Drawing.Point(342, 36);
            this.lbFinalGrades.Name = "lbFinalGrades";
            this.lbFinalGrades.Size = new System.Drawing.Size(257, 25);
            this.lbFinalGrades.TabIndex = 109;
            this.lbFinalGrades.Text = "Таблица \"Расписание\"";
            this.lbFinalGrades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Наименование";
            // 
            // filterCB
            // 
            this.filterCB.DataSource = this.scheduleBindingSource;
            this.filterCB.DisplayMember = "ScheduleID";
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Location = new System.Drawing.Point(89, 32);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(189, 24);
            this.filterCB.TabIndex = 9;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.diplom_YspevaemostDataSet1;
            // 
            // diplom_YspevaemostDataSet1
            // 
            this.diplom_YspevaemostDataSet1.DataSetName = "Diplom_YspevaemostDataSet1";
            this.diplom_YspevaemostDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Критерий";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.filterCB);
            this.groupBox3.Controls.Add(this.filterBT);
            this.groupBox3.Controls.Add(this.pokazatVseBT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 120);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтр";
            // 
            // filterBT
            // 
            this.filterBT.BackColor = System.Drawing.Color.White;
            this.filterBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterBT.Location = new System.Drawing.Point(0, 83);
            this.filterBT.Name = "filterBT";
            this.filterBT.Size = new System.Drawing.Size(97, 37);
            this.filterBT.TabIndex = 5;
            this.filterBT.Text = "Фильтровать";
            this.filterBT.UseVisualStyleBackColor = false;
            this.filterBT.Click += new System.EventHandler(this.filterBT_Click);
            // 
            // pokazatVseBT
            // 
            this.pokazatVseBT.BackColor = System.Drawing.Color.White;
            this.pokazatVseBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pokazatVseBT.Location = new System.Drawing.Point(187, 83);
            this.pokazatVseBT.Name = "pokazatVseBT";
            this.pokazatVseBT.Size = new System.Drawing.Size(97, 37);
            this.pokazatVseBT.TabIndex = 6;
            this.pokazatVseBT.Text = "Показать все";
            this.pokazatVseBT.UseVisualStyleBackColor = false;
            this.pokazatVseBT.Click += new System.EventHandler(this.pokazatVseBT_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(811, 488);
            this.exit.MaximumSize = new System.Drawing.Size(200, 100);
            this.exit.MinimumSize = new System.Drawing.Size(100, 50);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 50);
            this.exit.TabIndex = 107;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // PoleSortirovki
            // 
            this.PoleSortirovki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoleSortirovki.FormattingEnabled = true;
            this.PoleSortirovki.ItemHeight = 15;
            this.PoleSortirovki.Items.AddRange(new object[] {
            "Идент. расписания",
            "Идент. класса",
            "Идент. урока",
            "Идент. преподавателя",
            "День недели",
            "Номер урока",
            "Класс"});
            this.PoleSortirovki.Location = new System.Drawing.Point(6, 46);
            this.PoleSortirovki.Name = "PoleSortirovki";
            this.PoleSortirovki.Size = new System.Drawing.Size(235, 109);
            this.PoleSortirovki.TabIndex = 15;
            this.PoleSortirovki.SelectedIndexChanged += new System.EventHandler(this.PoleSortirovki_SelectedIndexChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(3, 182);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(173, 19);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Сортировка по убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Поле для сортировки";
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.White;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(558, 487);
            this.back_button.MaximumSize = new System.Drawing.Size(200, 100);
            this.back_button.MinimumSize = new System.Drawing.Size(100, 50);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(150, 50);
            this.back_button.TabIndex = 106;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.PoleSortirovki);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.Sortirovka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(302, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 243);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(3, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(192, 19);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сортировка по возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Sortirovka
            // 
            this.Sortirovka.BackColor = System.Drawing.Color.White;
            this.Sortirovka.Enabled = false;
            this.Sortirovka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sortirovka.Location = new System.Drawing.Point(6, 207);
            this.Sortirovka.Name = "Sortirovka";
            this.Sortirovka.Size = new System.Drawing.Size(235, 37);
            this.Sortirovka.TabIndex = 4;
            this.Sortirovka.Text = "Сортировать";
            this.Sortirovka.UseVisualStyleBackColor = false;
            this.Sortirovka.Click += new System.EventHandler(this.Sortirovka_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(187, 83);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(97, 37);
            this.Search.TabIndex = 7;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 120);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(558, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // printBT
            // 
            this.printBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBT.BackColor = System.Drawing.Color.White;
            this.printBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBT.ForeColor = System.Drawing.Color.Black;
            this.printBT.Location = new System.Drawing.Point(558, 417);
            this.printBT.MaximumSize = new System.Drawing.Size(200, 100);
            this.printBT.MinimumSize = new System.Drawing.Size(100, 50);
            this.printBT.Name = "printBT";
            this.printBT.Size = new System.Drawing.Size(150, 50);
            this.printBT.TabIndex = 112;
            this.printBT.Text = "Печать";
            this.printBT.UseVisualStyleBackColor = false;
            this.printBT.Click += new System.EventHandler(this.printBT_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // scheduleIDDataGridViewTextBoxColumn1
            // 
            this.scheduleIDDataGridViewTextBoxColumn1.DataPropertyName = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn1.HeaderText = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn1.Name = "scheduleIDDataGridViewTextBoxColumn1";
            this.scheduleIDDataGridViewTextBoxColumn1.Width = 60;
            // 
            // classIDDataGridViewTextBoxColumn1
            // 
            this.classIDDataGridViewTextBoxColumn1.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn1.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn1.Name = "classIDDataGridViewTextBoxColumn1";
            this.classIDDataGridViewTextBoxColumn1.Width = 61;
            // 
            // subjectIDDataGridViewTextBoxColumn1
            // 
            this.subjectIDDataGridViewTextBoxColumn1.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn1.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn1.Name = "subjectIDDataGridViewTextBoxColumn1";
            this.subjectIDDataGridViewTextBoxColumn1.Width = 60;
            // 
            // teacherIDDataGridViewTextBoxColumn1
            // 
            this.teacherIDDataGridViewTextBoxColumn1.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn1.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn1.Name = "teacherIDDataGridViewTextBoxColumn1";
            this.teacherIDDataGridViewTextBoxColumn1.Width = 61;
            // 
            // dayOfWeekDataGridViewTextBoxColumn1
            // 
            this.dayOfWeekDataGridViewTextBoxColumn1.DataPropertyName = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn1.HeaderText = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn1.Name = "dayOfWeekDataGridViewTextBoxColumn1";
            this.dayOfWeekDataGridViewTextBoxColumn1.Width = 60;
            // 
            // lessonNumberDataGridViewTextBoxColumn1
            // 
            this.lessonNumberDataGridViewTextBoxColumn1.DataPropertyName = "LessonNumber";
            this.lessonNumberDataGridViewTextBoxColumn1.HeaderText = "LessonNumber";
            this.lessonNumberDataGridViewTextBoxColumn1.Name = "lessonNumberDataGridViewTextBoxColumn1";
            this.lessonNumberDataGridViewTextBoxColumn1.Width = 61;
            // 
            // roomDataGridViewTextBoxColumn1
            // 
            this.roomDataGridViewTextBoxColumn1.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn1.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn1.Name = "roomDataGridViewTextBoxColumn1";
            this.roomDataGridViewTextBoxColumn1.Width = 60;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.FinalGradesTableAdapter = null;
            this.tableAdapterManager.GradesTableAdapter = null;
            this.tableAdapterManager.ParentsTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = this.scheduleTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // scheduleBindingNavigator
            // 
            this.scheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scheduleBindingNavigator.BindingSource = this.scheduleBindingSource;
            this.scheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.scheduleBindingNavigatorSaveItem});
            this.scheduleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.scheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scheduleBindingNavigator.Name = "scheduleBindingNavigator";
            this.scheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scheduleBindingNavigator.Size = new System.Drawing.Size(1084, 25);
            this.scheduleBindingNavigator.TabIndex = 113;
            this.scheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // scheduleBindingNavigatorSaveItem
            // 
            this.scheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleBindingNavigatorSaveItem.Image")));
            this.scheduleBindingNavigatorSaveItem.Name = "scheduleBindingNavigatorSaveItem";
            this.scheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.scheduleBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.scheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.scheduleBindingNavigatorSaveItem_Click);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.AutoGenerateColumns = false;
            this.scheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scheduleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.scheduleDataGridView.DataSource = this.scheduleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scheduleDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.scheduleDataGridView.Location = new System.Drawing.Point(12, 64);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.Size = new System.Drawing.Size(949, 220);
            this.scheduleDataGridView.TabIndex = 113;
            this.scheduleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.scheduleDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ScheduleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идент. расписания";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClassID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Идент. класса";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Идент. урока";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TeacherID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Идент. преподавателя";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DayOfWeek";
            this.dataGridViewTextBoxColumn5.HeaderText = "День недели";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LessonNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер урока";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn7.HeaderText = "Класс";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // SheduleAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.scheduleBindingNavigator);
            this.Controls.Add(this.printBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFinalGrades);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "SheduleAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица \"Расписание\"";
            this.Load += new System.EventHandler(this.SheduleAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingNavigator)).EndInit();
            this.scheduleBindingNavigator.ResumeLayout(false);
            this.scheduleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFinalGrades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button filterBT;
        private System.Windows.Forms.Button pokazatVseBT;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox PoleSortirovki;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Sortirovka;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button printBT;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn1;
        private Diplom_YspevaemostDataSet1 diplom_YspevaemostDataSet1;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private Diplom_YspevaemostDataSet1TableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scheduleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton scheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}