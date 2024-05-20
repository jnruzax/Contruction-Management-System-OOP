using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFM.myclass;
using System.Data;
using MySql.Data.MySqlClient;

namespace WFM
{
    
    public partial class UC_attendance : UserControl
    {
        attendance att = new attendance();

        private static UC_attendance _obj;
        public static UC_attendance Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_attendance();
                return _obj; 

            }
        } 


        public UC_attendance()
        {
            InitializeComponent();
            OPEN_LOAD();
            getattendancerecord();


        }

        //show attendance record
        private void getattendancerecord()
        {
            //get client recoard
            try
            {
                string pass = "";

                //connection string
                string connectionstring = "datasource = localhost; database= wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
                MySqlConnection cn = new MySqlConnection(connectionstring);

                cn.Open();

                //sql connection
                MySqlCommand cmd = new MySqlCommand("select * from attendance Where att_date = '" + System.DateTime.Now.Date.ToString("yyyy/MM/dd") +"'", cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                   

                DataTable dt = new DataTable(); //load datatble

                dt.Load(dr);

                dataGridView1.DataSource = dt; // data gridview
                cn.Close(); // close connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Save Attendan Details
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_employeeid.Text == "")
                {
                    MessageBox.Show("Select the Employee ID", "Employee Addandance", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    lbl_timenow.Text = DateTime.Now.ToString("hh:mm:tt");
                    label3.Text = System.DateTime.Now.Date.ToString("MM/dd/yyyy");
                    SAVE_ATT();
                    getattendancerecord(); // refresh shown data
                    MessageBox.Show("Employee Attendance Added Successfully", "Employee Addandance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_employeeid.ResetText();//clear entered data

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lbl_timenow_Click(object sender, EventArgs e)
        {

        }

        //run start 
        public void OPEN_LOAD()
        {
            //show date time
           lbl_timenow.Text = DateTime.Now.ToString("hh:mm:tt");
           label3.Text = System.DateTime.Now.Date.ToString("MM/dd/yyyy");

            try
            {
                string host = "localhost";
                string db = "wfmconst";
                string port = "3306";
                string user = "root";
                string pass = "";

                //connection string
                string connectionstring = "datasource = " + host + "; database=" + db + "; port=" + port + "; username=" + user + "; passwoard=" + pass + "; SslMode=none; ";
                MySqlConnection cn = new MySqlConnection(connectionstring);
                cn.Open();
                //show employee id in combo box
                MySqlCommand cmd = new MySqlCommand("select * from employee", cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_employeeid.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        //add attendance
        public void SAVE_ATT()
        {
            att.Emid = int.Parse(cb_employeeid.Text);
            att.atttime = DateTime.Now.ToString("HH:mm:tt");
            att.attdate = System.DateTime.Now.Date.ToString("yyyy/MM/dd");

            att.save_attendance();
        }

        private void UC_attendance_Load(object sender, EventArgs e)
        {

        }

        //leave attendance time
        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (cb_employeeid.Text == "")
                    {
                        MessageBox.Show("Select the Employee ID To Update Leave Time", "Employee Leave Time", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        lbl_timenow.Text = DateTime.Now.ToString("hh:mm:tt");
                        label3.Text = System.DateTime.Now.Date.ToString("MM/dd/yyyy");
                        ATT_LEAVETIME();
                        getattendancerecord();//refresh the show data
                        MessageBox.Show("Employee Leaved Successfully", "Employee Leave Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_employeeid.ResetText();//clear entered data
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Update Attendance Leve time Details
        public void ATT_LEAVETIME()
        {
            att.Emp_ID = int.Parse(cb_employeeid.Text);
            att.Lvtime = DateTime.Now.ToString("HH:mm:tt");
            //att.attdate = System.DateTime.Now.Date.ToString("yyyy/MM/dd");

            att.update_leave_time();
        }

        private void cb_employeeid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //click ceel and show data in textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[rindex];
            cb_employeeid.Text = row.Cells[4].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //search button
        private void srch_date_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = "";

                //connection string
                string connectionstring = "datasource = localhost; database= wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
                MySqlConnection cn = new MySqlConnection(connectionstring);

                cn.Open();

                //sql connection
                MySqlCommand cmd = new MySqlCommand("select * from attendance Where att_date = '"+dateTimePicker1.Text+"'", cn);
                MySqlDataReader dr = cmd.ExecuteReader();


                DataTable dt = new DataTable(); //load datatble

                dt.Load(dr);

                dataGridView1.DataSource = dt; // data gridview
                cn.Close(); // close connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
