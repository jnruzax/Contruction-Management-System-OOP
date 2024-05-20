namespace WFM
{
    partial class UC_report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.profit = new System.Windows.Forms.Label();
            this.atte = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.client);
            this.panel1.Controls.Add(this.project);
            this.panel1.Controls.Add(this.atte);
            this.panel1.Controls.Add(this.profit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 50);
            this.panel1.TabIndex = 0;
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profit.ForeColor = System.Drawing.Color.White;
            this.profit.Location = new System.Drawing.Point(79, 14);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(84, 24);
            this.profit.TabIndex = 0;
            this.profit.Text = "PROFIT";
            this.profit.Click += new System.EventHandler(this.profit_Click);
            // 
            // atte
            // 
            this.atte.AutoSize = true;
            this.atte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atte.ForeColor = System.Drawing.Color.White;
            this.atte.Location = new System.Drawing.Point(169, 14);
            this.atte.Name = "atte";
            this.atte.Size = new System.Drawing.Size(150, 24);
            this.atte.TabIndex = 1;
            this.atte.Text = "ATTENDANCE";
            this.atte.Click += new System.EventHandler(this.atte_Click);
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project.ForeColor = System.Drawing.Color.White;
            this.project.Location = new System.Drawing.Point(325, 14);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(104, 24);
            this.project.TabIndex = 2;
            this.project.Text = "PROJECT";
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.ForeColor = System.Drawing.Color.White;
            this.client.Location = new System.Drawing.Point(435, 14);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(82, 24);
            this.client.TabIndex = 3;
            this.client.Text = "CLIENT";
            this.client.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 428);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UC_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_report";
            this.Size = new System.Drawing.Size(600, 478);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.Label atte;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.Panel panel2;
    }
}
