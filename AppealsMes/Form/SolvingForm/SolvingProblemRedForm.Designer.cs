
namespace AppealsMes
{
    partial class SolvingProblemRedForm
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
            this.AddGuidStatus = new FontAwesome.Sharp.IconPictureBox();
            this.StatusCm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateOtvet = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTx = new WindowsFormsApp2.UserControlTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NomerAppealsTx = new WindowsFormsApp2.UserControlTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.userControlTextBox1 = new WindowsFormsApp2.UserControlTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidStatus)).BeginInit();
            this.SuspendLayout();
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
            this.AddGuidStatus.Location = new System.Drawing.Point(267, 151);
            this.AddGuidStatus.Name = "AddGuidStatus";
            this.AddGuidStatus.Size = new System.Drawing.Size(22, 25);
            this.AddGuidStatus.TabIndex = 88;
            this.AddGuidStatus.TabStop = false;
            this.AddGuidStatus.UseGdi = true;
            this.AddGuidStatus.Click += new System.EventHandler(this.AddGuidStatus_Click);
            // 
            // StatusCm
            // 
            this.StatusCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCm.FormattingEnabled = true;
            this.StatusCm.Location = new System.Drawing.Point(30, 151);
            this.StatusCm.Name = "StatusCm";
            this.StatusCm.Size = new System.Drawing.Size(231, 25);
            this.StatusCm.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Статус";
            // 
            // DateOtvet
            // 
            this.DateOtvet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOtvet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOtvet.Location = new System.Drawing.Point(30, 100);
            this.DateOtvet.Name = "DateOtvet";
            this.DateOtvet.Size = new System.Drawing.Size(231, 25);
            this.DateOtvet.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Дата решения проблемы";
            // 
            // DescriptionTx
            // 
            this.DescriptionTx.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.DescriptionTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.DescriptionTx.BorderSize = 2;
            this.DescriptionTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTx.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTx.Location = new System.Drawing.Point(319, 100);
            this.DescriptionTx.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTx.Multiline = true;
            this.DescriptionTx.Name = "DescriptionTx";
            this.DescriptionTx.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionTx.PasswordChar = false;
            this.DescriptionTx.Size = new System.Drawing.Size(530, 173);
            this.DescriptionTx.TabIndex = 82;
            this.DescriptionTx.Texts = "";
            this.DescriptionTx.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(316, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "Описание";
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
            this.NomerAppealsTx.Location = new System.Drawing.Point(212, 8);
            this.NomerAppealsTx.Margin = new System.Windows.Forms.Padding(4);
            this.NomerAppealsTx.Multiline = false;
            this.NomerAppealsTx.Name = "NomerAppealsTx";
            this.NomerAppealsTx.Padding = new System.Windows.Forms.Padding(7);
            this.NomerAppealsTx.PasswordChar = false;
            this.NomerAppealsTx.Size = new System.Drawing.Size(62, 35);
            this.NomerAppealsTx.TabIndex = 81;
            this.NomerAppealsTx.Texts = "";
            this.NomerAppealsTx.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 17);
            this.label7.TabIndex = 80;
            this.label7.Text = "Номер проблемы обращения";
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
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(30, 208);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(231, 65);
            this.AddBtn.TabIndex = 79;
            this.AddBtn.Text = "Редактировать запись";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // userControlTextBox1
            // 
            this.userControlTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControlTextBox1.BorderColor = System.Drawing.Color.OrangeRed;
            this.userControlTextBox1.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.userControlTextBox1.BorderSize = 2;
            this.userControlTextBox1.Enabled = false;
            this.userControlTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlTextBox1.ForeColor = System.Drawing.Color.Black;
            this.userControlTextBox1.Location = new System.Drawing.Point(471, 8);
            this.userControlTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlTextBox1.Multiline = false;
            this.userControlTextBox1.Name = "userControlTextBox1";
            this.userControlTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.userControlTextBox1.PasswordChar = false;
            this.userControlTextBox1.Size = new System.Drawing.Size(62, 35);
            this.userControlTextBox1.TabIndex = 90;
            this.userControlTextBox1.Texts = "";
            this.userControlTextBox1.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Номер решения проблемы";
            // 
            // SolvingProblemRedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 282);
            this.Controls.Add(this.userControlTextBox1);
            this.Controls.Add(this.label2);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SolvingProblemRedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolvingProblemRedForm";
            this.Load += new System.EventHandler(this.SolvingProblemRedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox AddGuidStatus;
        private System.Windows.Forms.ComboBox StatusCm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateOtvet;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp2.UserControlTextBox DescriptionTx;
        private System.Windows.Forms.Label label8;
        private WindowsFormsApp2.UserControlTextBox NomerAppealsTx;
        private System.Windows.Forms.Label label7;
        private WindowsFormsApp2.UserControlButton AddBtn;
        private WindowsFormsApp2.UserControlTextBox userControlTextBox1;
        private System.Windows.Forms.Label label2;
    }
}