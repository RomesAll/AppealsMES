
namespace Appeals_Mes
{
    partial class SolvingProblemFormAddRed
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.MyAppeaslAdd = new Appeals_Mes.UserControlToggleButton();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.NomerAppealsTx = new WindowsFormsApp2.UserControlTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DescriptionTx = new WindowsFormsApp2.UserControlTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DateOtvet = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.AddGuidStatus = new FontAwesome.Sharp.IconPictureBox();
            this.StatusCm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectProblemDg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectProblemDg)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(839, 277);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 67;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(1, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 2);
            this.panel4.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "Мои записи";
            // 
            // MyAppeaslAdd
            // 
            this.MyAppeaslAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyAppeaslAdd.Checked = true;
            this.MyAppeaslAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MyAppeaslAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyAppeaslAdd.Location = new System.Drawing.Point(114, 282);
            this.MyAppeaslAdd.MinimumSize = new System.Drawing.Size(45, 22);
            this.MyAppeaslAdd.Name = "MyAppeaslAdd";
            this.MyAppeaslAdd.OffBackColor = System.Drawing.Color.Gray;
            this.MyAppeaslAdd.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.MyAppeaslAdd.OnBackColor = System.Drawing.Color.OrangeRed;
            this.MyAppeaslAdd.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.MyAppeaslAdd.Size = new System.Drawing.Size(47, 22);
            this.MyAppeaslAdd.TabIndex = 63;
            this.MyAppeaslAdd.UseVisualStyleBackColor = true;
            this.MyAppeaslAdd.CheckedChanged += new System.EventHandler(this.MyAppeaslAdd_CheckedChanged);
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
            this.AddBtn.Location = new System.Drawing.Point(32, 202);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(231, 65);
            this.AddBtn.TabIndex = 68;
            this.AddBtn.Text = "Добавить запись";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.NomerAppealsTx.Location = new System.Drawing.Point(214, 2);
            this.NomerAppealsTx.Margin = new System.Windows.Forms.Padding(4);
            this.NomerAppealsTx.Multiline = false;
            this.NomerAppealsTx.Name = "NomerAppealsTx";
            this.NomerAppealsTx.Padding = new System.Windows.Forms.Padding(7);
            this.NomerAppealsTx.PasswordChar = false;
            this.NomerAppealsTx.Size = new System.Drawing.Size(62, 35);
            this.NomerAppealsTx.TabIndex = 70;
            this.NomerAppealsTx.Texts = "";
            this.NomerAppealsTx.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Номер проблемы обращения";
            // 
            // DescriptionTx
            // 
            this.DescriptionTx.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.DescriptionTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.DescriptionTx.BorderSize = 2;
            this.DescriptionTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTx.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTx.Location = new System.Drawing.Point(323, 30);
            this.DescriptionTx.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTx.Multiline = true;
            this.DescriptionTx.Name = "DescriptionTx";
            this.DescriptionTx.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionTx.PasswordChar = false;
            this.DescriptionTx.Size = new System.Drawing.Size(547, 237);
            this.DescriptionTx.TabIndex = 72;
            this.DescriptionTx.Texts = "";
            this.DescriptionTx.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Описание";
            // 
            // DateOtvet
            // 
            this.DateOtvet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOtvet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOtvet.Location = new System.Drawing.Point(32, 94);
            this.DateOtvet.Name = "DateOtvet";
            this.DateOtvet.Size = new System.Drawing.Size(231, 25);
            this.DateOtvet.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Дата решения проблемы";
            // 
            // AddGuidStatus
            // 
            this.AddGuidStatus.BackColor = System.Drawing.Color.Transparent;
            this.AddGuidStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGuidStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddGuidStatus.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddGuidStatus.IconColor = System.Drawing.Color.OrangeRed;
            this.AddGuidStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddGuidStatus.IconSize = 22;
            this.AddGuidStatus.Location = new System.Drawing.Point(269, 145);
            this.AddGuidStatus.Name = "AddGuidStatus";
            this.AddGuidStatus.Size = new System.Drawing.Size(22, 25);
            this.AddGuidStatus.TabIndex = 78;
            this.AddGuidStatus.TabStop = false;
            this.AddGuidStatus.UseGdi = true;
            this.AddGuidStatus.Click += new System.EventHandler(this.AddGuidStatus_Click);
            // 
            // StatusCm
            // 
            this.StatusCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCm.FormattingEnabled = true;
            this.StatusCm.Location = new System.Drawing.Point(32, 145);
            this.StatusCm.Name = "StatusCm";
            this.StatusCm.Size = new System.Drawing.Size(231, 25);
            this.StatusCm.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Статус";
            // 
            // SelectProblemDg
            // 
            this.SelectProblemDg.AllowUserToAddRows = false;
            this.SelectProblemDg.AllowUserToDeleteRows = false;
            this.SelectProblemDg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectProblemDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectProblemDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SelectProblemDg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectProblemDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectProblemDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column10,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectProblemDg.DefaultCellStyle = dataGridViewCellStyle1;
            this.SelectProblemDg.Location = new System.Drawing.Point(1, 310);
            this.SelectProblemDg.Name = "SelectProblemDg";
            this.SelectProblemDg.ReadOnly = true;
            this.SelectProblemDg.RowTemplate.Height = 35;
            this.SelectProblemDg.Size = new System.Drawing.Size(879, 508);
            this.SelectProblemDg.TabIndex = 79;
            this.SelectProblemDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectProblemDg_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_problem_appeals";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер проблемы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date_delayed_response";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата запланированного ответа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type_appeal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип обращения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Description";
            this.Column10.HeaderText = "Описание";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "statuses";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "priorities";
            this.dataGridViewTextBoxColumn5.HeaderText = "Приоритет";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn7.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SolvingCh";
            this.Column9.HeaderText = "Кол-во решений";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // SolvingProblemFormAddRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(883, 818);
            this.Controls.Add(this.SelectProblemDg);
            this.Controls.Add(this.AddGuidStatus);
            this.Controls.Add(this.StatusCm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateOtvet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NomerAppealsTx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MyAppeaslAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SolvingProblemFormAddRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolvingProblemForm";
            this.Load += new System.EventHandler(this.SolvingProblemFormAddRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectProblemDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private UserControlToggleButton MyAppeaslAdd;
        private WindowsFormsApp2.UserControlButton AddBtn;
        private WindowsFormsApp2.UserControlTextBox NomerAppealsTx;
        private System.Windows.Forms.Label label7;
        private WindowsFormsApp2.UserControlTextBox DescriptionTx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateOtvet;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox AddGuidStatus;
        private System.Windows.Forms.ComboBox StatusCm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView SelectProblemDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;

        #endregion
        // private WindowsFormsApp2.UserControlButton userControlButton1;
    }
}