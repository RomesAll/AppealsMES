
namespace Appeals_Mes
{
    partial class AppealsFormAddRed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppealsFormAddRed));
            this.label6 = new System.Windows.Forms.Label();
            this.StatusCm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.EmploerCm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KlientCm = new System.Windows.Forms.ComboBox();
            this.AddKlient = new FontAwesome.Sharp.IconPictureBox();
            this.AddEmploer = new FontAwesome.Sharp.IconPictureBox();
            this.AddStatus = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoteTx = new WindowsFormsApp2.UserControlTextBox();
            this.DateTx = new WindowsFormsApp2.UserControlTextBox();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.AddMethodAppeals = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MethodCm = new System.Windows.Forms.ComboBox();
            this.AppealsDgAdd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.MyAppeaslAdd = new Appeals_Mes.UserControlToggleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AddKlient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMethodAppeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppealsDgAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(80, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Статус";
            // 
            // StatusCm
            // 
            this.StatusCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCm.Enabled = false;
            this.StatusCm.FormattingEnabled = true;
            this.StatusCm.Location = new System.Drawing.Point(82, 147);
            this.StatusCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusCm.Name = "StatusCm";
            this.StatusCm.Size = new System.Drawing.Size(313, 25);
            this.StatusCm.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(438, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата обращения";
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Location = new System.Drawing.Point(441, 46);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 19;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Выберите сотрудника";
            // 
            // EmploerCm
            // 
            this.EmploerCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmploerCm.FormattingEnabled = true;
            this.EmploerCm.Location = new System.Drawing.Point(83, 97);
            this.EmploerCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmploerCm.Name = "EmploerCm";
            this.EmploerCm.Size = new System.Drawing.Size(313, 25);
            this.EmploerCm.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберите клиента";
            // 
            // KlientCm
            // 
            this.KlientCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlientCm.FormattingEnabled = true;
            this.KlientCm.Location = new System.Drawing.Point(83, 46);
            this.KlientCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KlientCm.Name = "KlientCm";
            this.KlientCm.Size = new System.Drawing.Size(313, 25);
            this.KlientCm.TabIndex = 14;
            // 
            // AddKlient
            // 
            this.AddKlient.BackColor = System.Drawing.SystemColors.Control;
            this.AddKlient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddKlient.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddKlient.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddKlient.IconColor = System.Drawing.Color.OrangeRed;
            this.AddKlient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddKlient.IconSize = 22;
            this.AddKlient.Location = new System.Drawing.Point(401, 46);
            this.AddKlient.Name = "AddKlient";
            this.AddKlient.Size = new System.Drawing.Size(22, 25);
            this.AddKlient.TabIndex = 28;
            this.AddKlient.TabStop = false;
            this.AddKlient.UseGdi = true;
            this.AddKlient.Click += new System.EventHandler(this.AddKlient_Click);
            // 
            // AddEmploer
            // 
            this.AddEmploer.BackColor = System.Drawing.SystemColors.Control;
            this.AddEmploer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmploer.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddEmploer.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddEmploer.IconColor = System.Drawing.Color.OrangeRed;
            this.AddEmploer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddEmploer.IconSize = 22;
            this.AddEmploer.Location = new System.Drawing.Point(401, 97);
            this.AddEmploer.Name = "AddEmploer";
            this.AddEmploer.Size = new System.Drawing.Size(22, 25);
            this.AddEmploer.TabIndex = 29;
            this.AddEmploer.TabStop = false;
            this.AddEmploer.UseGdi = true;
            this.AddEmploer.Click += new System.EventHandler(this.AddEmploer_Click);
            // 
            // AddStatus
            // 
            this.AddStatus.BackColor = System.Drawing.SystemColors.Control;
            this.AddStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddStatus.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddStatus.IconColor = System.Drawing.Color.OrangeRed;
            this.AddStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddStatus.IconSize = 22;
            this.AddStatus.Location = new System.Drawing.Point(401, 147);
            this.AddStatus.Name = "AddStatus";
            this.AddStatus.Size = new System.Drawing.Size(22, 25);
            this.AddStatus.TabIndex = 31;
            this.AddStatus.TabStop = false;
            this.AddStatus.UseGdi = true;
            this.AddStatus.Click += new System.EventHandler(this.AddStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(438, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Примечание";
            // 
            // NoteTx
            // 
            this.NoteTx.BackColor = System.Drawing.SystemColors.Window;
            this.NoteTx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NoteTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NoteTx.BorderSize = 2;
            this.NoteTx.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTx.ForeColor = System.Drawing.Color.DimGray;
            this.NoteTx.Location = new System.Drawing.Point(441, 236);
            this.NoteTx.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTx.Multiline = true;
            this.NoteTx.Name = "NoteTx";
            this.NoteTx.Padding = new System.Windows.Forms.Padding(7);
            this.NoteTx.PasswordChar = false;
            this.NoteTx.Size = new System.Drawing.Size(332, 92);
            this.NoteTx.TabIndex = 32;
            this.NoteTx.Texts = "";
            this.NoteTx.UnderlinedStyle = false;
            // 
            // DateTx
            // 
            this.DateTx.BackColor = System.Drawing.SystemColors.Control;
            this.DateTx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DateTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.DateTx.BorderSize = 2;
            this.DateTx.Enabled = false;
            this.DateTx.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTx.ForeColor = System.Drawing.Color.Black;
            this.DateTx.Location = new System.Drawing.Point(555, 10);
            this.DateTx.Margin = new System.Windows.Forms.Padding(4);
            this.DateTx.Multiline = false;
            this.DateTx.Name = "DateTx";
            this.DateTx.Padding = new System.Windows.Forms.Padding(7);
            this.DateTx.PasswordChar = false;
            this.DateTx.Size = new System.Drawing.Size(95, 32);
            this.DateTx.TabIndex = 27;
            this.DateTx.Texts = "";
            this.DateTx.UnderlinedStyle = true;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddBtn.BorderRadius = 20;
            this.AddBtn.BorderSize = 1;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(84, 251);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(313, 59);
            this.AddBtn.TabIndex = 26;
            this.AddBtn.Text = "Добавить обращение";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddMethodAppeals
            // 
            this.AddMethodAppeals.BackColor = System.Drawing.SystemColors.Control;
            this.AddMethodAppeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMethodAppeals.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddMethodAppeals.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddMethodAppeals.IconColor = System.Drawing.Color.OrangeRed;
            this.AddMethodAppeals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddMethodAppeals.IconSize = 22;
            this.AddMethodAppeals.Location = new System.Drawing.Point(401, 198);
            this.AddMethodAppeals.Name = "AddMethodAppeals";
            this.AddMethodAppeals.Size = new System.Drawing.Size(22, 25);
            this.AddMethodAppeals.TabIndex = 36;
            this.AddMethodAppeals.TabStop = false;
            this.AddMethodAppeals.UseGdi = true;
            this.AddMethodAppeals.Click += new System.EventHandler(this.AddMethodAppeals_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(81, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Способ обращений";
            // 
            // MethodCm
            // 
            this.MethodCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodCm.FormattingEnabled = true;
            this.MethodCm.Location = new System.Drawing.Point(84, 198);
            this.MethodCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MethodCm.Name = "MethodCm";
            this.MethodCm.Size = new System.Drawing.Size(313, 25);
            this.MethodCm.TabIndex = 34;
            // 
            // AppealsDgAdd
            // 
            this.AppealsDgAdd.AllowUserToAddRows = false;
            this.AppealsDgAdd.AllowUserToDeleteRows = false;
            this.AppealsDgAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppealsDgAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppealsDgAdd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AppealsDgAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AppealsDgAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppealsDgAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppealsDgAdd.DefaultCellStyle = dataGridViewCellStyle1;
            this.AppealsDgAdd.Location = new System.Drawing.Point(0, 381);
            this.AppealsDgAdd.Name = "AppealsDgAdd";
            this.AppealsDgAdd.ReadOnly = true;
            this.AppealsDgAdd.Size = new System.Drawing.Size(857, 398);
            this.AppealsDgAdd.TabIndex = 37;
            this.AppealsDgAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppealsDgAdd_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_appeals";
            this.Column1.HeaderText = "Номер обращения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Fioe";
            this.Column2.HeaderText = "Фио сотрудника";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Fioc";
            this.Column3.HeaderText = "Фио клиента";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "method_treatmentcol";
            this.Column4.HeaderText = "Способ обращения";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Date_appeals";
            this.Column6.HeaderText = "Дата обращения";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "statuses";
            this.Column5.HeaderText = "Статус";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Note";
            this.Column7.HeaderText = "Примечание";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Problem_appealsCh";
            this.Column8.HeaderText = "Кол-во проблем";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Мои записи";
            // 
            // MyAppeaslAdd
            // 
            this.MyAppeaslAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyAppeaslAdd.Checked = true;
            this.MyAppeaslAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MyAppeaslAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyAppeaslAdd.Location = new System.Drawing.Point(100, 353);
            this.MyAppeaslAdd.MinimumSize = new System.Drawing.Size(45, 22);
            this.MyAppeaslAdd.Name = "MyAppeaslAdd";
            this.MyAppeaslAdd.OffBackColor = System.Drawing.Color.Gray;
            this.MyAppeaslAdd.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.MyAppeaslAdd.OnBackColor = System.Drawing.Color.OrangeRed;
            this.MyAppeaslAdd.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.MyAppeaslAdd.Size = new System.Drawing.Size(47, 22);
            this.MyAppeaslAdd.TabIndex = 50;
            this.MyAppeaslAdd.UseVisualStyleBackColor = true;
            this.MyAppeaslAdd.CheckedChanged += new System.EventHandler(this.MyAppeasl_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 2);
            this.panel1.TabIndex = 52;
            // 
            // AppealsFormAddRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MyAppeaslAdd);
            this.Controls.Add(this.AppealsDgAdd);
            this.Controls.Add(this.AddMethodAppeals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MethodCm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteTx);
            this.Controls.Add(this.AddStatus);
            this.Controls.Add(this.AddEmploer);
            this.Controls.Add(this.AddKlient);
            this.Controls.Add(this.DateTx);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StatusCm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmploerCm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KlientCm);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AppealsFormAddRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр обращения";
            ((System.ComponentModel.ISupportInitialize)(this.AddKlient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMethodAppeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppealsDgAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp2.UserControlButton AddBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StatusCm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmploerCm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KlientCm;
        private WindowsFormsApp2.UserControlTextBox DateTx;
        private FontAwesome.Sharp.IconPictureBox AddKlient;
        private FontAwesome.Sharp.IconPictureBox AddEmploer;
        private FontAwesome.Sharp.IconPictureBox AddStatus;
        private WindowsFormsApp2.UserControlTextBox NoteTx;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox AddMethodAppeals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MethodCm;
        private System.Windows.Forms.DataGridView AppealsDgAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label7;
        private UserControlToggleButton MyAppeaslAdd;
        private System.Windows.Forms.Panel panel1;
    }
}