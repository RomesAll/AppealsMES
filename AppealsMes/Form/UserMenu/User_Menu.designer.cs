
namespace Appeals_Mes
{
    partial class User_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.page_search = new System.Windows.Forms.TextBox();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MapRequestsBtn = new FontAwesome.Sharp.IconButton();
            this.StatisticsReportsBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GuideBtn = new FontAwesome.Sharp.IconButton();
            this.StaffBtn = new FontAwesome.Sharp.IconButton();
            this.ProfilBtn = new FontAwesome.Sharp.IconButton();
            this.MapsAppelsBtn = new FontAwesome.Sharp.IconButton();
            this.KlientBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.page_search);
            this.panel1.Controls.Add(this.iconButtonExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 207);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Поиск станиц";
            // 
            // page_search
            // 
            this.page_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_search.Location = new System.Drawing.Point(3, 172);
            this.page_search.MaxLength = 40;
            this.page_search.Name = "page_search";
            this.page_search.Size = new System.Drawing.Size(550, 29);
            this.page_search.TabIndex = 11;
            this.page_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.Location = new System.Drawing.Point(559, 171);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(37, 32);
            this.iconButtonExit.TabIndex = 10;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Должность: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сотрудник: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.MapRequestsBtn);
            this.flowLayoutPanel1.Controls.Add(this.StatisticsReportsBtn);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.GuideBtn);
            this.flowLayoutPanel1.Controls.Add(this.StaffBtn);
            this.flowLayoutPanel1.Controls.Add(this.ProfilBtn);
            this.flowLayoutPanel1.Controls.Add(this.MapsAppelsBtn);
            this.flowLayoutPanel1.Controls.Add(this.KlientBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 207);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 445);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // MapRequestsBtn
            // 
            this.MapRequestsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MapRequestsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MapRequestsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapRequestsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapRequestsBtn.ForeColor = System.Drawing.Color.Black;
            this.MapRequestsBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.MapRequestsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.MapRequestsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MapRequestsBtn.IconSize = 40;
            this.MapRequestsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MapRequestsBtn.Location = new System.Drawing.Point(3, 3);
            this.MapRequestsBtn.Name = "MapRequestsBtn";
            this.MapRequestsBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MapRequestsBtn.Size = new System.Drawing.Size(311, 77);
            this.MapRequestsBtn.TabIndex = 1;
            this.MapRequestsBtn.Text = "Обращения потребителей";
            this.MapRequestsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MapRequestsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MapRequestsBtn.UseVisualStyleBackColor = false;
            this.MapRequestsBtn.Click += new System.EventHandler(this.MapRequestsBtn_Click);
            // 
            // StatisticsReportsBtn
            // 
            this.StatisticsReportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StatisticsReportsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StatisticsReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsReportsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsReportsBtn.ForeColor = System.Drawing.Color.Black;
            this.StatisticsReportsBtn.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.StatisticsReportsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.StatisticsReportsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StatisticsReportsBtn.IconSize = 40;
            this.StatisticsReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticsReportsBtn.Location = new System.Drawing.Point(320, 3);
            this.StatisticsReportsBtn.Name = "StatisticsReportsBtn";
            this.StatisticsReportsBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StatisticsReportsBtn.Size = new System.Drawing.Size(285, 77);
            this.StatisticsReportsBtn.TabIndex = 8;
            this.StatisticsReportsBtn.Text = "Статистика | Отчёты";
            this.StatisticsReportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticsReportsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StatisticsReportsBtn.UseVisualStyleBackColor = false;
            this.StatisticsReportsBtn.Click += new System.EventHandler(this.StatisticsReportsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(3, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 3);
            this.panel2.TabIndex = 14;
            // 
            // GuideBtn
            // 
            this.GuideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GuideBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GuideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuideBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuideBtn.ForeColor = System.Drawing.Color.Black;
            this.GuideBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.GuideBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.GuideBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuideBtn.IconSize = 40;
            this.GuideBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuideBtn.Location = new System.Drawing.Point(3, 95);
            this.GuideBtn.Name = "GuideBtn";
            this.GuideBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GuideBtn.Size = new System.Drawing.Size(196, 77);
            this.GuideBtn.TabIndex = 9;
            this.GuideBtn.Text = "Справочники";
            this.GuideBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuideBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuideBtn.UseVisualStyleBackColor = false;
            this.GuideBtn.Click += new System.EventHandler(this.GuideBtn_Click);
            // 
            // StaffBtn
            // 
            this.StaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StaffBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffBtn.ForeColor = System.Drawing.Color.Black;
            this.StaffBtn.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.StaffBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.StaffBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StaffBtn.IconSize = 40;
            this.StaffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffBtn.Location = new System.Drawing.Point(205, 95);
            this.StaffBtn.Name = "StaffBtn";
            this.StaffBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StaffBtn.Size = new System.Drawing.Size(196, 77);
            this.StaffBtn.TabIndex = 10;
            this.StaffBtn.Text = "Сотрудники";
            this.StaffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StaffBtn.UseVisualStyleBackColor = false;
            // 
            // ProfilBtn
            // 
            this.ProfilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ProfilBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProfilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfilBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilBtn.ForeColor = System.Drawing.Color.Black;
            this.ProfilBtn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ProfilBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ProfilBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProfilBtn.IconSize = 40;
            this.ProfilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfilBtn.Location = new System.Drawing.Point(407, 95);
            this.ProfilBtn.Name = "ProfilBtn";
            this.ProfilBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProfilBtn.Size = new System.Drawing.Size(196, 77);
            this.ProfilBtn.TabIndex = 11;
            this.ProfilBtn.Text = "Профиль";
            this.ProfilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfilBtn.UseVisualStyleBackColor = false;
            // 
            // MapsAppelsBtn
            // 
            this.MapsAppelsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MapsAppelsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MapsAppelsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapsAppelsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapsAppelsBtn.ForeColor = System.Drawing.Color.Black;
            this.MapsAppelsBtn.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.MapsAppelsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.MapsAppelsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MapsAppelsBtn.IconSize = 40;
            this.MapsAppelsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MapsAppelsBtn.Location = new System.Drawing.Point(3, 178);
            this.MapsAppelsBtn.Name = "MapsAppelsBtn";
            this.MapsAppelsBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MapsAppelsBtn.Size = new System.Drawing.Size(196, 77);
            this.MapsAppelsBtn.TabIndex = 12;
            this.MapsAppelsBtn.Text = "Карта обращений";
            this.MapsAppelsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MapsAppelsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MapsAppelsBtn.UseVisualStyleBackColor = false;
            // 
            // KlientBtn
            // 
            this.KlientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.KlientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KlientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KlientBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KlientBtn.ForeColor = System.Drawing.Color.Black;
            this.KlientBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.KlientBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.KlientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KlientBtn.IconSize = 40;
            this.KlientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KlientBtn.Location = new System.Drawing.Point(205, 178);
            this.KlientBtn.Name = "KlientBtn";
            this.KlientBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.KlientBtn.Size = new System.Drawing.Size(197, 77);
            this.KlientBtn.TabIndex = 13;
            this.KlientBtn.Text = "Клиенты";
            this.KlientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KlientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KlientBtn.UseVisualStyleBackColor = false;
            // 
            // User_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 652);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "User_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_Menu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton MapRequestsBtn;
        private FontAwesome.Sharp.IconButton StatisticsReportsBtn;
        private FontAwesome.Sharp.IconButton GuideBtn;
        private FontAwesome.Sharp.IconButton StaffBtn;
        private FontAwesome.Sharp.IconButton ProfilBtn;
        private FontAwesome.Sharp.IconButton MapsAppelsBtn;
        private FontAwesome.Sharp.IconButton KlientBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.TextBox page_search;
        private System.Windows.Forms.Label label3;
    }
}