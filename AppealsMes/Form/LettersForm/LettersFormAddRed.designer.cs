
namespace Appeals_Mes
{
    partial class LettersFormAddRed
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateOtvet = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmploer = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmploerCm = new System.Windows.Forms.ComboBox();
            this.SolvingProblem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.DescriptionTx = new WindowsFormsApp2.UserControlTextBox();
            this.NomerAppealsTx = new WindowsFormsApp2.UserControlTextBox();
            this.MyAppeaslAdd = new Appeals_Mes.UserControlToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolvingProblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(-1, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 2);
            this.panel1.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Мои записи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Номер решения проблемы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Описание";
            // 
            // DateOtvet
            // 
            this.DateOtvet.Enabled = false;
            this.DateOtvet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOtvet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOtvet.Location = new System.Drawing.Point(34, 89);
            this.DateOtvet.Name = "DateOtvet";
            this.DateOtvet.Size = new System.Drawing.Size(230, 25);
            this.DateOtvet.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Дата написания письма";
            // 
            // AddEmploer
            // 
            this.AddEmploer.BackColor = System.Drawing.Color.White;
            this.AddEmploer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmploer.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddEmploer.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddEmploer.IconColor = System.Drawing.Color.OrangeRed;
            this.AddEmploer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddEmploer.IconSize = 22;
            this.AddEmploer.Location = new System.Drawing.Point(269, 141);
            this.AddEmploer.Name = "AddEmploer";
            this.AddEmploer.Size = new System.Drawing.Size(22, 25);
            this.AddEmploer.TabIndex = 66;
            this.AddEmploer.TabStop = false;
            this.AddEmploer.UseGdi = true;
            this.AddEmploer.Click += new System.EventHandler(this.AddEmploer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Выберите сотрудника";
            // 
            // EmploerCm
            // 
            this.EmploerCm.Enabled = false;
            this.EmploerCm.FormattingEnabled = true;
            this.EmploerCm.Location = new System.Drawing.Point(34, 141);
            this.EmploerCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmploerCm.Name = "EmploerCm";
            this.EmploerCm.Size = new System.Drawing.Size(230, 25);
            this.EmploerCm.TabIndex = 64;
            // 
            // SolvingProblem
            // 
            this.SolvingProblem.AllowUserToAddRows = false;
            this.SolvingProblem.AllowUserToDeleteRows = false;
            this.SolvingProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolvingProblem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SolvingProblem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SolvingProblem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SolvingProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SolvingProblem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SolvingProblem.DefaultCellStyle = dataGridViewCellStyle1;
            this.SolvingProblem.Location = new System.Drawing.Point(-1, 382);
            this.SolvingProblem.Name = "SolvingProblem";
            this.SolvingProblem.ReadOnly = true;
            this.SolvingProblem.RowTemplate.Height = 35;
            this.SolvingProblem.Size = new System.Drawing.Size(857, 396);
            this.SolvingProblem.TabIndex = 90;
            this.SolvingProblem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SolvingProblem_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_solving_problem";
            this.Column1.HeaderText = "Номер решения проблемы";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id_problem_appeals";
            this.Column2.HeaderText = "Номер проблемы обращения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "Описание";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Data_solving_problem";
            this.Column4.HeaderText = "Дата решения проблемы";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "statuses";
            this.Column5.HeaderText = "Статус";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "LettersCh";
            this.Column6.HeaderText = "Кол-во исходящих писем";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(824, 349);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 91;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddBtn.BorderRadius = 20;
            this.AddBtn.BorderSize = 1;
            this.AddBtn.Enabled = false;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(34, 284);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(230, 55);
            this.AddBtn.TabIndex = 67;
            this.AddBtn.Text = "Добавить запись";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DescriptionTx
            // 
            this.DescriptionTx.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.DescriptionTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.DescriptionTx.BorderSize = 2;
            this.DescriptionTx.Enabled = false;
            this.DescriptionTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTx.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTx.Location = new System.Drawing.Point(298, 43);
            this.DescriptionTx.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTx.Multiline = true;
            this.DescriptionTx.Name = "DescriptionTx";
            this.DescriptionTx.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionTx.PasswordChar = false;
            this.DescriptionTx.Size = new System.Drawing.Size(558, 296);
            this.DescriptionTx.TabIndex = 60;
            this.DescriptionTx.Texts = "";
            this.DescriptionTx.UnderlinedStyle = false;
            // 
            // NomerAppealsTx
            // 
            this.NomerAppealsTx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NomerAppealsTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.NomerAppealsTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NomerAppealsTx.BorderSize = 2;
            this.NomerAppealsTx.Enabled = false;
            this.NomerAppealsTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NomerAppealsTx.ForeColor = System.Drawing.Color.Black;
            this.NomerAppealsTx.Location = new System.Drawing.Point(221, 13);
            this.NomerAppealsTx.Margin = new System.Windows.Forms.Padding(4);
            this.NomerAppealsTx.Multiline = false;
            this.NomerAppealsTx.Name = "NomerAppealsTx";
            this.NomerAppealsTx.Padding = new System.Windows.Forms.Padding(7);
            this.NomerAppealsTx.PasswordChar = false;
            this.NomerAppealsTx.Size = new System.Drawing.Size(62, 35);
            this.NomerAppealsTx.TabIndex = 59;
            this.NomerAppealsTx.Texts = "";
            this.NomerAppealsTx.UnderlinedStyle = true;
            // 
            // MyAppeaslAdd
            // 
            this.MyAppeaslAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyAppeaslAdd.Checked = true;
            this.MyAppeaslAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MyAppeaslAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyAppeaslAdd.Location = new System.Drawing.Point(99, 354);
            this.MyAppeaslAdd.MinimumSize = new System.Drawing.Size(45, 22);
            this.MyAppeaslAdd.Name = "MyAppeaslAdd";
            this.MyAppeaslAdd.OffBackColor = System.Drawing.Color.Gray;
            this.MyAppeaslAdd.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.MyAppeaslAdd.OnBackColor = System.Drawing.Color.OrangeRed;
            this.MyAppeaslAdd.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.MyAppeaslAdd.Size = new System.Drawing.Size(47, 22);
            this.MyAppeaslAdd.TabIndex = 56;
            this.MyAppeaslAdd.UseVisualStyleBackColor = true;
            this.MyAppeaslAdd.CheckedChanged += new System.EventHandler(this.MyAppeaslAdd_CheckedChanged);
            // 
            // LettersFormAddRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(857, 779);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.SolvingProblem);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddEmploer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmploerCm);
            this.Controls.Add(this.DateOtvet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionTx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NomerAppealsTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyAppeaslAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LettersFormAddRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LettersFormAddRed";
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolvingProblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private UserControlToggleButton MyAppeaslAdd;
        private WindowsFormsApp2.UserControlTextBox NomerAppealsTx;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp2.UserControlTextBox DescriptionTx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateOtvet;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox AddEmploer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmploerCm;
        private WindowsFormsApp2.UserControlButton AddBtn;
        private System.Windows.Forms.DataGridView SolvingProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;

        #endregion

        //private WindowsFormsApp2.UserControlTextBox userControlTextBox1;
    }
}