using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using WFM.myclass;

namespace WFM
{
    public partial class UC_employee : UserControl
    {
        employee emp = new employee();

        private static UC_employee _obj;
        public static UC_employee Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_employee();
                return _obj;

            }
        }
        public UC_employee()
        {
            InitializeComponent();
            JOBLOAD(); //load jobsnames 
            getemprecord();
        }

        //methods for employee details show
        private void getemprecord()
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

                cn.Open();

                //sql connection
                MySqlCommand cmd = new MySqlCommand("select * from employee", cn);
                MySqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable(); //load datatble

                dt.Load(dr);

                dataGridViewEmp.DataSource = dt; // data gridview
                cn.Close(); // close connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Add Employee button
        private void button2_Click(object sender, EventArgs e)
        {
            //loard add new employee details
            add_employee addemp = new add_employee();
            addemp.Show();
            getemprecord();
        }

        private void srch_empid_TextChanged(object sender, EventArgs e)
        {

        }

        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            if (srch_empid.Text == "")
            {
                MessageBox.Show("Enter the Valid Employee ID", "Enter Details Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SEARCHCLNTDETAILS();
                    getemprecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //add new jobs button
        private void button3_Click(object sender, EventArgs e)
        {
            //loard add job form
            addjob addjob = new addjob();
            addjob.Show();
          
        }

        private void txt_s_fn_TextChanged(object sender, EventArgs e)
        {

        }

        //Search Employee Details
        public void SEARCHCLNTDETAILS()
        {
            
            emp.EIDs = int.Parse(srch_empid.Text);
            emp.Search_employee(); //search employee
            txt_s_efn.Text = emp.efn;
            txt_s_eln.Text = emp.eln;
            txt_s_ephone.Text = emp.etp;
            txt_s_eemail.Text = emp.eem;
            txt_s_eadd.Text = emp.eadrs;
            sc_e_ab.Text = emp.eabout;
            sc_em_job.Text = emp.ejob;
        }

       
        
        //search jobs and show in combobox
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
                    sc_em_job.Items.Add(dr[1].ToString());
                }
                cn.Close(); //close connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Employee details Update Button
        private void btn_update_Click(object sender, EventArgs e)
        {
            UPDATEEMPDETAILS();
            getemprecord();
        }
        //update employee details
        public void UPDATEEMPDETAILS()
        {
            if (txt_s_efn.Text == "" || txt_s_eln.Text == "" || sc_em_job.Text == "" || sc_e_ab.Text == "" || txt_s_ephone.Text == "" || txt_s_eemail.Text == "" || txt_s_eadd.Text == "")
            {
                MessageBox.Show("Enter the Updating Employee Details Correctly !", "Updated Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    emp.Emp_ID = int.Parse(srch_empid.Text);
                    emp.Efnm = txt_s_efn.Text;
                    emp.Elnm = txt_s_eln.Text;
                    emp.Ejb = sc_em_job.Text;
                    emp.Eeml = txt_s_eemail.Text;
                    emp.Ephn = int.Parse(txt_s_ephone.Text);
                    emp.Eadds = txt_s_eadd.Text;
                    emp.Eabut = sc_e_ab.Text;

                    emp.update_empdata();

                    MessageBox.Show("Employee Details Updated Successfully !", "Updated Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //clear All Button
        private void label3_Click(object sender, EventArgs e)
        {
            srch_empid.Clear();
            txt_s_efn.Clear();
            txt_s_eln.Clear();
            sc_em_job.ResetText();
            sc_e_ab.Clear();
            txt_s_eadd.Clear();
            txt_s_ephone.Clear();
            txt_s_eemail.Clear();
            getemprecord();

        }

        //deleted Employee 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DELETE();
                MessageBox.Show("Employee Detail Deleted Successfully !", "Deleted Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear Data
                srch_empid.Clear();
                txt_s_efn.Clear();
                txt_s_eln.Clear();
                sc_em_job.ResetText();
                sc_e_ab.Clear();
                txt_s_eadd.Clear();
                txt_s_ephone.Clear();
                txt_s_eemail.Clear();
                getemprecord(); // refresh the record
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Deleting Method
        public void DELETE()
        {
            emp.deletedid = srch_empid.Text;
            emp.delete_employee();            
        }

        private void dataGridViewEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //data grid view cell click and show details

        private void dataGridViewEmp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            DataGridViewRow row = this.dataGridViewEmp.Rows[rindex];
            srch_empid.Text = row.Cells[0].Value.ToString();
            txt_s_efn.Text = row.Cells[1].Value.ToString();
            txt_s_eln.Text = row.Cells[2].Value.ToString();
            sc_em_job.Text = row.Cells[3].Value.ToString();
            txt_s_eemail.Text = row.Cells[6].Value.ToString();
            txt_s_ephone.Text = row.Cells[7].Value.ToString();
            txt_s_eadd.Text = row.Cells[8].Value.ToString();
            sc_e_ab.Text = row.Cells[9].Value.ToString();
        }
    }
}
