using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using WFM.myclass;

namespace WFM
{
    public partial class UC_project : UserControl
    {
        //obj
        project proj = new project();

        private static UC_project _obj;
        public static UC_project Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_project();
                return _obj;

            }
        }
        public UC_project()
        {
            InitializeComponent();
            getprojectrecord();
        }

        //get Project record and show
        public void getprojectrecord()
        {

            //get project recoard
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
                MySqlCommand cmd = new MySqlCommand("select * from projects", cn);
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
            //load add new project form
            add_project add_pro = new add_project();
            add_pro.Show();
            getprojectrecord();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //load payment form
            addpayment addpay = new addpayment();
            addpay.Show();
        }

        //clear all btn 
        private void clear_all_Click(object sender, EventArgs e)
        {
            txt_project_cost.Clear();
            txt_project_duration.Clear();
            txt_project_title.Clear();
            cb_project_States.ResetText();
            srch_proname.Clear();
            getprojectrecord();

        }

        //project search button
        private void button1_Click(object sender, EventArgs e)
        {
            if(srch_proname.Text == "")
            {
                MessageBox.Show("Enter the Valid Project ID", "Enter Details Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SEARCHPROJECTDETAILS();
                    getprojectrecord();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //search data to textbox
        public void SEARCHPROJECTDETAILS()
        {
            proj.PID = int.Parse(srch_proname.Text);
            proj.project_search(); //project search

            txt_project_title.Text = proj.ppt;
            txt_project_duration.Text = proj.ppd;
            txt_project_cost.Text = proj.ppa;
            cb_project_States.Text = proj.pps;
         }

        //delete button
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETECLIENT();
            //clear 
            getprojectrecord(); //refresh 
            txt_project_cost.Clear();
            txt_project_duration.Clear();
            txt_project_title.Clear();
            cb_project_States.ResetText();
            srch_proname.Clear();
        }

        //delete
        public void DELETECLIENT()
        {
            try
            {
                if (srch_proname.Text == "")
                {
                    MessageBox.Show("Select the Project to Delete Details", "Selection Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    proj.deletedPid = int.Parse(srch_proname.Text);
                    proj.Project_details_delete();
                    MessageBox.Show("Project Details Deleted Successfully !", "Delected Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getprojectrecord(); // refresh gridview
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //update button
        private void btn_update_Click(object sender, EventArgs e)
        {
            UPDATEDETAILS();

            //clear textbox details
            txt_project_cost.Clear();
            txt_project_duration.Clear();
            txt_project_title.Clear();
            cb_project_States.ResetText();
            srch_proname.Clear();

            getprojectrecord(); //refresh details
        }

        //update details
        public void UPDATEDETAILS()
        {
            if (srch_proname.Text == "" || txt_project_title.Text == "" || txt_project_duration.Text == "" || txt_project_cost.Text == "" || cb_project_States.Text == "")
            {
                MessageBox.Show("Enter the Updating Project Details Correctly !", "Updated Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    proj.PUID = int.Parse(srch_proname.Text);
                    proj.Ptitles = txt_project_title.Text;
                    proj.produra = int.Parse(txt_project_duration.Text);
                    proj.procost = int.Parse(txt_project_cost.Text);
                    proj.pstates = cb_project_States.Text;
                   
                    proj.update_projectdata();
                    MessageBox.Show("Project Details Updated Successfully !", "Updated Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //data gridview click and show in textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[rindex];
            srch_proname.Text = row.Cells[0].Value.ToString();
            txt_project_title.Text = row.Cells[1].Value.ToString();
            txt_project_duration.Text = row.Cells[3].Value.ToString();
            txt_project_cost.Text = row.Cells[4].Value.ToString();
            cb_project_States.Text = row.Cells[5].Value.ToString();
        }
    }
}
