
namespace Appeals_Mes
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordChar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterBtn = new WindowsFormsApp2.UserControlButton();
            this.LoginTextBox = new WindowsFormsApp2.UserControlTextBox();
            this.PasswordTextBox = new WindowsFormsApp2.UserControlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordChar
            // 
            this.PasswordChar.BackColor = System.Drawing.Color.Transparent;
            this.PasswordChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordChar.Image = ((System.Drawing.Image)(resources.GetObject("PasswordChar.Image")));
            this.PasswordChar.Location = new System.Drawing.Point(308, 222);
            this.PasswordChar.Name = "PasswordChar";
            this.PasswordChar.Size = new System.Drawing.Size(28, 28);
            this.PasswordChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordChar.TabIndex = 7;
            this.PasswordChar.TabStop = false;
            this.PasswordChar.Click += new System.EventHandler(this.PasswordChar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(314, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль :";
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.Tomato;
            this.EnterBtn.BackgroundColor = System.Drawing.Color.Tomato;
            this.EnterBtn.BorderColor = System.Drawing.Color.Firebrick;
            this.EnterBtn.BorderRadius = 20;
            this.EnterBtn.BorderSize = 0;
            this.EnterBtn.FlatAppearance.BorderSize = 0;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterBtn.ForeColor = System.Drawing.Color.White;
            this.EnterBtn.Location = new System.Drawing.Point(80, 353);
            this.EnterBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(203, 54);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.TextColor = System.Drawing.Color.White;
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.LoginTextBox.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.LoginTextBox.BorderSize = 2;
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.LoginTextBox.Location = new System.Drawing.Point(70, 157);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Multiline = false;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.LoginTextBox.PasswordChar = false;
            this.LoginTextBox.Size = new System.Drawing.Size(232, 36);
            this.LoginTextBox.TabIndex = 10;
            this.LoginTextBox.Texts = "1";
            this.LoginTextBox.UnderlinedStyle = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.PasswordTextBox.BorderSize = 2;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordTextBox.Location = new System.Drawing.Point(70, 214);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.PasswordTextBox.PasswordChar = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(237, 36);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.Texts = "12";
            this.PasswordTextBox.UnderlinedStyle = true;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 463);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordChar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp2.UserControlButton EnterBtn;
        //private WindowsFormsApp2.UserControl LoginTextBox;
        //private WindowsFormsApp2.UserControl PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PasswordChar;
        //private WindowsFormsApp2.UserControl UserControl1;
        //private WindowsFormsApp2.UserControl UserControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp2.UserControlTextBox LoginTextBox;
        private WindowsFormsApp2.UserControlTextBox PasswordTextBox;
    }
}

