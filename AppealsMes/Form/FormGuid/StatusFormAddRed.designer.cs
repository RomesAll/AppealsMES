
namespace Appeals_Mes
{
    partial class StatusFormAddRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusFormAddRed));
            this.SelectStatusDg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectModeCm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new WindowsFormsApp2.UserControlButton();
            this.NomerTb = new WindowsFormsApp2.UserControlTextBox();
            this.NameTb = new WindowsFormsApp2.UserControlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectStatusDg)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectStatusDg
            // 
            this.SelectStatusDg.AllowUserToAddRows = false;
            this.SelectStatusDg.AllowUserToDeleteRows = false;
            this.SelectStatusDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectStatusDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectStatusDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.SelectStatusDg.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectStatusDg.Location = new System.Drawing.Point(0, 0);
            this.SelectStatusDg.Name = "SelectStatusDg";
            this.SelectStatusDg.ReadOnly = true;
            this.SelectStatusDg.Size = new System.Drawing.Size(286, 384);
            this.SelectStatusDg.TabIndex = 2;
            this.SelectStatusDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectStatusDg_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_statuses";
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "statuses";
            this.Column2.HeaderText = "Наименование статуса";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер записи:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(292, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование:";
            // 
            // SelectModeCm
            // 
            this.SelectModeCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectModeCm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectModeCm.FormattingEnabled = true;
            this.SelectModeCm.Items.AddRange(new object[] {
            "Добавить запись",
            "Редактировать запись",
            "Удалить запись"});
            this.SelectModeCm.Location = new System.Drawing.Point(296, 281);
            this.SelectModeCm.Name = "SelectModeCm";
            this.SelectModeCm.Size = new System.Drawing.Size(276, 28);
            this.SelectModeCm.TabIndex = 6;
            this.SelectModeCm.SelectedIndexChanged += new System.EventHandler(this.SelectModeCm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(292, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите режим";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddBtn.BorderColor = System.Drawing.Color.Firebrick;
            this.AddBtn.BorderRadius = 40;
            this.AddBtn.BorderSize = 1;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(286, 315);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(299, 69);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить запись";
            this.AddBtn.TextColor = System.Drawing.Color.Black;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NomerTb
            // 
            this.NomerTb.BackColor = System.Drawing.SystemColors.Control;
            this.NomerTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NomerTb.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NomerTb.BorderSize = 2;
            this.NomerTb.Enabled = false;
            this.NomerTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NomerTb.ForeColor = System.Drawing.Color.Black;
            this.NomerTb.Location = new System.Drawing.Point(418, 45);
            this.NomerTb.Margin = new System.Windows.Forms.Padding(4);
            this.NomerTb.Multiline = false;
            this.NomerTb.Name = "NomerTb";
            this.NomerTb.Padding = new System.Windows.Forms.Padding(7);
            this.NomerTb.PasswordChar = false;
            this.NomerTb.Size = new System.Drawing.Size(163, 35);
            this.NomerTb.TabIndex = 8;
            this.NomerTb.Texts = "";
            this.NomerTb.UnderlinedStyle = true;
            // 
            // NameTb
            // 
            this.NameTb.BackColor = System.Drawing.SystemColors.Control;
            this.NameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NameTb.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.NameTb.BorderSize = 2;
            this.NameTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTb.ForeColor = System.Drawing.Color.Black;
            this.NameTb.Location = new System.Drawing.Point(418, 90);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTb.Multiline = false;
            this.NameTb.Name = "NameTb";
            this.NameTb.Padding = new System.Windows.Forms.Padding(7);
            this.NameTb.PasswordChar = false;
            this.NameTb.Size = new System.Drawing.Size(163, 35);
            this.NameTb.TabIndex = 9;
            this.NameTb.Texts = "";
            this.NameTb.UnderlinedStyle = true;
            this.NameTb._TextChanged += new System.EventHandler(this.NameTb__TextChanged);
            // 
            // StatusFormAddRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 384);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.NomerTb);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectModeCm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectStatusDg);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "StatusFormAddRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник статусов";
            ((System.ComponentModel.ISupportInitialize)(this.SelectStatusDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp2.UserControlButton AddBtn;
       // private WindowsFormsApp2.UserControlTextBox NameTb;
        private System.Windows.Forms.DataGridView SelectStatusDg;
       // private WindowsFormsApp2.UserControlTextBox NomerTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectModeCm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private WindowsFormsApp2.UserControlTextBox NomerTb;
        private WindowsFormsApp2.UserControlTextBox NameTb;
    }
}