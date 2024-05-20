namespace WFM
{
    partial class add_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_client));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_save_employe = new System.Windows.Forms.Button();
            this.txt_cadd = new System.Windows.Forms.TextBox();
            this.txt_cemail = new System.Windows.Forms.TextBox();
            this.txt_cphone = new System.Windows.Forms.TextBox();
            this.txt_clname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cfname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(198, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 44;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_save_employe
            // 
            this.txt_save_employe.BackColor = System.Drawing.Color.Green;
            this.txt_save_employe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_save_employe.FlatAppearance.BorderSize = 0;
            this.txt_save_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_save_employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_save_employe.ForeColor = System.Drawing.Color.Transparent;
            this.txt_save_employe.Location = new System.Drawing.Point(46, 267);
            this.txt_save_employe.Name = "txt_save_employe";
            this.txt_save_employe.Size = new System.Drawing.Size(121, 33);
            this.txt_save_employe.TabIndex = 43;
            this.txt_save_employe.Text = "ADD CLIENT";
            this.txt_save_employe.UseVisualStyleBackColor = false;
            this.txt_save_employe.Click += new System.EventHandler(this.txt_save_employe_Click);
            // 
            // txt_cadd
            // 
            this.txt_cadd.Location = new System.Drawing.Point(145, 203);
            this.txt_cadd.Name = "txt_cadd";
            this.txt_cadd.Size = new System.Drawing.Size(174, 20);
            this.txt_cadd.TabIndex = 37;
            // 
            // txt_cemail
            // 
            this.txt_cemail.Location = new System.Drawing.Point(145, 166);
            this.txt_cemail.Name = "txt_cemail";
            this.txt_cemail.Size = new System.Drawing.Size(174, 20);
            this.txt_cemail.TabIndex = 36;
            // 
            // txt_cphone
            // 
            this.txt_cphone.Location = new System.Drawing.Point(173, 127);
            this.txt_cphone.Name = "txt_cphone";
            this.txt_cphone.Size = new System.Drawing.Size(146, 20);
            this.txt_cphone.TabIndex = 35;
            this.txt_cphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cphone_KeyPress);
            // 
            // txt_clname
            // 
            this.txt_clname.Location = new System.Drawing.Point(145, 87);
            this.txt_clname.Name = "txt_clname";
            this.txt_clname.Size = new System.Drawing.Size(174, 20);
            this.txt_clname.TabIndex = 33;
            this.txt_clname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clname_KeyPress);
            this.txt_clname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_clname_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "WFM Constructions - Add Client";
            // 
            // txt_cfname
            // 
            this.txt_cfname.BackColor = System.Drawing.Color.White;
            this.txt_cfname.Location = new System.Drawing.Point(145, 54);
            this.txt_cfname.Name = "txt_cfname";
            this.txt_cfname.Size = new System.Drawing.Size(174, 20);
            this.txt_cfname.TabIndex = 32;
            this.txt_cfname.TextChanged += new System.EventHandler(this.txt_cfname_TextChanged);
            this.txt_cfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cfname_KeyPress);
            this.txt_cfname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_cfname_Validating);
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
            this.panel4.TabIndex = 24;
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
            this.label4.Location = new System.Drawing.Point(43, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 45;
            // 
            // add_client
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(350, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_save_employe);
            this.Controls.Add(this.txt_cadd);
            this.Controls.Add(this.txt_cemail);
            this.Controls.Add(this.txt_cphone);
            this.Controls.Add(this.txt_clname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cfname);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_client";
            this.Load += new System.EventHandler(this.add_client_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txt_save_employe;
        private System.Windows.Forms.TextBox txt_cadd;
        private System.Windows.Forms.TextBox txt_cemail;
        private System.Windows.Forms.TextBox txt_cphone;
        private System.Windows.Forms.TextBox txt_clname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_cfname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
    }
}