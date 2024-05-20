namespace WFM
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_cli = new System.Windows.Forms.Button();
            this.btn_pr = new System.Windows.Forms.Button();
            this.btn_att = new System.Windows.Forms.Button();
            this.btn_emp = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_user);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.btn_cli);
            this.panel1.Controls.Add(this.btn_pr);
            this.panel1.Controls.Add(this.btn_att);
            this.panel1.Controls.Add(this.btn_emp);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_user
            // 
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.ForeColor = System.Drawing.Color.Transparent;
            this.btn_user.Image = global::WFM.Properties.Resources.icons8_change_user_26;
            this.btn_user.Location = new System.Drawing.Point(149, 452);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(45, 41);
            this.btn_user.TabIndex = 10;
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 68);
            this.panel5.TabIndex = 9;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WFM.Properties.Resources.icons8_export_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(-2, 447);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(145, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.Transparent;
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Image = global::WFM.Properties.Resources.icons8_business_report_26__1_;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report.Location = new System.Drawing.Point(-2, 399);
            this.btn_report.Name = "btn_report";
            this.btn_report.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_report.Size = new System.Drawing.Size(145, 42);
            this.btn_report.TabIndex = 7;
            this.btn_report.Text = "Reports";
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_cli
            // 
            this.btn_cli.BackColor = System.Drawing.Color.Transparent;
            this.btn_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cli.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cli.ForeColor = System.Drawing.Color.White;
            this.btn_cli.Image = global::WFM.Properties.Resources.icons8_reception_26;
            this.btn_cli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cli.Location = new System.Drawing.Point(-2, 352);
            this.btn_cli.Name = "btn_cli";
            this.btn_cli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_cli.Size = new System.Drawing.Size(145, 42);
            this.btn_cli.TabIndex = 5;
            this.btn_cli.Text = "Clients";
            this.btn_cli.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_cli.UseVisualStyleBackColor = false;
            this.btn_cli.Click += new System.EventHandler(this.btn_cli_Click);
            // 
            // btn_pr
            // 
            this.btn_pr.BackColor = System.Drawing.Color.Transparent;
            this.btn_pr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pr.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pr.ForeColor = System.Drawing.Color.White;
            this.btn_pr.Image = global::WFM.Properties.Resources.icons8_construction_26;
            this.btn_pr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pr.Location = new System.Drawing.Point(-2, 305);
            this.btn_pr.Name = "btn_pr";
            this.btn_pr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_pr.Size = new System.Drawing.Size(145, 42);
            this.btn_pr.TabIndex = 4;
            this.btn_pr.Text = "Projects";
            this.btn_pr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_pr.UseVisualStyleBackColor = false;
            this.btn_pr.Click += new System.EventHandler(this.btn_pr_Click);
            // 
            // btn_att
            // 
            this.btn_att.BackColor = System.Drawing.Color.Transparent;
            this.btn_att.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_att.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_att.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_att.ForeColor = System.Drawing.Color.White;
            this.btn_att.Image = global::WFM.Properties.Resources.icons8_attendance_26;
            this.btn_att.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_att.Location = new System.Drawing.Point(-2, 259);
            this.btn_att.Name = "btn_att";
            this.btn_att.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_att.Size = new System.Drawing.Size(145, 42);
            this.btn_att.TabIndex = 3;
            this.btn_att.Text = "Attendance";
            this.btn_att.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_att.UseVisualStyleBackColor = false;
            this.btn_att.Click += new System.EventHandler(this.btn_att_Click);
            // 
            // btn_emp
            // 
            this.btn_emp.BackColor = System.Drawing.Color.Transparent;
            this.btn_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp.ForeColor = System.Drawing.Color.White;
            this.btn_emp.Image = global::WFM.Properties.Resources.icons8_soldier_man_26;
            this.btn_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_emp.Location = new System.Drawing.Point(-2, 213);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_emp.Size = new System.Drawing.Size(145, 42);
            this.btn_emp.TabIndex = 2;
            this.btn_emp.Text = "Employee";
            this.btn_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_emp.UseVisualStyleBackColor = false;
            this.btn_emp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Orange;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_home.Image = global::WFM.Properties.Resources.icons8_dashboard_26;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.Location = new System.Drawing.Point(-2, 167);
            this.btn_home.Name = "btn_home";
            this.btn_home.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_home.Size = new System.Drawing.Size(145, 42);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.BackColorChanged += new System.EventHandler(this.button1_Click);
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 87);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::WFM.Properties.Resources.LOGO1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 478);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WFM.Properties.Resources.icons8_macos_close_20;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(572, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 22);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 22);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "WFM Constructions";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WFM.Properties.Resources.icons8_macos_minimize_20;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(544, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 22);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WFM.Properties.Resources.sidebarBack;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_cli;
        private System.Windows.Forms.Button btn_pr;
        private System.Windows.Forms.Button btn_att;
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_user;
    }
}