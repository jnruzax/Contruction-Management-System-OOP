namespace WFM
{
    partial class add_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_employee));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_e_fname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_e_phone = new System.Windows.Forms.TextBox();
            this.txt_e_email = new System.Windows.Forms.TextBox();
            this.txt_e_add = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_e_about = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_e_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_save_employe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_e_lname = new System.Windows.Forms.TextBox();
            this.cb_e_job = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "WFM Constructions - ADD Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "About";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_e_fname
            // 
            this.txt_e_fname.Location = new System.Drawing.Point(144, 52);
            this.txt_e_fname.Name = "txt_e_fname";
            this.txt_e_fname.Size = new System.Drawing.Size(174, 20);
            this.txt_e_fname.TabIndex = 11;
            this.txt_e_fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_e_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_e_fname_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gender";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_e_phone
            // 
            this.txt_e_phone.Location = new System.Drawing.Point(172, 292);
            this.txt_e_phone.Name = "txt_e_phone";
            this.txt_e_phone.Size = new System.Drawing.Size(146, 20);
            this.txt_e_phone.TabIndex = 14;
            this.txt_e_phone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt_e_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_e_phone_KeyPress);
            // 
            // txt_e_email
            // 
            this.txt_e_email.Location = new System.Drawing.Point(144, 331);
            this.txt_e_email.Name = "txt_e_email";
            this.txt_e_email.Size = new System.Drawing.Size(174, 20);
            this.txt_e_email.TabIndex = 15;
            this.txt_e_email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_e_add
            // 
            this.txt_e_add.Location = new System.Drawing.Point(144, 368);
            this.txt_e_add.Name = "txt_e_add";
            this.txt_e_add.Size = new System.Drawing.Size(174, 20);
            this.txt_e_add.TabIndex = 16;
            this.txt_e_add.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(144, 255);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(221, 255);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 20);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_e_about
            // 
            this.txt_e_about.AccessibleDescription = "txt_e_about";
            this.txt_e_about.Location = new System.Drawing.Point(144, 193);
            this.txt_e_about.Name = "txt_e_about";
            this.txt_e_about.Size = new System.Drawing.Size(174, 56);
            this.txt_e_about.TabIndex = 19;
            this.txt_e_about.Text = "";
            this.txt_e_about.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "DOB";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dt_e_dob
            // 
            this.dt_e_dob.CustomFormat = "yyyy/MM/dd";
            this.dt_e_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_e_dob.Location = new System.Drawing.Point(144, 153);
            this.dt_e_dob.Name = "dt_e_dob";
            this.dt_e_dob.Size = new System.Drawing.Size(174, 20);
            this.dt_e_dob.TabIndex = 21;
            this.dt_e_dob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_save_employe
            // 
            this.txt_save_employe.BackColor = System.Drawing.Color.Green;
            this.txt_save_employe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_save_employe.FlatAppearance.BorderSize = 0;
            this.txt_save_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_save_employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_save_employe.ForeColor = System.Drawing.Color.Transparent;
            this.txt_save_employe.Location = new System.Drawing.Point(45, 444);
            this.txt_save_employe.Name = "txt_save_employe";
            this.txt_save_employe.Size = new System.Drawing.Size(121, 33);
            this.txt_save_employe.TabIndex = 22;
            this.txt_save_employe.Text = "ADD EMPPLOYEE";
            this.txt_save_employe.UseVisualStyleBackColor = false;
            this.txt_save_employe.Click += new System.EventHandler(this.txt_save_employe_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(197, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Job";
            // 
            // txt_e_lname
            // 
            this.txt_e_lname.Location = new System.Drawing.Point(144, 85);
            this.txt_e_lname.Name = "txt_e_lname";
            this.txt_e_lname.Size = new System.Drawing.Size(174, 20);
            this.txt_e_lname.TabIndex = 12;
            this.txt_e_lname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_e_lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_e_lname_KeyPress);
            // 
            // cb_e_job
            // 
            this.cb_e_job.FormattingEnabled = true;
            this.cb_e_job.Location = new System.Drawing.Point(144, 120);
            this.cb_e_job.Name = "cb_e_job";
            this.cb_e_job.Size = new System.Drawing.Size(174, 21);
            this.cb_e_job.TabIndex = 25;
            this.cb_e_job.SelectedIndexChanged += new System.EventHandler(this.cb_e_job_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 28;
            // 
            // add_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(350, 520);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_e_job);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_save_employe);
            this.Controls.Add(this.dt_e_dob);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_e_about);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_e_add);
            this.Controls.Add(this.txt_e_email);
            this.Controls.Add(this.txt_e_phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_e_lname);
            this.Controls.Add(this.txt_e_fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_employee";
            this.Load += new System.EventHandler(this.add_employee_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_e_fname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_e_phone;
        private System.Windows.Forms.TextBox txt_e_email;
        private System.Windows.Forms.TextBox txt_e_add;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RichTextBox txt_e_about;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_e_dob;
        private System.Windows.Forms.Button txt_save_employe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_e_lname;
        private System.Windows.Forms.ComboBox cb_e_job;
        private System.Windows.Forms.Label label12;
    }
}