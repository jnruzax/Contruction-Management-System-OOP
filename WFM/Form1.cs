using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using WFM.myclass;

namespace WFM
{
    public partial class Form1 : Form
    {
        
        
       DB db = new DB();
       login log = new login();

        //Transfering Data to another form

        public static string T_Role;
        public static string T_username;

        public static object T_role { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //login button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //check Empty
                if (txt_username.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("Please Enter the Username & Passwoard !", "Login Details Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_username.Clear(); // Clear entered data
                    txt_pass.Clear();
                }
                else
                {
                    //not empty
                    log.user_name = txt_username.Text;
                    log.user_password = txt_pass.Text;
                    bool verify = log.user_validation();

                    int roles = log.user_role;

                    if (verify)
                    {
                        this.Hide();     //form hide                   
                        Dashboard dsh = new Dashboard();
                        dsh.Show(); //show dashboard

                        //data save in veriable
                        T_username = log.user_name;

                        //Roles
                        if (roles == 1)
                                {
                                    T_Role = "Admin";
                            
                                }
                                else if(roles == 2){
                                    T_Role = "Manager";
                                }
                                
                                else
                                {
                                    T_Role = "User";
                                }                       
                    }

                    else
                    {
                        MessageBox.Show("Please Enter the Valid Username & Passwoard !", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_username.Clear(); // Clear entered data
                        txt_pass.Clear();
                        txt_username.Focus();
                    }

                }                   

            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//end login button

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f_pass = new forgot();
            this.Hide(); //hide form1
            f_pass.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clear textbox details
            txt_username.Clear();
            txt_pass.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //usaername validation
        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Username Details,  Username Can't Enter with Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
