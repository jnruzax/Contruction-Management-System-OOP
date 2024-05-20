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
using MySql.Data.MySqlClient;
using WFM.myclass;

namespace WFM
{
    public partial class add_employee : Form
    {
        //create object
        employee employee = new employee();
        
        public add_employee()
        {
            InitializeComponent();
            JOBLOAD();
        }
                        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //save employee details
        private void txt_save_employe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_e_fname.Text == "" || txt_e_lname.Text == "" || txt_e_about.Text == "" || txt_e_add.Text == "" || txt_e_email.Text == "" || txt_e_phone.Text == "")
                {
                    label12.Text = "Please Enter the Above Informations";
                    txt_e_fname.Focus();
                    label12.ForeColor = Color.Red;
                }

                else
                        {

                            ADDEMPLOYEE(); //call method

                            //show Succeass message 

                            MessageBox.Show("New Employee Details Added Successfully !", "SAVED", MessageBoxButtons.OK);

                            //clear entered data 
                            txt_e_fname.Clear();
                            txt_e_lname.Clear();
                            txt_e_email.Clear();
                            txt_e_phone.Clear();
                            cb_e_job.ResetText();
                            txt_e_add.Clear();
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                            txt_e_about.Clear();
                            label12.Text = "";
                        }
            }
            catch (Exception ex)
            {
                //show error message
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear  button code 
            txt_e_fname.Clear();
            txt_e_lname.Clear();
            txt_e_email.Clear();
            txt_e_phone.Clear();
            txt_e_add.Clear();
            cb_e_job.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txt_e_about.Clear();
            label12.Text = "";
        }

        //add employee method
        public void ADDEMPLOYEE()
        {
            string radiovalue = "";
            //Radio Button
            if (radioButton1.Checked)
            {
                radiovalue = "Male";
            }
            else if ( radioButton2.Checked)
            {
                radiovalue = "Female";
            }

            
            employee.fname = txt_e_fname.Text;
            employee.lname = txt_e_lname.Text;
            employee.job = cb_e_job.Text;
            employee.gender = radiovalue;
            employee.dob = dt_e_dob.Text;
            employee.email = txt_e_email.Text;
            employee.phone = txt_e_phone.Text;
            employee.address = txt_e_add.Text;
            employee.about = txt_e_about.Text;
            
            employee.addemployee_entry();
        }

        private void cb_e_job_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_employee_Load(object sender, EventArgs e)
        {
            
        }

        //load the jobs names from database
        public void JOBLOAD()
        {
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

                cn.Open(); // open connection

                MySqlCommand cmd = new MySqlCommand("select * from jobs", cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb_e_job.Items.Add(dr[1].ToString());
                }
                cn.Close(); //close connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           

        }

        //employee first name validation
        private void txt_e_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Employee First Name,  Employee First Name Can't Enter with Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //employee last name validation
        private void txt_e_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Employee Last Name,  Employee Last Name Can't Enter with Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //employee phone number validation
        private void txt_e_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Employee Phone Number,  Employee Phone Number Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
