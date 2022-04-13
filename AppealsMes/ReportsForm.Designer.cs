
namespace AppealsMes
{
    partial class ReportsForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlButton1 = new WindowsFormsApp2.UserControlButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.userControlButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 547);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // userControlButton1
            // 
            this.userControlButton1.BackColor = System.Drawing.Color.Tomato;
            this.userControlButton1.BackgroundColor = System.Drawing.Color.Tomato;
            this.userControlButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.userControlButton1.BorderRadius = 40;
            this.userControlButton1.BorderSize = 0;
            this.userControlButton1.FlatAppearance.BorderSize = 0;
            this.userControlButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userControlButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlButton1.ForeColor = System.Drawing.Color.White;
            this.userControlButton1.Location = new System.Drawing.Point(3, 3);
            this.userControlButton1.Name = "userControlButton1";
            this.userControlButton1.Size = new System.Drawing.Size(137, 95);
            this.userControlButton1.TabIndex = 0;
            this.userControlButton1.Text = "Обращения потребителей за отчетный период (.xlsx)";
            this.userControlButton1.TextColor = System.Drawing.Color.White;
            this.userControlButton1.UseVisualStyleBackColor = false;
            this.userControlButton1.Click += new System.EventHandler(this.userControlButton1_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 547);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private WindowsFormsApp2.UserControlButton userControlButton1;
    }
}