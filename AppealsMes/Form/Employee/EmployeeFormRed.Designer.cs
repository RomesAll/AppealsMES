
namespace AppealsMes
{
    partial class EmployeeFormRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFormRed));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RedClients = new WindowsFormsApp2.UserControlButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TelephoneTx = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTx = new WindowsFormsApp2.UserControlTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatronymicTx = new WindowsFormsApp2.UserControlTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTx = new WindowsFormsApp2.UserControlTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTx = new WindowsFormsApp2.UserControlTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PasswordTx = new WindowsFormsApp2.UserControlTextBox();
            this.LoginTx = new WindowsFormsApp2.UserControlTextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(620, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 29);
            this.dateTimePicker1.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(91, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 109;
            this.label8.Text = "Должность";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 29);
            this.comboBox1.TabIndex = 108;
            // 
            // RedClients
            // 
            this.RedClients.BackColor = System.Drawing.Color.White;
            this.RedClients.BackgroundColor = System.Drawing.Color.White;
            this.RedClients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.RedClients.BorderRadius = 20;
            this.RedClients.BorderSize = 1;
            this.RedClients.FlatAppearance.BorderSize = 0;
            this.RedClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedClients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedClients.ForeColor = System.Drawing.Color.Black;
            this.RedClients.Location = new System.Drawing.Point(188, 220);
            this.RedClients.Name = "RedClients";
            this.RedClients.Size = new System.Drawing.Size(250, 55);
            this.RedClients.TabIndex = 107;
            this.RedClients.Text = "Редактировать сотрудника";
            this.RedClients.TextColor = System.Drawing.Color.Black;
            this.RedClients.UseVisualStyleBackColor = false;
            this.RedClients.Click += new System.EventHandler(this.RedClients_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(492, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 106;
            this.label6.Text = "Дата рождения";
            // 
            // TelephoneTx
            // 
            this.TelephoneTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneTx.Location = new System.Drawing.Point(620, 72);
            this.TelephoneTx.Mask = "(999) 000-0000";
            this.TelephoneTx.Name = "TelephoneTx";
            this.TelephoneTx.Size = new System.Drawing.Size(253, 29);
            this.TelephoneTx.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(457, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 104;
            this.label5.Text = "Телефон сотрудника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(478, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 103;
            this.label4.Text = "Email сотрудника";
            // 
            // EmailTx
            // 
            this.EmailTx.BackColor = System.Drawing.SystemColors.Control;
            this.EmailTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.EmailTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.EmailTx.BorderSize = 2;
            this.EmailTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTx.ForeColor = System.Drawing.Color.Black;
            this.EmailTx.Location = new System.Drawing.Point(620, 19);
            this.EmailTx.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTx.Multiline = false;
            this.EmailTx.Name = "EmailTx";
            this.EmailTx.Padding = new System.Windows.Forms.Padding(7);
            this.EmailTx.PasswordChar = false;
            this.EmailTx.Size = new System.Drawing.Size(253, 36);
            this.EmailTx.TabIndex = 102;
            this.EmailTx.Texts = "";
            this.EmailTx.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 101;
            this.label3.Text = "Отчество сотрудника";
            // 
            // PatronymicTx
            // 
            this.PatronymicTx.BackColor = System.Drawing.SystemColors.Control;
            this.PatronymicTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.PatronymicTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.PatronymicTx.BorderSize = 2;
            this.PatronymicTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTx.ForeColor = System.Drawing.Color.Black;
            this.PatronymicTx.Location = new System.Drawing.Point(188, 109);
            this.PatronymicTx.Margin = new System.Windows.Forms.Padding(4);
            this.PatronymicTx.Multiline = false;
            this.PatronymicTx.Name = "PatronymicTx";
            this.PatronymicTx.Padding = new System.Windows.Forms.Padding(7);
            this.PatronymicTx.PasswordChar = false;
            this.PatronymicTx.Size = new System.Drawing.Size(250, 36);
            this.PatronymicTx.TabIndex = 100;
            this.PatronymicTx.Texts = "";
            this.PatronymicTx.UnderlinedStyle = true;
            this.PatronymicTx._TextChanged += new System.EventHandler(this.PatronymicTx__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 99;
            this.label2.Text = "Имя сотрудника";
            // 
            // NameTx
            // 
            this.NameTx.BackColor = System.Drawing.SystemColors.Control;
            this.NameTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.NameTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NameTx.BorderSize = 2;
            this.NameTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTx.ForeColor = System.Drawing.Color.Black;
            this.NameTx.Location = new System.Drawing.Point(188, 65);
            this.NameTx.Margin = new System.Windows.Forms.Padding(4);
            this.NameTx.Multiline = false;
            this.NameTx.Name = "NameTx";
            this.NameTx.Padding = new System.Windows.Forms.Padding(7);
            this.NameTx.PasswordChar = false;
            this.NameTx.Size = new System.Drawing.Size(250, 36);
            this.NameTx.TabIndex = 98;
            this.NameTx.Texts = "";
            this.NameTx.UnderlinedStyle = true;
            this.NameTx._TextChanged += new System.EventHandler(this.NameTx__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 97;
            this.label1.Text = "Фамилия сотрудника";
            // 
            // SurnameTx
            // 
            this.SurnameTx.BackColor = System.Drawing.SystemColors.Control;
            this.SurnameTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.SurnameTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.SurnameTx.BorderSize = 2;
            this.SurnameTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTx.ForeColor = System.Drawing.Color.Black;
            this.SurnameTx.Location = new System.Drawing.Point(188, 21);
            this.SurnameTx.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameTx.Multiline = false;
            this.SurnameTx.Name = "SurnameTx";
            this.SurnameTx.Padding = new System.Windows.Forms.Padding(7);
            this.SurnameTx.PasswordChar = false;
            this.SurnameTx.Size = new System.Drawing.Size(250, 36);
            this.SurnameTx.TabIndex = 96;
            this.SurnameTx.Texts = "";
            this.SurnameTx.UnderlinedStyle = true;
            this.SurnameTx._TextChanged += new System.EventHandler(this.SurnameTx__TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(550, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 114;
            this.label9.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(559, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 113;
            this.label7.Text = "Логин";
            // 
            // PasswordTx
            // 
            this.PasswordTx.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.PasswordTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.PasswordTx.BorderSize = 2;
            this.PasswordTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTx.ForeColor = System.Drawing.Color.Black;
            this.PasswordTx.Location = new System.Drawing.Point(620, 198);
            this.PasswordTx.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTx.Multiline = false;
            this.PasswordTx.Name = "PasswordTx";
            this.PasswordTx.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordTx.PasswordChar = false;
            this.PasswordTx.Size = new System.Drawing.Size(253, 36);
            this.PasswordTx.TabIndex = 112;
            this.PasswordTx.Texts = "";
            this.PasswordTx.UnderlinedStyle = true;
            // 
            // LoginTx
            // 
            this.LoginTx.BackColor = System.Drawing.SystemColors.Control;
            this.LoginTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.LoginTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.LoginTx.BorderSize = 2;
            this.LoginTx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTx.ForeColor = System.Drawing.Color.Black;
            this.LoginTx.Location = new System.Drawing.Point(620, 154);
            this.LoginTx.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTx.Multiline = false;
            this.LoginTx.Name = "LoginTx";
            this.LoginTx.Padding = new System.Windows.Forms.Padding(7);
            this.LoginTx.PasswordChar = false;
            this.LoginTx.Size = new System.Drawing.Size(253, 36);
            this.LoginTx.TabIndex = 111;
            this.LoginTx.Texts = "";
            this.LoginTx.UnderlinedStyle = true;
            // 
            // EmployeeFormRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 286);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PasswordTx);
            this.Controls.Add(this.LoginTx);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RedClients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelephoneTx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailTx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatronymicTx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurnameTx);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EmployeeFormRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование сотрудника";
            this.Load += new System.EventHandler(this.EmployeeFormRed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private WindowsFormsApp2.UserControlButton RedClients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TelephoneTx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private WindowsFormsApp2.UserControlTextBox EmailTx;
        private System.Windows.Forms.Label label3;
        private WindowsFormsApp2.UserControlTextBox PatronymicTx;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp2.UserControlTextBox NameTx;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp2.UserControlTextBox SurnameTx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private WindowsFormsApp2.UserControlTextBox PasswordTx;
        private WindowsFormsApp2.UserControlTextBox LoginTx;
    }
}