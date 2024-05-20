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

    public partial class UC_client : UserControl
    {
        //obj
        clients clnt = new clients();

        private static UC_client _obj;
        public static UC_client Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_client();
                return _obj;

            }
        }
        public UC_client()
        {
            InitializeComponent();
            getclientrecord();
        }

        //get client record and show
        public void getclientrecord()
        {
            //get client recoard
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
                MySqlCommand cmd = new MySqlCommand("select * from client", cn);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //click button add client
        private void button2_Click(object sender, EventArgs e)
        {
            //loard add new client form
            add_client add_cl = new add_client();
            add_cl.Show();
            getclientrecord();
        }

        //search button 
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Enter the Valid Client ID", "Enter Details Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SEARCHCLNTDETAILS();
                    getclientrecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void srch_empid_TextChanged(object sender, EventArgs e)
        {

        }

        //search clint data
        public void SEARCHCLNTDETAILS()
        {

            clnt.IDs = int.Parse(txt_search.Text);
            clnt.Search_client(); //search client
            txt_s_fn.Text = clnt.fn;
            txt_s_ln.Text = clnt.ln;
            txt_s_phone.Text = clnt.tp;
            txt_s_email.Text = clnt.em;
            txt_s_add.Text = clnt.adrs;

        }

        //Uptade button click
        private void btn_update_Click(object sender, EventArgs e)
        {
            UPDATEDETAILS();
            getclientrecord();
        }
        
        //update
        public void UPDATEDETAILS()
        {
            if (txt_s_fn.Text == "" || txt_s_ln.Text == "" || txt_s_phone.Text == "" || txt_s_email.Text == "" || txt_s_add.Text == "")
            {
                MessageBox.Show("Enter the Updating Client Details Correctly !", "Updated Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    clnt.cfn = txt_s_fn.Text;
                    clnt.C_ID = int.Parse(txt_search.Text);
                    clnt.cln = txt_s_ln.Text;
                    clnt.cem = txt_s_email.Text;
                    clnt.cph = int.Parse(txt_s_phone.Text);
                    clnt.caddress = txt_s_add.Text;

                    clnt.update_clientdata();
                    MessageBox.Show("Client Details Updated Successfully !", "Updated Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //clear all lable click
        private void label2_Click_1(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_s_fn.Clear();
            txt_s_ln.Clear();
            txt_s_email.Clear();
            txt_s_add.Clear();
            txt_s_phone.Clear();
            getclientrecord();

        }

        //data gridview click and show in textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[rindex];
            txt_search.Text = row.Cells[0].Value.ToString();
            txt_s_fn.Text = row.Cells[1].Value.ToString();
            txt_s_ln.Text = row.Cells[2].Value.ToString();
            txt_s_email.Text = row.Cells[3].Value.ToString();
            txt_s_phone.Text = row.Cells[4].Value.ToString();
            txt_s_add.Text = row.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Delete Button Click
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETECLIENT();
            getclientrecord(); //refresh gridview
            //clear textbox data
            txt_search.Clear();
            txt_s_fn.Clear();
            txt_s_ln.Clear();
            txt_s_email.Clear();
            txt_s_add.Clear();
            txt_s_phone.Clear();
        }

        //delete client details
        public void DELETECLIENT()
        {
            try
            {
                if(txt_search.Text == "")
                {
                    MessageBox.Show("Select the Client to Delete Details", "Selection Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clnt.Deletecid = int.Parse(txt_search.Text);
                    clnt.delete_client();
                    MessageBox.Show("Client Details Deleted Successfully !", "Delected Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getclientrecord(); // refresh gridview
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_client_Load(object sender, EventArgs e)
        {

        }
    }
    
}
