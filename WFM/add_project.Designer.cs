namespace WFM
{
    partial class add_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_project));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_save_project = new System.Windows.Forms.Button();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_dura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ptitle = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_state = new System.Windows.Forms.ComboBox();
            this.cb_clint = new System.Windows.Forms.ComboBox();
            this.dt_startdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(198, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 57;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_save_project
            // 
            this.txt_save_project.BackColor = System.Drawing.Color.Green;
            this.txt_save_project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_save_project.FlatAppearance.BorderSize = 0;
            this.txt_save_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_save_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_save_project.ForeColor = System.Drawing.Color.Transparent;
            this.txt_save_project.Location = new System.Drawing.Point(46, 367);
            this.txt_save_project.Name = "txt_save_project";
            this.txt_save_project.Size = new System.Drawing.Size(121, 33);
            this.txt_save_project.TabIndex = 56;
            this.txt_save_project.Text = "ADD PROJECT";
            this.txt_save_project.UseVisualStyleBackColor = false;
            this.txt_save_project.Click += new System.EventHandler(this.txt_save_project_Click);
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(154, 189);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(173, 20);
            this.txt_cost.TabIndex = 54;
            this.txt_cost.Text = "00";
            this.txt_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cost_KeyPress);
            // 
            // txt_dura
            // 
            this.txt_dura.Location = new System.Drawing.Point(214, 149);
            this.txt_dura.Name = "txt_dura";
            this.txt_dura.Size = new System.Drawing.Size(113, 20);
            this.txt_dura.TabIndex = 53;
            this.txt_dura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dura_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Project States";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Duration (Month)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Start Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Project Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "WFM Constructions - Add Project";
            // 
            // txt_ptitle
            // 
            this.txt_ptitle.Location = new System.Drawing.Point(154, 61);
            this.txt_ptitle.Name = "txt_ptitle";
            this.txt_ptitle.Size = new System.Drawing.Size(173, 20);
            this.txt_ptitle.TabIndex = 51;
            this.txt_ptitle.TextChanged += new System.EventHandler(this.txt_cfname_TextChanged);
            this.txt_ptitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ptitle_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 22);
            this.panel4.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WFM.Properties.Resources.icons8_macos_close_20;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(322, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 22);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Client ";
            // 
            // cb_state
            // 
            this.cb_state.FormattingEnabled = true;
            this.cb_state.Items.AddRange(new object[] {
            "Not_Start",
            "Active",
            "Completed"});
            this.cb_state.Location = new System.Drawing.Point(154, 232);
            this.cb_state.Name = "cb_state";
            this.cb_state.Size = new System.Drawing.Size(173, 21);
            this.cb_state.TabIndex = 61;
            // 
            // cb_clint
            // 
            this.cb_clint.FormattingEnabled = true;
            this.cb_clint.Location = new System.Drawing.Point(154, 278);
            this.cb_clint.Name = "cb_clint";
            this.cb_clint.Size = new System.Drawing.Size(173, 21);
            this.cb_clint.TabIndex = 62;
            // 
            // dt_startdate
            // 
            this.dt_startdate.CustomFormat = "yyyy/MM/dd";
            this.dt_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_startdate.Location = new System.Drawing.Point(153, 106);
            this.dt_startdate.Name = "dt_startdate";
            this.dt_startdate.Size = new System.Drawing.Size(174, 20);
            this.dt_startdate.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 64;
            // 
            // add_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 507);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_startdate);
            this.Controls.Add(this.cb_clint);
            this.Controls.Add(this.cb_state);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_save_project);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_dura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ptitle);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_project";
            this.Load += new System.EventHandler(this.add_project_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txt_save_project;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_dura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ptitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_state;
        private System.Windows.Forms.ComboBox cb_clint;
        private System.Windows.Forms.DateTimePicker dt_startdate;
        private System.Windows.Forms.Label label8;
    }
}