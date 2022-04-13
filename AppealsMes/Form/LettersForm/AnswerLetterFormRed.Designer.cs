
namespace AppealsMes
{
    partial class AnswerLetterFormRed
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
            this.DateOtvet = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.AddStatus = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusCm = new System.Windows.Forms.ComboBox();
            this.DescriptionTx = new WindowsFormsApp2.UserControlTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NomerLetters = new WindowsFormsApp2.UserControlTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NomerAppealsTx = new WindowsFormsApp2.UserControlTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.AddEmploer = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmploerCm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).BeginInit();
            this.SuspendLayout();
            // 
            // DateOtvet
            // 
            this.DateOtvet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOtvet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOtvet.Location = new System.Drawing.Point(267, 78);
            this.DateOtvet.Name = "DateOtvet";
            this.DateOtvet.Size = new System.Drawing.Size(240, 25);
            this.DateOtvet.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "Дата ответа";
            // 
            // AddStatus
            // 
            this.AddStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStatus.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddStatus.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddStatus.IconColor = System.Drawing.Color.OrangeRed;
            this.AddStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddStatus.IconSize = 22;
            this.AddStatus.Location = new System.Drawing.Point(229, 78);
            this.AddStatus.Name = "AddStatus";
            this.AddStatus.Size = new System.Drawing.Size(22, 25);
            this.AddStatus.TabIndex = 100;
            this.AddStatus.TabStop = false;
            this.AddStatus.UseGdi = true;
            this.AddStatus.Click += new System.EventHandler(this.AddStatus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Статус";
            // 
            // StatusCm
            // 
            this.StatusCm.FormattingEnabled = true;
            this.StatusCm.Location = new System.Drawing.Point(13, 78);
            this.StatusCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusCm.Name = "StatusCm";
            this.StatusCm.Size = new System.Drawing.Size(210, 21);
            this.StatusCm.TabIndex = 98;
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
            this.DescriptionTx.Location = new System.Drawing.Point(13, 185);
            this.DescriptionTx.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTx.Multiline = true;
            this.DescriptionTx.Name = "DescriptionTx";
            this.DescriptionTx.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionTx.PasswordChar = false;
            this.DescriptionTx.Size = new System.Drawing.Size(494, 97);
            this.DescriptionTx.TabIndex = 96;
            this.DescriptionTx.Texts = "";
            this.DescriptionTx.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 97;
            this.label8.Text = "Описание";
            // 
            // NomerLetters
            // 
            this.NomerLetters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NomerLetters.BorderColor = System.Drawing.Color.OrangeRed;
            this.NomerLetters.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NomerLetters.BorderSize = 2;
            this.NomerLetters.Enabled = false;
            this.NomerLetters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NomerLetters.ForeColor = System.Drawing.Color.Black;
            this.NomerLetters.Location = new System.Drawing.Point(395, 5);
            this.NomerLetters.Margin = new System.Windows.Forms.Padding(5);
            this.NomerLetters.Multiline = false;
            this.NomerLetters.Name = "NomerLetters";
            this.NomerLetters.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.NomerLetters.PasswordChar = false;
            this.NomerLetters.Size = new System.Drawing.Size(72, 39);
            this.NomerLetters.TabIndex = 95;
            this.NomerLetters.Texts = "";
            this.NomerLetters.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 94;
            this.label4.Text = "Номер письма";
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
            this.NomerAppealsTx.Location = new System.Drawing.Point(197, 5);
            this.NomerAppealsTx.Margin = new System.Windows.Forms.Padding(5);
            this.NomerAppealsTx.Multiline = false;
            this.NomerAppealsTx.Name = "NomerAppealsTx";
            this.NomerAppealsTx.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.NomerAppealsTx.PasswordChar = false;
            this.NomerAppealsTx.Size = new System.Drawing.Size(72, 39);
            this.NomerAppealsTx.TabIndex = 93;
            this.NomerAppealsTx.Texts = "";
            this.NomerAppealsTx.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Номер ответа потребителя";
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
            this.AddBtn.Location = new System.Drawing.Point(141, 289);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(230, 55);
            this.AddBtn.TabIndex = 91;
            this.AddBtn.Text = "Редактировать запись";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
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
            this.AddEmploer.Location = new System.Drawing.Point(229, 123);
            this.AddEmploer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmploer.Name = "AddEmploer";
            this.AddEmploer.Size = new System.Drawing.Size(22, 25);
            this.AddEmploer.TabIndex = 105;
            this.AddEmploer.TabStop = false;
            this.AddEmploer.UseGdi = true;
            this.AddEmploer.Click += new System.EventHandler(this.AddEmploer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Выберите сотрудника";
            // 
            // EmploerCm
            // 
            this.EmploerCm.FormattingEnabled = true;
            this.EmploerCm.Location = new System.Drawing.Point(13, 123);
            this.EmploerCm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EmploerCm.Name = "EmploerCm";
            this.EmploerCm.Size = new System.Drawing.Size(210, 21);
            this.EmploerCm.TabIndex = 103;
            // 
            // AnswerLetterFormRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(522, 354);
            this.Controls.Add(this.AddEmploer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmploerCm);
            this.Controls.Add(this.DateOtvet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StatusCm);
            this.Controls.Add(this.DescriptionTx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NomerLetters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomerAppealsTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Name = "AnswerLetterFormRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnswerLetterFormRed";
            this.Load += new System.EventHandler(this.AnswerLetterFormRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateOtvet;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox AddStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StatusCm;
        private WindowsFormsApp2.UserControlTextBox DescriptionTx;
        private System.Windows.Forms.Label label8;
        private WindowsFormsApp2.UserControlTextBox NomerLetters;
        private System.Windows.Forms.Label label4;
        private WindowsFormsApp2.UserControlTextBox NomerAppealsTx;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp2.UserControlButton AddBtn;
        private FontAwesome.Sharp.IconPictureBox AddEmploer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmploerCm;
    }
}