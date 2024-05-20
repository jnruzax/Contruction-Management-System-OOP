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

    public partial class Dashboard : Form
    {
        //database object
        DB db = new DB();
        public Dashboard()
        {
            InitializeComponent();
            StartupDash(); //startup dashboard load
        }

        //employee button
        private void button1_Click(object sender, EventArgs e)
        {
            

            btn_emp.BackColor = Color.Orange; //clicked btn Change Color
      
            //other Button Color clear
            btn_report.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;
            btn_att.BackColor = Color.Transparent;
            btn_pr.BackColor = Color.Transparent;
            btn_cli.BackColor = Color.Transparent;
            btn_user.BackColor = Color.Transparent;

            //Load to UC_Employee control to home
            if (!panel2.Controls.Contains(UC_employee.Obj))
            {
                panel2.Controls.Add(UC_employee.Obj);
                UC_employee.Obj.Dock = DockStyle.Fill;
                UC_employee.Obj.BringToFront();
            }
            else
            {
                UC_employee.Obj.BringToFront();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //application close
            Application.Exit();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Application Minimize
            this.WindowState = FormWindowState.Minimized;
            
        }

        //home button
        private void btn_home_Click_1(object sender, EventArgs e)
        {
            //refresh data
            UC_Home uchome = new UC_Home();
            uchome.OPEN_LOAD();
            {
                btn_home.BackColor = Color.Orange;

                //other Button Color clear
                btn_report.BackColor = Color.Transparent;
                btn_emp.BackColor = Color.Transparent;
                btn_att.BackColor = Color.Transparent;
                btn_pr.BackColor = Color.Transparent;
                btn_cli.BackColor = Color.Transparent;
                btn_user.BackColor = Color.Transparent;

                UC_Home.Obj.OPEN_LOAD();
                //Load to UC_Employee control to home
                if (!panel2.Controls.Contains(UC_Home.Obj))
                {
                    
                    panel2.Controls.Add(UC_Home.Obj);
                    UC_Home.Obj.Dock = DockStyle.Fill;
                    UC_Home.Obj.BringToFront();
                }
                else
                {
                    UC_Home.Obj.BringToFront();

                }
            }

        }

        //Logout button
        private void button1_Click_2(object sender, EventArgs e)
        {
            {
                /*
                this.Close(); //this window close 
                Form1 login = new Form1();
                login.Show(); // login form show
                */
                Application.Exit();
            }
        }
        //attendance button
        private void btn_att_Click(object sender, EventArgs e)
        {
            btn_att.BackColor = Color.Orange; //clicked btn Change Color

            //other Button Color clear
            btn_report.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;
            btn_pr.BackColor = Color.Transparent;
            btn_cli.BackColor = Color.Transparent;
            btn_user.BackColor = Color.Transparent;

            //Load to UC_Attendance control to home
            if (!panel2.Controls.Contains(UC_attendance.Obj))
            {
                panel2.Controls.Add(UC_attendance.Obj);
                UC_attendance.Obj.Dock = DockStyle.Fill;
                UC_attendance.Obj.BringToFront();
            }
            else
            {
                UC_attendance.Obj.BringToFront();

            }
        }
        //project button
        private void btn_pr_Click(object sender, EventArgs e)
        {
            btn_pr.BackColor = Color.Orange; //clicked btn Change Color

            //other Button Color clear
            btn_report.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_att.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;
            btn_user.BackColor = Color.Transparent;
            btn_cli.BackColor = Color.Transparent;

            //Load to UC_Project control to home
            if (!panel2.Controls.Contains(UC_project.Obj))
            {
                panel2.Controls.Add(UC_project.Obj);
                UC_project.Obj.Dock = DockStyle.Fill;
                UC_project.Obj.BringToFront();
            }
            else
            {
                UC_project.Obj.BringToFront();

            }
        }
        //client button
        private void btn_cli_Click(object sender, EventArgs e)
        {
            btn_cli.BackColor = Color.Orange; //clicked btn Change Color

            //other Button Color clear
            btn_report.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_att.BackColor = Color.Transparent;
            btn_user.BackColor = Color.Transparent;
            btn_pr.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;

            //Load to UC_client control to home
            if (!panel2.Controls.Contains(UC_client.Obj))
            {
                panel2.Controls.Add(UC_client.Obj);
                UC_client.Obj.Dock = DockStyle.Fill;
                UC_client.Obj.BringToFront();
            }
            else
            {
                UC_client.Obj.BringToFront();

            }
        }
        //Report button click
        private void button4_Click(object sender, EventArgs e)
        {
           btn_report.BackColor = Color.Orange; //clicked btn Change Color

            //other Button Color clear
            btn_cli.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_att.BackColor = Color.Transparent;
            btn_user.BackColor = Color.Transparent;
            btn_pr.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;

            //Load to UC_client control to home
            if (!panel2.Controls.Contains(UC_report.Obj))
            {
                panel2.Controls.Add(UC_report.Obj);
                UC_report.Obj.Dock = DockStyle.Fill;
                UC_report.Obj.BringToFront();
            }
            else
            {
                UC_report.Obj.BringToFront();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Form1.T_Role;
            label3.Text = Form1.T_username;
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = Form1.T_Role;
            label3.Text = Form1.T_username;
            //hide the user management part for Manager 
            if(label2.Text == "Admin")
            {
                btn_user.Visible = true;
            }
            else
            {
                btn_user.Visible = false;
            }
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
           
        }

        public void StartupDash()
        {

            btn_home.BackColor = Color.Orange;

            //other Button Color clear
            btn_report.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_att.BackColor = Color.Transparent;
            btn_pr.BackColor = Color.Transparent;
            btn_cli.BackColor = Color.Transparent;

            //Load to UC_Employee control to home
            if (!panel2.Controls.Contains(UC_Home.Obj))
            {
                
                panel2.Controls.Add(UC_Home.Obj);
                UC_Home.Obj.Dock = DockStyle.Fill;
                UC_Home.Obj.BringToFront();

            }
            else
            {
                UC_Home.Obj.BringToFront();

            }
        }

        //user management button
        private void button4_Click_1(object sender, EventArgs e)
        {
           
            btn_user.BackColor = Color.Orange;//clicked btn Change Color
            
            //other Button Color clear
            btn_report.BackColor = Color.Transparent;
            btn_cli.BackColor = Color.Transparent;
            btn_emp.BackColor = Color.Transparent;
            btn_att.BackColor = Color.Transparent;
            btn_pr.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;

            //Load to UC_client control to home
            if (!panel2.Controls.Contains(UC_User.Obj))
            {
                panel2.Controls.Add(UC_User.Obj);
                UC_User.Obj.Dock = DockStyle.Fill;
                UC_User.Obj.BringToFront();
            }
            else
            {
                UC_User.Obj.BringToFront();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
