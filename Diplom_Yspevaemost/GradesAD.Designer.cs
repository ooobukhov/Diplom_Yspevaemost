namespace Diplom_Yspevaemost
{
    partial class GradesAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesAD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PoleSortirovki = new System.Windows.Forms.ListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableAdapterManager = new Diplom_Yspevaemost.Diplom_YspevaemostDataSetTableAdapters.TableAdapterManager();
            this.gradesTableAdapter = new Diplom_Yspevaemost.Diplom_YspevaemostDataSetTableAdapters.GradesTableAdapter();
            this.gradesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.gradesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diplom_YspevaemostDataSet1 = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gradesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.DeleteBT = new System.Windows.Forms.ToolStripButton();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diplom_YspevaemostDataSet = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet();
            this.Sortirovka = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.filterBT = new System.Windows.Forms.Button();
            this.pokazatVseBT = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.lbGrades = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gradesTableAdapter1 = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.GradesTableAdapter();
            this.tableAdapterManager1 = new Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printBT = new System.Windows.Forms.Button();
            this.diagramBT = new System.Windows.Forms.Button();
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingNavigator)).BeginInit();
            this.gradesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PoleSortirovki
            // 
            this.PoleSortirovki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoleSortirovki.FormattingEnabled = true;
            this.PoleSortirovki.ItemHeight = 15;
            this.PoleSortirovki.Items.AddRange(new object[] {
            "Идент. оценки",
            "Идент. ученика",
            "Идент. предмета",
            "Идент. преподавателя",
            "Оценка",
            "Дата оценки",
            "Тип оценки"});
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.FinalGradesTableAdapter = null;
            this.tableAdapterManager.GradesTableAdapter = this.gradesTableAdapter;
            this.tableAdapterManager.ParentsTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom_Yspevaemost.Diplom_YspevaemostDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // gradesBindingNavigator
            // 
            this.gradesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gradesBindingNavigator.BindingSource = this.gradesBindingSource1;
            this.gradesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gradesBindingNavigator.DeleteItem = null;
            this.gradesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gradesBindingNavigatorSaveItem,
            this.DeleteBT});
            this.gradesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gradesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gradesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gradesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gradesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gradesBindingNavigator.Name = "gradesBindingNavigator";
            this.gradesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gradesBindingNavigator.Size = new System.Drawing.Size(1101, 25);
            this.gradesBindingNavigator.TabIndex = 87;
            this.gradesBindingNavigator.Text = "bindingNavigator1";
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
            // gradesBindingSource1
            // 
            this.gradesBindingSource1.DataMember = "Grades";
            this.gradesBindingSource1.DataSource = this.diplom_YspevaemostDataSet1;
            // 
            // diplom_YspevaemostDataSet1
            // 
            this.diplom_YspevaemostDataSet1.DataSetName = "Diplom_YspevaemostDataSet1";
            this.diplom_YspevaemostDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // gradesBindingNavigatorSaveItem
            // 
            this.gradesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gradesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gradesBindingNavigatorSaveItem.Image")));
            this.gradesBindingNavigatorSaveItem.Name = "gradesBindingNavigatorSaveItem";
            this.gradesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gradesBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // DeleteBT
            // 
            this.DeleteBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteBT.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBT.Image")));
            this.DeleteBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(23, 22);
            this.DeleteBT.Text = "Удалить";
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "Grades";
            this.gradesBindingSource.DataSource = this.diplom_YspevaemostDataSet;
            // 
            // diplom_YspevaemostDataSet
            // 
            this.diplom_YspevaemostDataSet.DataSetName = "Diplom_YspevaemostDataSet";
            this.diplom_YspevaemostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(772, 502);
            this.exit.MaximumSize = new System.Drawing.Size(200, 100);
            this.exit.MinimumSize = new System.Drawing.Size(100, 50);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(167, 50);
            this.exit.TabIndex = 94;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.filterCB);
            this.groupBox3.Controls.Add(this.filterBT);
            this.groupBox3.Controls.Add(this.pokazatVseBT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 120);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтр";
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
            this.filterCB.DataSource = this.gradesBindingSource1;
            this.filterCB.DisplayMember = "GradeDate";
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Location = new System.Drawing.Point(89, 32);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(189, 24);
            this.filterCB.TabIndex = 9;
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
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.White;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(569, 502);
            this.back_button.MaximumSize = new System.Drawing.Size(200, 200);
            this.back_button.MinimumSize = new System.Drawing.Size(100, 50);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(167, 50);
            this.back_button.TabIndex = 93;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 120);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 10;
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
            // lbGrades
            // 
            this.lbGrades.AutoSize = true;
            this.lbGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGrades.Location = new System.Drawing.Point(392, 52);
            this.lbGrades.Name = "lbGrades";
            this.lbGrades.Size = new System.Drawing.Size(208, 25);
            this.lbGrades.TabIndex = 89;
            this.lbGrades.Text = "Таблица \"Оценки\"";
            this.lbGrades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.groupBox1.Location = new System.Drawing.Point(302, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 243);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // gradesTableAdapter1
            // 
            this.gradesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AttendanceTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClassesTableAdapter = null;
            this.tableAdapterManager1.DocumentsTableAdapter = null;
            this.tableAdapterManager1.FinalGradesTableAdapter = null;
            this.tableAdapterManager1.GradesTableAdapter = this.gradesTableAdapter1;
            this.tableAdapterManager1.ParentsTableAdapter = null;
            this.tableAdapterManager1.ScheduleTableAdapter = null;
            this.tableAdapterManager1.StudentsTableAdapter = null;
            this.tableAdapterManager1.SubjectsTableAdapter = null;
            this.tableAdapterManager1.TeachersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Diplom_Yspevaemost.Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printBT
            // 
            this.printBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBT.BackColor = System.Drawing.Color.White;
            this.printBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBT.ForeColor = System.Drawing.Color.Black;
            this.printBT.Location = new System.Drawing.Point(569, 414);
            this.printBT.MaximumSize = new System.Drawing.Size(200, 200);
            this.printBT.MinimumSize = new System.Drawing.Size(100, 50);
            this.printBT.Name = "printBT";
            this.printBT.Size = new System.Drawing.Size(167, 50);
            this.printBT.TabIndex = 102;
            this.printBT.Text = "Печать";
            this.printBT.UseVisualStyleBackColor = false;
            this.printBT.Click += new System.EventHandler(this.printBT_Click);
            // 
            // diagramBT
            // 
            this.diagramBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagramBT.BackColor = System.Drawing.Color.White;
            this.diagramBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagramBT.ForeColor = System.Drawing.Color.Black;
            this.diagramBT.Location = new System.Drawing.Point(772, 414);
            this.diagramBT.MaximumSize = new System.Drawing.Size(200, 200);
            this.diagramBT.MinimumSize = new System.Drawing.Size(150, 50);
            this.diagramBT.Name = "diagramBT";
            this.diagramBT.Size = new System.Drawing.Size(167, 50);
            this.diagramBT.TabIndex = 103;
            this.diagramBT.Text = "Диаграмма/график оценок";
            this.diagramBT.UseVisualStyleBackColor = false;
            this.diagramBT.Click += new System.EventHandler(this.diagramBT_Click);
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.AutoGenerateColumns = false;
            this.gradesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gradesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gradesDataGridView.DataSource = this.gradesBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gradesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gradesDataGridView.Location = new System.Drawing.Point(12, 80);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.Size = new System.Drawing.Size(927, 220);
            this.gradesDataGridView.TabIndex = 103;
            this.gradesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gradesDataGridView_CellContentClick);
            this.gradesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gradesDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GradeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идент. оценки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Идент. ученика";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Идент. предмета";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GradeDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата оценки";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GradeType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Тип оценки";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // GradesAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1101, 561);
            this.Controls.Add(this.gradesDataGridView);
            this.Controls.Add(this.diagramBT);
            this.Controls.Add(this.printBT);
            this.Controls.Add(this.gradesBindingNavigator);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbGrades);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "GradesAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица \"Оценки\"";
            this.Load += new System.EventHandler(this.GradesAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingNavigator)).EndInit();
            this.gradesBindingNavigator.ResumeLayout(false);
            this.gradesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplom_YspevaemostDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox PoleSortirovki;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private Diplom_YspevaemostDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Diplom_YspevaemostDataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.BindingNavigator gradesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private Diplom_YspevaemostDataSet diplom_YspevaemostDataSet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton gradesBindingNavigatorSaveItem;
        private System.Windows.Forms.Button Sortirovka;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.Button filterBT;
        private System.Windows.Forms.Button pokazatVseBT;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label lbGrades;
        private System.Windows.Forms.GroupBox groupBox1;
        private Diplom_YspevaemostDataSet1 diplom_YspevaemostDataSet1;
        private System.Windows.Forms.BindingSource gradesBindingSource1;
        private Diplom_YspevaemostDataSet1TableAdapters.GradesTableAdapter gradesTableAdapter1;
        private Diplom_YspevaemostDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button printBT;
        private System.Windows.Forms.ToolStripButton DeleteBT;
        private System.Windows.Forms.Button diagramBT;
        private System.Windows.Forms.DataGridView gradesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}