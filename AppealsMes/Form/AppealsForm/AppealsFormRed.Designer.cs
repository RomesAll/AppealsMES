
namespace AppealsMes
{
    partial class AppealsFormRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppealsFormRed));
            this.label5 = new System.Windows.Forms.Label();
            this.MethodCm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusCm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.EmploerCm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KlientCm = new System.Windows.Forms.ComboBox();
            this.AddMethodAppeals = new FontAwesome.Sharp.IconPictureBox();
            this.AddStatus = new FontAwesome.Sharp.IconPictureBox();
            this.AddEmploer = new FontAwesome.Sharp.IconPictureBox();
            this.AddKlient = new FontAwesome.Sharp.IconPictureBox();
            this.NoteTx = new WindowsFormsApp2.UserControlTextBox();
            this.DateTx = new WindowsFormsApp2.UserControlTextBox();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            ((System.ComponentModel.ISupportInitialize)(this.AddMethodAppeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddKlient)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Способ обращений";
            // 
            // MethodCm
            // 
            this.MethodCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodCm.FormattingEnabled = true;
            this.MethodCm.Location = new System.Drawing.Point(40, 202);
            this.MethodCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MethodCm.Name = "MethodCm";
            this.MethodCm.Size = new System.Drawing.Size(313, 25);
            this.MethodCm.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(394, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Примечание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Статус";
            // 
            // StatusCm
            // 
            this.StatusCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCm.FormattingEnabled = true;
            this.StatusCm.Location = new System.Drawing.Point(38, 151);
            this.StatusCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusCm.Name = "StatusCm";
            this.StatusCm.Size = new System.Drawing.Size(313, 25);
            this.StatusCm.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(394, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Дата обращения";
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Location = new System.Drawing.Point(397, 50);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 41;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Выберите сотрудника";
            // 
            // EmploerCm
            // 
            this.EmploerCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmploerCm.FormattingEnabled = true;
            this.EmploerCm.Location = new System.Drawing.Point(39, 101);
            this.EmploerCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmploerCm.Name = "EmploerCm";
            this.EmploerCm.Size = new System.Drawing.Size(313, 25);
            this.EmploerCm.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Выберите клиента";
            // 
            // KlientCm
            // 
            this.KlientCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlientCm.FormattingEnabled = true;
            this.KlientCm.Location = new System.Drawing.Point(39, 50);
            this.KlientCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KlientCm.Name = "KlientCm";
            this.KlientCm.Size = new System.Drawing.Size(313, 25);
            this.KlientCm.TabIndex = 37;
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
            this.AddMethodAppeals.Location = new System.Drawing.Point(357, 202);
            this.AddMethodAppeals.Name = "AddMethodAppeals";
            this.AddMethodAppeals.Size = new System.Drawing.Size(22, 25);
            this.AddMethodAppeals.TabIndex = 54;
            this.AddMethodAppeals.TabStop = false;
            this.AddMethodAppeals.UseGdi = true;
            this.AddMethodAppeals.Click += new System.EventHandler(this.AddMethodAppeals_Click);
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
            this.AddStatus.Location = new System.Drawing.Point(357, 151);
            this.AddStatus.Name = "AddStatus";
            this.AddStatus.Size = new System.Drawing.Size(22, 25);
            this.AddStatus.TabIndex = 49;
            this.AddStatus.TabStop = false;
            this.AddStatus.UseGdi = true;
            this.AddStatus.Click += new System.EventHandler(this.AddStatus_Click);
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
            this.AddEmploer.Location = new System.Drawing.Point(357, 101);
            this.AddEmploer.Name = "AddEmploer";
            this.AddEmploer.Size = new System.Drawing.Size(22, 25);
            this.AddEmploer.TabIndex = 48;
            this.AddEmploer.TabStop = false;
            this.AddEmploer.UseGdi = true;
            this.AddEmploer.Click += new System.EventHandler(this.AddEmploer_Click);
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
            this.AddKlient.Location = new System.Drawing.Point(357, 50);
            this.AddKlient.Name = "AddKlient";
            this.AddKlient.Size = new System.Drawing.Size(22, 25);
            this.AddKlient.TabIndex = 47;
            this.AddKlient.TabStop = false;
            this.AddKlient.UseGdi = true;
            this.AddKlient.Click += new System.EventHandler(this.AddKlient_Click);
            // 
            // NoteTx
            // 
            this.NoteTx.BackColor = System.Drawing.SystemColors.Window;
            this.NoteTx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NoteTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NoteTx.BorderSize = 2;
            this.NoteTx.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTx.ForeColor = System.Drawing.Color.DimGray;
            this.NoteTx.Location = new System.Drawing.Point(397, 240);
            this.NoteTx.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTx.Multiline = true;
            this.NoteTx.Name = "NoteTx";
            this.NoteTx.Padding = new System.Windows.Forms.Padding(7);
            this.NoteTx.PasswordChar = false;
            this.NoteTx.Size = new System.Drawing.Size(332, 92);
            this.NoteTx.TabIndex = 50;
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
            this.DateTx.Location = new System.Drawing.Point(511, 14);
            this.DateTx.Margin = new System.Windows.Forms.Padding(4);
            this.DateTx.Multiline = false;
            this.DateTx.Name = "DateTx";
            this.DateTx.Padding = new System.Windows.Forms.Padding(7);
            this.DateTx.PasswordChar = false;
            this.DateTx.Size = new System.Drawing.Size(95, 32);
            this.DateTx.TabIndex = 46;
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
            this.AddBtn.Location = new System.Drawing.Point(40, 255);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(313, 59);
            this.AddBtn.TabIndex = 45;
            this.AddBtn.Text = "Редактировать обращение";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AppealsFormRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 357);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AppealsFormRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование обращений";
            this.Load += new System.EventHandler(this.AppealsFormRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddMethodAppeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmploer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddKlient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox AddMethodAppeals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MethodCm;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp2.UserControlTextBox NoteTx;
        private FontAwesome.Sharp.IconPictureBox AddStatus;
        private FontAwesome.Sharp.IconPictureBox AddEmploer;
        private FontAwesome.Sharp.IconPictureBox AddKlient;
        private WindowsFormsApp2.UserControlTextBox DateTx;
        private WindowsFormsApp2.UserControlButton AddBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StatusCm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmploerCm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KlientCm;
    }
}