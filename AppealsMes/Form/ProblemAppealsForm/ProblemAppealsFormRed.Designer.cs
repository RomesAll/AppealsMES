
namespace AppealsMes
{
    partial class ProblemAppealsFormAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemAppealsFormAdd));
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteDocx = new FontAwesome.Sharp.IconPictureBox();
            this.AddDocx = new FontAwesome.Sharp.IconPictureBox();
            this.Docx = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddAdres = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DescriptionTx = new WindowsFormsApp2.UserControlTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddGuidPrioritet = new FontAwesome.Sharp.IconPictureBox();
            this.AddGuidStatus = new FontAwesome.Sharp.IconPictureBox();
            this.AddGuidTypeAppeals = new FontAwesome.Sharp.IconPictureBox();
            this.PrioritetCm = new System.Windows.Forms.ComboBox();
            this.StatusCm = new System.Windows.Forms.ComboBox();
            this.TypeAppealsCm = new System.Windows.Forms.ComboBox();
            this.DateOtvet = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControlTextBox1 = new WindowsFormsApp2.UserControlTextBox();
            this.NomerAppealsTx = new WindowsFormsApp2.UserControlTextBox();
            this.NoteTx = new WindowsFormsApp2.UserControlTextBox();
            this.AdresTx = new WindowsFormsApp2.UserControlTextBox();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDocx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDocx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAdres)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidPrioritet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidTypeAppeals)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Номер обращения";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DeleteDocx);
            this.panel3.Controls.Add(this.AddDocx);
            this.panel3.Controls.Add(this.Docx);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(301, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 225);
            this.panel3.TabIndex = 66;
            // 
            // DeleteDocx
            // 
            this.DeleteDocx.BackColor = System.Drawing.Color.Transparent;
            this.DeleteDocx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDocx.ForeColor = System.Drawing.Color.OrangeRed;
            this.DeleteDocx.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.DeleteDocx.IconColor = System.Drawing.Color.OrangeRed;
            this.DeleteDocx.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteDocx.IconSize = 28;
            this.DeleteDocx.Location = new System.Drawing.Point(235, 59);
            this.DeleteDocx.Name = "DeleteDocx";
            this.DeleteDocx.Size = new System.Drawing.Size(28, 34);
            this.DeleteDocx.TabIndex = 55;
            this.DeleteDocx.TabStop = false;
            this.DeleteDocx.UseGdi = true;
            this.DeleteDocx.Click += new System.EventHandler(this.DeleteDocx_Click);
            // 
            // AddDocx
            // 
            this.AddDocx.BackColor = System.Drawing.Color.Transparent;
            this.AddDocx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDocx.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddDocx.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddDocx.IconColor = System.Drawing.Color.OrangeRed;
            this.AddDocx.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddDocx.IconSize = 28;
            this.AddDocx.Location = new System.Drawing.Point(235, 23);
            this.AddDocx.Name = "AddDocx";
            this.AddDocx.Size = new System.Drawing.Size(28, 34);
            this.AddDocx.TabIndex = 54;
            this.AddDocx.TabStop = false;
            this.AddDocx.UseGdi = true;
            this.AddDocx.Click += new System.EventHandler(this.AddDocx_Click);
            // 
            // Docx
            // 
            this.Docx.FormattingEnabled = true;
            this.Docx.HorizontalScrollbar = true;
            this.Docx.ItemHeight = 17;
            this.Docx.Location = new System.Drawing.Point(6, 23);
            this.Docx.Name = "Docx";
            this.Docx.Size = new System.Drawing.Size(223, 191);
            this.Docx.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Документы";
            // 
            // AddAdres
            // 
            this.AddAdres.BackColor = System.Drawing.Color.Transparent;
            this.AddAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAdres.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddAdres.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddAdres.IconColor = System.Drawing.Color.OrangeRed;
            this.AddAdres.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddAdres.IconSize = 22;
            this.AddAdres.Location = new System.Drawing.Point(543, 291);
            this.AddAdres.Name = "AddAdres";
            this.AddAdres.Size = new System.Drawing.Size(22, 25);
            this.AddAdres.TabIndex = 65;
            this.AddAdres.TabStop = false;
            this.AddAdres.UseGdi = true;
            this.AddAdres.Click += new System.EventHandler(this.AddAdres_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Примечание";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DescriptionTx);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(575, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 225);
            this.panel2.TabIndex = 63;
            // 
            // DescriptionTx
            // 
            this.DescriptionTx.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.DescriptionTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.DescriptionTx.BorderSize = 2;
            this.DescriptionTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTx.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTx.Location = new System.Drawing.Point(8, 24);
            this.DescriptionTx.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTx.Multiline = true;
            this.DescriptionTx.Name = "DescriptionTx";
            this.DescriptionTx.Padding = new System.Windows.Forms.Padding(7);
            this.DescriptionTx.PasswordChar = false;
            this.DescriptionTx.Size = new System.Drawing.Size(212, 191);
            this.DescriptionTx.TabIndex = 0;
            this.DescriptionTx.Texts = "";
            this.DescriptionTx.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Описание";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddGuidPrioritet);
            this.panel1.Controls.Add(this.AddGuidStatus);
            this.panel1.Controls.Add(this.AddGuidTypeAppeals);
            this.panel1.Controls.Add(this.PrioritetCm);
            this.panel1.Controls.Add(this.StatusCm);
            this.panel1.Controls.Add(this.TypeAppealsCm);
            this.panel1.Controls.Add(this.DateOtvet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 225);
            this.panel1.TabIndex = 62;
            // 
            // AddGuidPrioritet
            // 
            this.AddGuidPrioritet.BackColor = System.Drawing.Color.Transparent;
            this.AddGuidPrioritet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGuidPrioritet.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddGuidPrioritet.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddGuidPrioritet.IconColor = System.Drawing.Color.OrangeRed;
            this.AddGuidPrioritet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddGuidPrioritet.IconSize = 22;
            this.AddGuidPrioritet.Location = new System.Drawing.Point(244, 181);
            this.AddGuidPrioritet.Name = "AddGuidPrioritet";
            this.AddGuidPrioritet.Size = new System.Drawing.Size(22, 25);
            this.AddGuidPrioritet.TabIndex = 56;
            this.AddGuidPrioritet.TabStop = false;
            this.AddGuidPrioritet.UseGdi = true;
            this.AddGuidPrioritet.Click += new System.EventHandler(this.AddGuidPrioritet_Click);
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
            this.AddGuidStatus.Location = new System.Drawing.Point(244, 133);
            this.AddGuidStatus.Name = "AddGuidStatus";
            this.AddGuidStatus.Size = new System.Drawing.Size(22, 25);
            this.AddGuidStatus.TabIndex = 55;
            this.AddGuidStatus.TabStop = false;
            this.AddGuidStatus.UseGdi = true;
            this.AddGuidStatus.Click += new System.EventHandler(this.AddGuidStatus_Click);
            // 
            // AddGuidTypeAppeals
            // 
            this.AddGuidTypeAppeals.BackColor = System.Drawing.Color.Transparent;
            this.AddGuidTypeAppeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGuidTypeAppeals.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddGuidTypeAppeals.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddGuidTypeAppeals.IconColor = System.Drawing.Color.OrangeRed;
            this.AddGuidTypeAppeals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddGuidTypeAppeals.IconSize = 22;
            this.AddGuidTypeAppeals.Location = new System.Drawing.Point(244, 85);
            this.AddGuidTypeAppeals.Name = "AddGuidTypeAppeals";
            this.AddGuidTypeAppeals.Size = new System.Drawing.Size(22, 25);
            this.AddGuidTypeAppeals.TabIndex = 54;
            this.AddGuidTypeAppeals.TabStop = false;
            this.AddGuidTypeAppeals.UseGdi = true;
            this.AddGuidTypeAppeals.Click += new System.EventHandler(this.AddGuidTypeAppeals_Click);
            // 
            // PrioritetCm
            // 
            this.PrioritetCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrioritetCm.FormattingEnabled = true;
            this.PrioritetCm.Location = new System.Drawing.Point(38, 181);
            this.PrioritetCm.Name = "PrioritetCm";
            this.PrioritetCm.Size = new System.Drawing.Size(200, 25);
            this.PrioritetCm.TabIndex = 47;
            // 
            // StatusCm
            // 
            this.StatusCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCm.FormattingEnabled = true;
            this.StatusCm.Location = new System.Drawing.Point(38, 133);
            this.StatusCm.Name = "StatusCm";
            this.StatusCm.Size = new System.Drawing.Size(200, 25);
            this.StatusCm.TabIndex = 46;
            // 
            // TypeAppealsCm
            // 
            this.TypeAppealsCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeAppealsCm.FormattingEnabled = true;
            this.TypeAppealsCm.Location = new System.Drawing.Point(38, 85);
            this.TypeAppealsCm.Name = "TypeAppealsCm";
            this.TypeAppealsCm.Size = new System.Drawing.Size(200, 25);
            this.TypeAppealsCm.TabIndex = 45;
            // 
            // DateOtvet
            // 
            this.DateOtvet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOtvet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOtvet.Location = new System.Drawing.Point(38, 34);
            this.DateOtvet.Name = "DateOtvet";
            this.DateOtvet.Size = new System.Drawing.Size(200, 25);
            this.DateOtvet.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата запланированного ответа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Тип обращения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Приоритет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Номер проблемы обращения";
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
            this.userControlTextBox1.Location = new System.Drawing.Point(404, 8);
            this.userControlTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlTextBox1.Multiline = false;
            this.userControlTextBox1.Name = "userControlTextBox1";
            this.userControlTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.userControlTextBox1.PasswordChar = false;
            this.userControlTextBox1.Size = new System.Drawing.Size(62, 35);
            this.userControlTextBox1.TabIndex = 70;
            this.userControlTextBox1.Texts = "";
            this.userControlTextBox1.UnderlinedStyle = true;
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
            this.NomerAppealsTx.Location = new System.Drawing.Point(128, 8);
            this.NomerAppealsTx.Margin = new System.Windows.Forms.Padding(4);
            this.NomerAppealsTx.Multiline = false;
            this.NomerAppealsTx.Name = "NomerAppealsTx";
            this.NomerAppealsTx.Padding = new System.Windows.Forms.Padding(7);
            this.NomerAppealsTx.PasswordChar = false;
            this.NomerAppealsTx.Size = new System.Drawing.Size(62, 35);
            this.NomerAppealsTx.TabIndex = 68;
            this.NomerAppealsTx.Texts = "";
            this.NomerAppealsTx.UnderlinedStyle = true;
            // 
            // NoteTx
            // 
            this.NoteTx.BackColor = System.Drawing.SystemColors.Window;
            this.NoteTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.NoteTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NoteTx.BorderSize = 2;
            this.NoteTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTx.ForeColor = System.Drawing.Color.Black;
            this.NoteTx.Location = new System.Drawing.Point(106, 323);
            this.NoteTx.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTx.Multiline = false;
            this.NoteTx.Name = "NoteTx";
            this.NoteTx.Padding = new System.Windows.Forms.Padding(7);
            this.NoteTx.PasswordChar = false;
            this.NoteTx.Size = new System.Drawing.Size(435, 35);
            this.NoteTx.TabIndex = 61;
            this.NoteTx.Texts = "";
            this.NoteTx.UnderlinedStyle = false;
            // 
            // AdresTx
            // 
            this.AdresTx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AdresTx.BorderColor = System.Drawing.Color.OrangeRed;
            this.AdresTx.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.AdresTx.BorderSize = 2;
            this.AdresTx.Enabled = false;
            this.AdresTx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdresTx.ForeColor = System.Drawing.Color.Black;
            this.AdresTx.Location = new System.Drawing.Point(106, 280);
            this.AdresTx.Margin = new System.Windows.Forms.Padding(4);
            this.AdresTx.Multiline = false;
            this.AdresTx.Name = "AdresTx";
            this.AdresTx.Padding = new System.Windows.Forms.Padding(7);
            this.AdresTx.PasswordChar = false;
            this.AdresTx.Size = new System.Drawing.Size(435, 35);
            this.AdresTx.TabIndex = 64;
            this.AdresTx.Texts = "";
            this.AdresTx.UnderlinedStyle = true;
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
            this.AddBtn.Location = new System.Drawing.Point(575, 287);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(230, 69);
            this.AddBtn.TabIndex = 58;
            this.AddBtn.Text = "Редактировать запись";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProblemAppealsFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 373);
            this.Controls.Add(this.userControlTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomerAppealsTx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NoteTx);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AddAdres);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AdresTx);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ProblemAppealsFormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проблема обращений";
            this.Load += new System.EventHandler(this.ProblemAppealsFormAdd_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDocx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddDocx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAdres)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidPrioritet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddGuidTypeAppeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp2.UserControlTextBox NomerAppealsTx;
        private System.Windows.Forms.Label label7;
        private WindowsFormsApp2.UserControlTextBox NoteTx;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox DeleteDocx;
        private FontAwesome.Sharp.IconPictureBox AddDocx;
        private System.Windows.Forms.ListBox Docx;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox AddAdres;
        private System.Windows.Forms.Label label10;
        public WindowsFormsApp2.UserControlTextBox AdresTx;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsApp2.UserControlTextBox DescriptionTx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox AddGuidPrioritet;
        private FontAwesome.Sharp.IconPictureBox AddGuidStatus;
        private FontAwesome.Sharp.IconPictureBox AddGuidTypeAppeals;
        private System.Windows.Forms.ComboBox PrioritetCm;
        private System.Windows.Forms.ComboBox StatusCm;
        private System.Windows.Forms.ComboBox TypeAppealsCm;
        private System.Windows.Forms.DateTimePicker DateOtvet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private WindowsFormsApp2.UserControlButton AddBtn;
        private System.Windows.Forms.Label label9;
        private WindowsFormsApp2.UserControlTextBox userControlTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}