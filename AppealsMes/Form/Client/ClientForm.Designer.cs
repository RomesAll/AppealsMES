
namespace AppealsMes
{
    partial class ClientForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.SearchRecords = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddClients = new WindowsFormsApp2.UserControlButton();
            this.DeleteClients = new WindowsFormsApp2.UserControlButton();
            this.RedCLients = new WindowsFormsApp2.UserControlButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Поиск";
            // 
            // SearchRecords
            // 
            this.SearchRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchRecords.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchRecords.Location = new System.Drawing.Point(746, 36);
            this.SearchRecords.Name = "SearchRecords";
            this.SearchRecords.Size = new System.Drawing.Size(229, 25);
            this.SearchRecords.TabIndex = 77;
            this.SearchRecords.TextChanged += new System.EventHandler(this.SearchRecords_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(963, 630);
            this.dataGridView1.TabIndex = 79;
            // 
            // AddClients
            // 
            this.AddClients.BackColor = System.Drawing.Color.White;
            this.AddClients.BackgroundColor = System.Drawing.Color.White;
            this.AddClients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.AddClients.BorderRadius = 20;
            this.AddClients.BorderSize = 1;
            this.AddClients.FlatAppearance.BorderSize = 0;
            this.AddClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClients.ForeColor = System.Drawing.Color.Black;
            this.AddClients.Location = new System.Drawing.Point(12, 24);
            this.AddClients.Name = "AddClients";
            this.AddClients.Size = new System.Drawing.Size(152, 45);
            this.AddClients.TabIndex = 76;
            this.AddClients.Text = "Добавить клиента";
            this.AddClients.TextColor = System.Drawing.Color.Black;
            this.AddClients.UseVisualStyleBackColor = false;
            this.AddClients.Click += new System.EventHandler(this.AddClients_Click);
            // 
            // DeleteClients
            // 
            this.DeleteClients.BackColor = System.Drawing.Color.White;
            this.DeleteClients.BackgroundColor = System.Drawing.Color.White;
            this.DeleteClients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.DeleteClients.BorderRadius = 20;
            this.DeleteClients.BorderSize = 1;
            this.DeleteClients.FlatAppearance.BorderSize = 0;
            this.DeleteClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteClients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClients.ForeColor = System.Drawing.Color.Black;
            this.DeleteClients.Location = new System.Drawing.Point(351, 24);
            this.DeleteClients.Name = "DeleteClients";
            this.DeleteClients.Size = new System.Drawing.Size(157, 45);
            this.DeleteClients.TabIndex = 75;
            this.DeleteClients.Text = "Удалить клиента";
            this.DeleteClients.TextColor = System.Drawing.Color.Black;
            this.DeleteClients.UseVisualStyleBackColor = false;
            this.DeleteClients.Click += new System.EventHandler(this.DeleteClients_Click);
            // 
            // RedCLients
            // 
            this.RedCLients.BackColor = System.Drawing.Color.White;
            this.RedCLients.BackgroundColor = System.Drawing.Color.White;
            this.RedCLients.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.RedCLients.BorderRadius = 20;
            this.RedCLients.BorderSize = 1;
            this.RedCLients.FlatAppearance.BorderSize = 0;
            this.RedCLients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedCLients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedCLients.ForeColor = System.Drawing.Color.Black;
            this.RedCLients.Location = new System.Drawing.Point(170, 24);
            this.RedCLients.Name = "RedCLients";
            this.RedCLients.Size = new System.Drawing.Size(175, 45);
            this.RedCLients.TabIndex = 74;
            this.RedCLients.Text = "Редкатировать клиента";
            this.RedCLients.TextColor = System.Drawing.Color.Black;
            this.RedCLients.UseVisualStyleBackColor = false;
            this.RedCLients.Click += new System.EventHandler(this.RedCLients_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_customers";
            this.Column1.HeaderText = "Номер клиента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Surname_customers";
            this.Column2.HeaderText = "Фамилия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Name_customers";
            this.Column3.HeaderText = "Имя";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Patronymic_customers";
            this.Column4.HeaderText = "Отчество";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email_customers";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Telephone";
            this.Column6.HeaderText = "Телефон";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Address_correspondence";
            this.Column7.HeaderText = "Адрес для корреспондента";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Note";
            this.Column8.HeaderText = "Примечание";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 717);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchRecords);
            this.Controls.Add(this.AddClients);
            this.Controls.Add(this.DeleteClients);
            this.Controls.Add(this.RedCLients);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsApp2.UserControlButton AddClients;
        private WindowsFormsApp2.UserControlButton DeleteClients;
        private WindowsFormsApp2.UserControlButton RedCLients;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}