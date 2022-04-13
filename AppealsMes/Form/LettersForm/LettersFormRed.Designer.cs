
namespace AppealsMes
{
    partial class LettersFormRed
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
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.AddEmploer = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmploerCm = new System.Windows.Forms.ComboBox();
            this.DateOtvet = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTx = new WindowsFormsApp2.UserControlTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NomerAppealsTx = new WindowsFormsApp2.UserControlTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userControlTextBox1 = new WindowsFormsApp2.UserControlTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).BeginInit();
            this.SuspendLayout();
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
            this.AddBtn.Location = new System.Drawing.Point(15, 285);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(268, 72);
            this.AddBtn.TabIndex = 77;
            this.AddBtn.Text = "Редактировать запись";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddEmploer
            // 
            this.AddEmploer.BackColor = System.Drawing.Color.White;
            this.AddEmploer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmploer.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddEmploer.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddEmploer.IconColor = System.Drawing.Color.OrangeRed;
            this.AddEmploer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddEmploer.IconSize = 25;
            this.AddEmploer.Location = new System.Drawing.Point(276, 130);
            this.AddEmploer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmploer.Name = "AddEmploer";
            this.AddEmploer.Size = new System.Drawing.Size(26, 25);
            this.AddEmploer.TabIndex = 76;
            this.AddEmploer.TabStop = false;
            this.AddEmploer.UseGdi = true;
            this.AddEmploer.Click += new System.EventHandler(this.AddEmploer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Выберите сотрудника";
            // 
            // EmploerCm
            // 
            this.EmploerCm.FormattingEnabled = true;
            this.EmploerCm.Location = new System.Drawing.Point(11, 130);
            this.EmploerCm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EmploerCm.Name = "EmploerCm";
            this.EmploerCm.Size = new System.Drawing.Size(259, 25);
            this.EmploerCm.TabIndex = 74;
            // 
            // DateOtvet
            // 
            this.DateOtvet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOtvet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOtvet.Location = new System.Drawing.Point(14, 76);
            this.DateOtvet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateOtvet.Name = "DateOtvet";
            this.DateOtvet.Size = new System.Drawing.Size(259, 25);
            this.DateOtvet.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Дата написания письма";
            // 
            // DescriptionTx
            // 
            this.DescriptionTx.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.DescriptionTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.DescriptionTx.BorderSize = 2;
            this.DescriptionTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTx.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTx.Location = new System.Drawing.Point(310, 76);
            this.DescriptionTx.Margin = new System.Windows.Forms.Padding(5);
            this.DescriptionTx.Multiline = true;
            this.DescriptionTx.Name = "DescriptionTx";
            this.DescriptionTx.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DescriptionTx.PasswordChar = false;
            this.DescriptionTx.Size = new System.Drawing.Size(521, 281);
            this.DescriptionTx.TabIndex = 70;
            this.DescriptionTx.Texts = "";
            this.DescriptionTx.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 71;
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
            this.NomerAppealsTx.Location = new System.Drawing.Point(201, 4);
            this.NomerAppealsTx.Margin = new System.Windows.Forms.Padding(5);
            this.NomerAppealsTx.Multiline = false;
            this.NomerAppealsTx.Name = "NomerAppealsTx";
            this.NomerAppealsTx.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.NomerAppealsTx.PasswordChar = false;
            this.NomerAppealsTx.Size = new System.Drawing.Size(72, 39);
            this.NomerAppealsTx.TabIndex = 69;
            this.NomerAppealsTx.Texts = "";
            this.NomerAppealsTx.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Номер решения проблемы";
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
            this.userControlTextBox1.Location = new System.Drawing.Point(394, 4);
            this.userControlTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlTextBox1.Multiline = false;
            this.userControlTextBox1.Name = "userControlTextBox1";
            this.userControlTextBox1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.userControlTextBox1.PasswordChar = false;
            this.userControlTextBox1.Size = new System.Drawing.Size(72, 39);
            this.userControlTextBox1.TabIndex = 79;
            this.userControlTextBox1.Texts = "";
            this.userControlTextBox1.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "Номер письма";
            // 
            // LettersFormRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 361);
            this.Controls.Add(this.userControlTextBox1);
            this.Controls.Add(this.label4);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LettersFormRed";
            this.Text = "Редактировать письмо";
            this.Load += new System.EventHandler(this.LettersFormRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp2.UserControlButton AddBtn;
        private FontAwesome.Sharp.IconPictureBox AddEmploer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmploerCm;
        private System.Windows.Forms.DateTimePicker DateOtvet;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp2.UserControlTextBox DescriptionTx;
        private System.Windows.Forms.Label label8;
        private WindowsFormsApp2.UserControlTextBox NomerAppealsTx;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp2.UserControlTextBox userControlTextBox1;
        private System.Windows.Forms.Label label4;
    }
}