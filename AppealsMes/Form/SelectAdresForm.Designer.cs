
namespace AppealsMes
{
    partial class SelectAdresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAdresForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StreetCm = new System.Windows.Forms.ComboBox();
            this.AddProblemIco = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.DistrictCm = new System.Windows.Forms.ComboBox();
            this.AddAdresBtn = new WindowsFormsApp2.UserControlButton();
            this.KvCm = new WindowsFormsApp2.UserControlTextBox();
            this.KorpysCm = new WindowsFormsApp2.UserControlTextBox();
            this.HomeCm = new WindowsFormsApp2.UserControlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddProblemIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Район:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Улица:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дом:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(131, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Корпус:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(268, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Квартира:";
            // 
            // StreetCm
            // 
            this.StreetCm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StreetCm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StreetCm.FormattingEnabled = true;
            this.StreetCm.Location = new System.Drawing.Point(73, 74);
            this.StreetCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StreetCm.Name = "StreetCm";
            this.StreetCm.Size = new System.Drawing.Size(326, 25);
            this.StreetCm.TabIndex = 11;
            // 
            // AddProblemIco
            // 
            this.AddProblemIco.BackColor = System.Drawing.Color.Transparent;
            this.AddProblemIco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProblemIco.ForeColor = System.Drawing.Color.OrangeRed;
            this.AddProblemIco.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddProblemIco.IconColor = System.Drawing.Color.OrangeRed;
            this.AddProblemIco.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddProblemIco.IconSize = 25;
            this.AddProblemIco.Location = new System.Drawing.Point(405, 35);
            this.AddProblemIco.Name = "AddProblemIco";
            this.AddProblemIco.Size = new System.Drawing.Size(29, 25);
            this.AddProblemIco.TabIndex = 56;
            this.AddProblemIco.TabStop = false;
            this.AddProblemIco.UseGdi = true;
            this.AddProblemIco.Click += new System.EventHandler(this.AddProblemIco_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.OrangeRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(405, 75);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 25);
            this.iconPictureBox1.TabIndex = 57;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.UseGdi = true;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // DistrictCm
            // 
            this.DistrictCm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DistrictCm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DistrictCm.FormattingEnabled = true;
            this.DistrictCm.Location = new System.Drawing.Point(73, 35);
            this.DistrictCm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DistrictCm.Name = "DistrictCm";
            this.DistrictCm.Size = new System.Drawing.Size(326, 25);
            this.DistrictCm.TabIndex = 58;
            this.DistrictCm.SelectedIndexChanged += new System.EventHandler(this.DistrictCm_SelectedIndexChanged);
            // 
            // AddAdresBtn
            // 
            this.AddAdresBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddAdresBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.AddAdresBtn.BorderColor = System.Drawing.Color.OrangeRed;
            this.AddAdresBtn.BorderRadius = 30;
            this.AddAdresBtn.BorderSize = 1;
            this.AddAdresBtn.FlatAppearance.BorderSize = 0;
            this.AddAdresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAdresBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAdresBtn.ForeColor = System.Drawing.Color.Black;
            this.AddAdresBtn.Location = new System.Drawing.Point(135, 199);
            this.AddAdresBtn.Name = "AddAdresBtn";
            this.AddAdresBtn.Size = new System.Drawing.Size(187, 52);
            this.AddAdresBtn.TabIndex = 10;
            this.AddAdresBtn.Text = "Добавить адрес";
            this.AddAdresBtn.TextColor = System.Drawing.Color.Black;
            this.AddAdresBtn.UseVisualStyleBackColor = false;
            this.AddAdresBtn.Click += new System.EventHandler(this.AddAdresBtn_Click);
            // 
            // KvCm
            // 
            this.KvCm.BackColor = System.Drawing.SystemColors.Control;
            this.KvCm.BorderColor = System.Drawing.Color.OrangeRed;
            this.KvCm.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.KvCm.BorderSize = 2;
            this.KvCm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KvCm.ForeColor = System.Drawing.Color.DimGray;
            this.KvCm.Location = new System.Drawing.Point(351, 106);
            this.KvCm.Margin = new System.Windows.Forms.Padding(4);
            this.KvCm.Multiline = false;
            this.KvCm.Name = "KvCm";
            this.KvCm.Padding = new System.Windows.Forms.Padding(7);
            this.KvCm.PasswordChar = false;
            this.KvCm.Size = new System.Drawing.Size(62, 36);
            this.KvCm.TabIndex = 8;
            this.KvCm.Texts = "";
            this.KvCm.UnderlinedStyle = true;
            // 
            // KorpysCm
            // 
            this.KorpysCm.BackColor = System.Drawing.SystemColors.Control;
            this.KorpysCm.BorderColor = System.Drawing.Color.OrangeRed;
            this.KorpysCm.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.KorpysCm.BorderSize = 2;
            this.KorpysCm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KorpysCm.ForeColor = System.Drawing.Color.DimGray;
            this.KorpysCm.Location = new System.Drawing.Point(199, 106);
            this.KorpysCm.Margin = new System.Windows.Forms.Padding(4);
            this.KorpysCm.Multiline = false;
            this.KorpysCm.Name = "KorpysCm";
            this.KorpysCm.Padding = new System.Windows.Forms.Padding(7);
            this.KorpysCm.PasswordChar = false;
            this.KorpysCm.Size = new System.Drawing.Size(62, 36);
            this.KorpysCm.TabIndex = 6;
            this.KorpysCm.Texts = "";
            this.KorpysCm.UnderlinedStyle = true;
            // 
            // HomeCm
            // 
            this.HomeCm.BackColor = System.Drawing.SystemColors.Control;
            this.HomeCm.BorderColor = System.Drawing.Color.OrangeRed;
            this.HomeCm.BorderFocusColor = System.Drawing.Color.IndianRed;
            this.HomeCm.BorderSize = 2;
            this.HomeCm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeCm.ForeColor = System.Drawing.Color.DimGray;
            this.HomeCm.Location = new System.Drawing.Point(74, 105);
            this.HomeCm.Margin = new System.Windows.Forms.Padding(4);
            this.HomeCm.Multiline = false;
            this.HomeCm.Name = "HomeCm";
            this.HomeCm.Padding = new System.Windows.Forms.Padding(7);
            this.HomeCm.PasswordChar = false;
            this.HomeCm.Size = new System.Drawing.Size(50, 36);
            this.HomeCm.TabIndex = 4;
            this.HomeCm.Texts = "";
            this.HomeCm.UnderlinedStyle = true;
            // 
            // SelectAdresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 263);
            this.Controls.Add(this.DistrictCm);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.AddProblemIco);
            this.Controls.Add(this.StreetCm);
            this.Controls.Add(this.AddAdresBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KvCm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KorpysCm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HomeCm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SelectAdresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавьте адрес";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectAdresForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AddProblemIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp2.UserControlTextBox HomeCm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WindowsFormsApp2.UserControlTextBox KorpysCm;
        private System.Windows.Forms.Label label5;
        private WindowsFormsApp2.UserControlTextBox KvCm;
        private WindowsFormsApp2.UserControlButton AddAdresBtn;
        private System.Windows.Forms.ComboBox StreetCm;
        private FontAwesome.Sharp.IconPictureBox AddProblemIco;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox DistrictCm;
    }
}