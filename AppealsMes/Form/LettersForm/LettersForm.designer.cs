
namespace Appeals_Mes
{
    partial class LettersForm
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
            this.SelectOtvet = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectLetters = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.userControlButton2 = new WindowsFormsApp2.UserControlButton();
            this.dateTimePickerPo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerS = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItsRange = new WindowsFormsApp2.UserControlButton();
            this.label11 = new System.Windows.Forms.Label();
            this.Today = new WindowsFormsApp2.UserControlButton();
            this.MyAppeasl = new Appeals_Mes.UserControlToggleButton();
            this.Last30days = new WindowsFormsApp2.UserControlButton();
            this.Last7days = new WindowsFormsApp2.UserControlButton();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchRecords = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProblemAppealsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddAnswer = new FontAwesome.Sharp.IconPictureBox();
            this.RedAnswer = new FontAwesome.Sharp.IconPictureBox();
            this.DelAnswer = new FontAwesome.Sharp.IconPictureBox();
            this.Addleters = new WindowsFormsApp2.UserControlButton();
            this.userControlButton6 = new WindowsFormsApp2.UserControlButton();
            this.RedLetters = new WindowsFormsApp2.UserControlButton();
            ((System.ComponentModel.ISupportInitialize)(this.SelectOtvet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLetters)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectOtvet
            // 
            this.SelectOtvet.AllowUserToAddRows = false;
            this.SelectOtvet.AllowUserToDeleteRows = false;
            this.SelectOtvet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectOtvet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectOtvet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectOtvet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectOtvet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.SelectOtvet.Location = new System.Drawing.Point(518, 217);
            this.SelectOtvet.Name = "SelectOtvet";
            this.SelectOtvet.ReadOnly = true;
            this.SelectOtvet.Size = new System.Drawing.Size(457, 488);
            this.SelectOtvet.TabIndex = 52;
            this.SelectOtvet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectOtvet_CellClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "id_answer_letter";
            this.Column7.HeaderText = "Номер ответа";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "id_letter";
            this.Column8.HeaderText = "Номер письма";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Fioe";
            this.Column9.HeaderText = "Фио сотрудника";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "statuses";
            this.Column10.HeaderText = "Статус";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Description";
            this.Column11.HeaderText = "Описание";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "DateAnsewer";
            this.Column12.HeaderText = "Дата написания ";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // SelectLetters
            // 
            this.SelectLetters.AllowUserToAddRows = false;
            this.SelectLetters.AllowUserToDeleteRows = false;
            this.SelectLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLetters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectLetters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectLetters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectLetters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.SelectLetters.Location = new System.Drawing.Point(12, 217);
            this.SelectLetters.Name = "SelectLetters";
            this.SelectLetters.ReadOnly = true;
            this.SelectLetters.Size = new System.Drawing.Size(489, 488);
            this.SelectLetters.TabIndex = 46;
            this.SelectLetters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectLetters_CellClick);
            this.SelectLetters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectLetters_CellDoubleClick);
            this.SelectLetters.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SelectLetters_RowsAdded);
            this.SelectLetters.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.SelectLetters_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_letter";
            this.Column1.HeaderText = "Номер письма";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id_solving_problem";
            this.Column2.HeaderText = "Номер решения проблемы";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Fioe";
            this.Column3.HeaderText = "Фио сотрудника";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Date_outgoing";
            this.Column4.HeaderText = "Дата написания";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.HeaderText = "Описание";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "AnswerCh";
            this.Column6.HeaderText = "Кол-во ответов потребителя";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.userControlButton2);
            this.groupBox3.Controls.Add(this.dateTimePickerPo);
            this.groupBox3.Controls.Add(this.dateTimePickerS);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ItsRange);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Today);
            this.groupBox3.Controls.Add(this.MyAppeasl);
            this.groupBox3.Controls.Add(this.Last30days);
            this.groupBox3.Controls.Add(this.Last7days);
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(963, 91);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отбор записей по дате написания письма";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // userControlButton2
            // 
            this.userControlButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userControlButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userControlButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userControlButton2.BorderRadius = 20;
            this.userControlButton2.BorderSize = 1;
            this.userControlButton2.FlatAppearance.BorderSize = 0;
            this.userControlButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userControlButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlButton2.ForeColor = System.Drawing.Color.Black;
            this.userControlButton2.Location = new System.Drawing.Point(645, 28);
            this.userControlButton2.Name = "userControlButton2";
            this.userControlButton2.Size = new System.Drawing.Size(107, 51);
            this.userControlButton2.TabIndex = 72;
            this.userControlButton2.Text = "Отмена";
            this.userControlButton2.TextColor = System.Drawing.Color.Black;
            this.userControlButton2.UseVisualStyleBackColor = false;
            this.userControlButton2.Click += new System.EventHandler(this.userControlButton2_Click);
            // 
            // dateTimePickerPo
            // 
            this.dateTimePickerPo.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePickerPo.Enabled = false;
            this.dateTimePickerPo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPo.Location = new System.Drawing.Point(40, 54);
            this.dateTimePickerPo.Name = "dateTimePickerPo";
            this.dateTimePickerPo.Size = new System.Drawing.Size(152, 25);
            this.dateTimePickerPo.TabIndex = 56;
            // 
            // dateTimePickerS
            // 
            this.dateTimePickerS.Enabled = false;
            this.dateTimePickerS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerS.Location = new System.Drawing.Point(40, 25);
            this.dateTimePickerS.Name = "dateTimePickerS";
            this.dateTimePickerS.Size = new System.Drawing.Size(152, 25);
            this.dateTimePickerS.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "С";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "По";
            // 
            // ItsRange
            // 
            this.ItsRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ItsRange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ItsRange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ItsRange.BorderRadius = 20;
            this.ItsRange.BorderSize = 1;
            this.ItsRange.FlatAppearance.BorderSize = 0;
            this.ItsRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItsRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ItsRange.ForeColor = System.Drawing.Color.Black;
            this.ItsRange.Location = new System.Drawing.Point(201, 27);
            this.ItsRange.Name = "ItsRange";
            this.ItsRange.Size = new System.Drawing.Size(107, 52);
            this.ItsRange.TabIndex = 53;
            this.ItsRange.Text = "*Свой диапозон";
            this.ItsRange.TextColor = System.Drawing.Color.Black;
            this.ItsRange.UseVisualStyleBackColor = false;
            this.ItsRange.Click += new System.EventHandler(this.userControlButton8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(782, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 91;
            this.label11.Text = "Мои записи";
            // 
            // Today
            // 
            this.Today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Today.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Today.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Today.BorderRadius = 20;
            this.Today.BorderSize = 1;
            this.Today.FlatAppearance.BorderSize = 0;
            this.Today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Today.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.ForeColor = System.Drawing.Color.Black;
            this.Today.Location = new System.Drawing.Point(314, 27);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(103, 52);
            this.Today.TabIndex = 57;
            this.Today.Text = "Сегодня";
            this.Today.TextColor = System.Drawing.Color.Black;
            this.Today.UseVisualStyleBackColor = false;
            // 
            // MyAppeasl
            // 
            this.MyAppeasl.Checked = true;
            this.MyAppeasl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MyAppeasl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyAppeasl.Location = new System.Drawing.Point(867, 41);
            this.MyAppeasl.MinimumSize = new System.Drawing.Size(45, 22);
            this.MyAppeasl.Name = "MyAppeasl";
            this.MyAppeasl.OffBackColor = System.Drawing.Color.Gray;
            this.MyAppeasl.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.MyAppeasl.OnBackColor = System.Drawing.Color.OrangeRed;
            this.MyAppeasl.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.MyAppeasl.Size = new System.Drawing.Size(47, 22);
            this.MyAppeasl.TabIndex = 90;
            this.MyAppeasl.UseVisualStyleBackColor = true;
            this.MyAppeasl.CheckedChanged += new System.EventHandler(this.MyAppeasl_CheckedChanged);
            // 
            // Last30days
            // 
            this.Last30days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Last30days.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Last30days.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Last30days.BorderRadius = 20;
            this.Last30days.BorderSize = 1;
            this.Last30days.FlatAppearance.BorderSize = 0;
            this.Last30days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Last30days.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last30days.ForeColor = System.Drawing.Color.Black;
            this.Last30days.Location = new System.Drawing.Point(536, 27);
            this.Last30days.Name = "Last30days";
            this.Last30days.Size = new System.Drawing.Size(103, 52);
            this.Last30days.TabIndex = 59;
            this.Last30days.Text = "В течении 30 дней";
            this.Last30days.TextColor = System.Drawing.Color.Black;
            this.Last30days.UseVisualStyleBackColor = false;
            // 
            // Last7days
            // 
            this.Last7days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Last7days.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Last7days.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Last7days.BorderRadius = 20;
            this.Last7days.BorderSize = 1;
            this.Last7days.FlatAppearance.BorderSize = 0;
            this.Last7days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Last7days.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last7days.ForeColor = System.Drawing.Color.Black;
            this.Last7days.Location = new System.Drawing.Point(423, 27);
            this.Last7days.Name = "Last7days";
            this.Last7days.Size = new System.Drawing.Size(107, 52);
            this.Last7days.TabIndex = 58;
            this.Last7days.Text = "В течении 7 дней";
            this.Last7days.TextColor = System.Drawing.Color.Black;
            this.Last7days.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 93;
            this.label7.Text = "Поиск";
            // 
            // SearchRecords
            // 
            this.SearchRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchRecords.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchRecords.Location = new System.Drawing.Point(747, 34);
            this.SearchRecords.Name = "SearchRecords";
            this.SearchRecords.Size = new System.Drawing.Size(228, 25);
            this.SearchRecords.TabIndex = 92;
            this.SearchRecords.TextChanged += new System.EventHandler(this.SearchRecords_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 17);
            this.label9.TabIndex = 95;
            this.label9.Text = "Отправленные письма";
            // 
            // ProblemAppealsCount
            // 
            this.ProblemAppealsCount.AutoSize = true;
            this.ProblemAppealsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemAppealsCount.Location = new System.Drawing.Point(158, 197);
            this.ProblemAppealsCount.Name = "ProblemAppealsCount";
            this.ProblemAppealsCount.Size = new System.Drawing.Size(0, 19);
            this.ProblemAppealsCount.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "Ответы потребителей на письма";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(724, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 96;
            // 
            // AddAnswer
            // 
            this.AddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAnswer.BackColor = System.Drawing.Color.Transparent;
            this.AddAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAnswer.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddAnswer.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddAnswer.IconColor = System.Drawing.Color.OrangeRed;
            this.AddAnswer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddAnswer.IconSize = 30;
            this.AddAnswer.Location = new System.Drawing.Point(870, 186);
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(31, 30);
            this.AddAnswer.TabIndex = 98;
            this.AddAnswer.TabStop = false;
            this.AddAnswer.UseGdi = true;
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // RedAnswer
            // 
            this.RedAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RedAnswer.BackColor = System.Drawing.Color.Transparent;
            this.RedAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedAnswer.ForeColor = System.Drawing.Color.OrangeRed;
            this.RedAnswer.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.RedAnswer.IconColor = System.Drawing.Color.OrangeRed;
            this.RedAnswer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RedAnswer.IconSize = 30;
            this.RedAnswer.Location = new System.Drawing.Point(907, 186);
            this.RedAnswer.Name = "RedAnswer";
            this.RedAnswer.Size = new System.Drawing.Size(31, 30);
            this.RedAnswer.TabIndex = 99;
            this.RedAnswer.TabStop = false;
            this.RedAnswer.UseGdi = true;
            this.RedAnswer.Click += new System.EventHandler(this.RedAnswer_Click);
            // 
            // DelAnswer
            // 
            this.DelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.DelAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelAnswer.ForeColor = System.Drawing.Color.OrangeRed;
            this.DelAnswer.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.DelAnswer.IconColor = System.Drawing.Color.OrangeRed;
            this.DelAnswer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DelAnswer.IconSize = 30;
            this.DelAnswer.Location = new System.Drawing.Point(944, 186);
            this.DelAnswer.Name = "DelAnswer";
            this.DelAnswer.Size = new System.Drawing.Size(31, 30);
            this.DelAnswer.TabIndex = 100;
            this.DelAnswer.TabStop = false;
            this.DelAnswer.UseGdi = true;
            this.DelAnswer.Click += new System.EventHandler(this.DelAnswer_Click);
            // 
            // Addleters
            // 
            this.Addleters.BackColor = System.Drawing.Color.White;
            this.Addleters.BackgroundColor = System.Drawing.Color.White;
            this.Addleters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.Addleters.BorderRadius = 20;
            this.Addleters.BorderSize = 1;
            this.Addleters.FlatAppearance.BorderSize = 0;
            this.Addleters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addleters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addleters.ForeColor = System.Drawing.Color.Black;
            this.Addleters.Location = new System.Drawing.Point(12, 25);
            this.Addleters.Name = "Addleters";
            this.Addleters.Size = new System.Drawing.Size(137, 38);
            this.Addleters.TabIndex = 73;
            this.Addleters.Text = "Написать письмо";
            this.Addleters.TextColor = System.Drawing.Color.Black;
            this.Addleters.UseVisualStyleBackColor = false;
            this.Addleters.Click += new System.EventHandler(this.Addleters_Click);
            // 
            // userControlButton6
            // 
            this.userControlButton6.BackColor = System.Drawing.Color.White;
            this.userControlButton6.BackgroundColor = System.Drawing.Color.White;
            this.userControlButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.userControlButton6.BorderRadius = 20;
            this.userControlButton6.BorderSize = 1;
            this.userControlButton6.FlatAppearance.BorderSize = 0;
            this.userControlButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userControlButton6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlButton6.ForeColor = System.Drawing.Color.Black;
            this.userControlButton6.Location = new System.Drawing.Point(326, 25);
            this.userControlButton6.Name = "userControlButton6";
            this.userControlButton6.Size = new System.Drawing.Size(146, 38);
            this.userControlButton6.TabIndex = 72;
            this.userControlButton6.Text = "Удалить письмо";
            this.userControlButton6.TextColor = System.Drawing.Color.Black;
            this.userControlButton6.UseVisualStyleBackColor = false;
            this.userControlButton6.Click += new System.EventHandler(this.userControlButton6_Click);
            // 
            // RedLetters
            // 
            this.RedLetters.BackColor = System.Drawing.Color.White;
            this.RedLetters.BackgroundColor = System.Drawing.Color.White;
            this.RedLetters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.RedLetters.BorderRadius = 20;
            this.RedLetters.BorderSize = 1;
            this.RedLetters.FlatAppearance.BorderSize = 0;
            this.RedLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedLetters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLetters.ForeColor = System.Drawing.Color.Black;
            this.RedLetters.Location = new System.Drawing.Point(155, 25);
            this.RedLetters.Name = "RedLetters";
            this.RedLetters.Size = new System.Drawing.Size(165, 38);
            this.RedLetters.TabIndex = 71;
            this.RedLetters.Text = "Редкатировать письмо";
            this.RedLetters.TextColor = System.Drawing.Color.Black;
            this.RedLetters.UseVisualStyleBackColor = false;
            this.RedLetters.Click += new System.EventHandler(this.RedLetters_Click);
            // 
            // LettersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(987, 717);
            this.Controls.Add(this.DelAnswer);
            this.Controls.Add(this.RedAnswer);
            this.Controls.Add(this.AddAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProblemAppealsCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchRecords);
            this.Controls.Add(this.Addleters);
            this.Controls.Add(this.userControlButton6);
            this.Controls.Add(this.RedLetters);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SelectOtvet);
            this.Controls.Add(this.SelectLetters);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LettersForm";
            this.Text = "LettersForm";
            this.Load += new System.EventHandler(this.LettersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectOtvet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLetters)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SelectOtvet;
        //private WindowsFormsApp2.UserControlTextBox userControlTextBox1;
        //private WindowsFormsApp2.UserControlButton userControlButton6;
        //private WindowsFormsApp2.UserControlButton userControlButton5;
        private System.Windows.Forms.DataGridView SelectLetters;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerPo;
        private System.Windows.Forms.DateTimePicker dateTimePickerS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WindowsFormsApp2.UserControlButton ItsRange;
        private WindowsFormsApp2.UserControlButton Today;
        private WindowsFormsApp2.UserControlButton Last7days;
        private WindowsFormsApp2.UserControlButton Last30days;
        private WindowsFormsApp2.UserControlButton userControlButton6;
        private WindowsFormsApp2.UserControlButton RedLetters;
        private WindowsFormsApp2.UserControlButton Addleters;
        private WindowsFormsApp2.UserControlButton userControlButton2;
        private System.Windows.Forms.Label label11;
        private UserControlToggleButton MyAppeasl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchRecords;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ProblemAppealsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private FontAwesome.Sharp.IconPictureBox AddAnswer;
        private FontAwesome.Sharp.IconPictureBox RedAnswer;
        private FontAwesome.Sharp.IconPictureBox DelAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}