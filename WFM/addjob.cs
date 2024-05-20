using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using WFM.myclass;
using MySql.Data.MySqlClient;


namespace WFM
{
    public partial class addjob : Form
    {
        //object create 
        employee emp = new employee();
        public addjob()
        {
            InitializeComponent();
            getjobrecord();
        }

        //load grideview
        private void getjobrecord()
        {
            //get client recoard
            try
            {
         
                string pass = "";

                //connection string
                string connectionstring = "datasource = localhost; database=wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
                MySqlConnection cn = new MySqlConnection(connectionstring);

                cn.Open();

                //sql connection
                MySqlCommand cmd = new MySqlCommand("select * from jobs", cn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_save_job_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_job.Text == "")
                {
                    label3.Text = "Please Enter the Above Informations";
                    txt_job.Focus();
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    ADDJOB(); // call method
                    getjobrecord(); //refresh the grid        
                    //show message
                         
                    MessageBox.Show("Job is Added Successfully!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear data
                    txt_job.Clear();
                    label3.Text = "";

                }
            }
            catch(Exception ex)
            {
                //error message show
                MessageBox.Show(ex.Message);
            }
        }

        public void ADDJOB()
        {
            emp.jobname = txt_job.Text;

            emp.add_job_entry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear data
            txt_job.Clear();
            label3.Text = "";
        }

        private void txt_job_TextChanged(object sender, EventArgs e)
        {
           
        }

        //job textbox validate
        private void txt_job_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Job Name, Job Name Can't Enter with Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
