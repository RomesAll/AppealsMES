
namespace Appeals_Mes
{
    partial class GuideForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StatusBtn = new FontAwesome.Sharp.IconButton();
            this.PrioritietBtn = new FontAwesome.Sharp.IconButton();
            this.PostBtn = new FontAwesome.Sharp.IconButton();
            this.MethodTreatmentBtn = new FontAwesome.Sharp.IconButton();
            this.DistrictBtn = new FontAwesome.Sharp.IconButton();
            this.TypeAppealBtn = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Controls.Add(this.StatusBtn);
            this.flowLayoutPanel1.Controls.Add(this.PrioritietBtn);
            this.flowLayoutPanel1.Controls.Add(this.PostBtn);
            this.flowLayoutPanel1.Controls.Add(this.MethodTreatmentBtn);
            this.flowLayoutPanel1.Controls.Add(this.DistrictBtn);
            this.flowLayoutPanel1.Controls.Add(this.TypeAppealBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(987, 717);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // StatusBtn
            // 
            this.StatusBtn.BackColor = System.Drawing.Color.White;
            this.StatusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StatusBtn.FlatAppearance.BorderSize = 0;
            this.StatusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.StatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBtn.ForeColor = System.Drawing.Color.DimGray;
            this.StatusBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.StatusBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StatusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StatusBtn.IconSize = 70;
            this.StatusBtn.Location = new System.Drawing.Point(3, 3);
            this.StatusBtn.Name = "StatusBtn";
            this.StatusBtn.Size = new System.Drawing.Size(157, 151);
            this.StatusBtn.TabIndex = 11;
            this.StatusBtn.Text = "Статусы";
            this.StatusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StatusBtn.UseVisualStyleBackColor = false;
            this.StatusBtn.Click += new System.EventHandler(this.StatusBtn_Click);
            // 
            // PrioritietBtn
            // 
            this.PrioritietBtn.BackColor = System.Drawing.Color.White;
            this.PrioritietBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PrioritietBtn.FlatAppearance.BorderSize = 0;
            this.PrioritietBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PrioritietBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrioritietBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrioritietBtn.ForeColor = System.Drawing.Color.DimGray;
            this.PrioritietBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.PrioritietBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PrioritietBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrioritietBtn.IconSize = 70;
            this.PrioritietBtn.Location = new System.Drawing.Point(166, 3);
            this.PrioritietBtn.Name = "PrioritietBtn";
            this.PrioritietBtn.Size = new System.Drawing.Size(157, 151);
            this.PrioritietBtn.TabIndex = 12;
            this.PrioritietBtn.Text = "Приоритеты";
            this.PrioritietBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrioritietBtn.UseVisualStyleBackColor = false;
            this.PrioritietBtn.Click += new System.EventHandler(this.PrioritietBtn_Click);
            // 
            // PostBtn
            // 
            this.PostBtn.BackColor = System.Drawing.Color.White;
            this.PostBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PostBtn.FlatAppearance.BorderSize = 0;
            this.PostBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostBtn.ForeColor = System.Drawing.Color.DimGray;
            this.PostBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.PostBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PostBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PostBtn.IconSize = 70;
            this.PostBtn.Location = new System.Drawing.Point(329, 3);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(157, 151);
            this.PostBtn.TabIndex = 13;
            this.PostBtn.Text = "Должности";
            this.PostBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PostBtn.UseVisualStyleBackColor = false;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // MethodTreatmentBtn
            // 
            this.MethodTreatmentBtn.BackColor = System.Drawing.Color.White;
            this.MethodTreatmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MethodTreatmentBtn.FlatAppearance.BorderSize = 0;
            this.MethodTreatmentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MethodTreatmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodTreatmentBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodTreatmentBtn.ForeColor = System.Drawing.Color.DimGray;
            this.MethodTreatmentBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.MethodTreatmentBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MethodTreatmentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MethodTreatmentBtn.IconSize = 70;
            this.MethodTreatmentBtn.Location = new System.Drawing.Point(492, 3);
            this.MethodTreatmentBtn.Name = "MethodTreatmentBtn";
            this.MethodTreatmentBtn.Size = new System.Drawing.Size(157, 151);
            this.MethodTreatmentBtn.TabIndex = 14;
            this.MethodTreatmentBtn.Text = "Методы обращений";
            this.MethodTreatmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MethodTreatmentBtn.UseVisualStyleBackColor = false;
            this.MethodTreatmentBtn.Click += new System.EventHandler(this.MethodTreatmentBtn_Click);
            // 
            // DistrictBtn
            // 
            this.DistrictBtn.BackColor = System.Drawing.Color.White;
            this.DistrictBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DistrictBtn.FlatAppearance.BorderSize = 0;
            this.DistrictBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DistrictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DistrictBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistrictBtn.ForeColor = System.Drawing.Color.DimGray;
            this.DistrictBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.DistrictBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DistrictBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DistrictBtn.IconSize = 70;
            this.DistrictBtn.Location = new System.Drawing.Point(655, 3);
            this.DistrictBtn.Name = "DistrictBtn";
            this.DistrictBtn.Size = new System.Drawing.Size(157, 151);
            this.DistrictBtn.TabIndex = 15;
            this.DistrictBtn.Text = "Районы ";
            this.DistrictBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DistrictBtn.UseVisualStyleBackColor = false;
            this.DistrictBtn.Click += new System.EventHandler(this.DistrictBtn_Click);
            // 
            // TypeAppealBtn
            // 
            this.TypeAppealBtn.BackColor = System.Drawing.Color.White;
            this.TypeAppealBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TypeAppealBtn.FlatAppearance.BorderSize = 0;
            this.TypeAppealBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.TypeAppealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeAppealBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeAppealBtn.ForeColor = System.Drawing.Color.DimGray;
            this.TypeAppealBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.TypeAppealBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TypeAppealBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TypeAppealBtn.IconSize = 70;
            this.TypeAppealBtn.Location = new System.Drawing.Point(818, 3);
            this.TypeAppealBtn.Name = "TypeAppealBtn";
            this.TypeAppealBtn.Size = new System.Drawing.Size(157, 151);
            this.TypeAppealBtn.TabIndex = 16;
            this.TypeAppealBtn.Text = "Типы обращений";
            this.TypeAppealBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TypeAppealBtn.UseVisualStyleBackColor = false;
            this.TypeAppealBtn.Click += new System.EventHandler(this.TypeAppealBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 717);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GuideForm";
            this.Text = "GuideForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton StatusBtn;
        private FontAwesome.Sharp.IconButton PrioritietBtn;
        private FontAwesome.Sharp.IconButton PostBtn;
        private FontAwesome.Sharp.IconButton MethodTreatmentBtn;
        private FontAwesome.Sharp.IconButton DistrictBtn;
        private FontAwesome.Sharp.IconButton TypeAppealBtn;
        private System.Windows.Forms.Timer timer1;
    }
}