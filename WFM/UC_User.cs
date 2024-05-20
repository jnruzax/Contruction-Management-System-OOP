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
    
    public partial class UC_User : UserControl
    {
        user usr = new user();

        private static UC_User _obj;
        public static UC_User Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_User();
                return _obj;

            }
        }

        public UC_User()
        {

            InitializeComponent();
            getuserrecord();
        }

        //load user details
        private void getuserrecord()
        {
            try
            {
                string pass = "";

                //connection string
                string connectionstring = "datasource = localhost; database=wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
                MySqlConnection cn = new MySqlConnection(connectionstring);

                cn.Open();

                //sql connection
                MySqlCommand cmd = new MySqlCommand("select * from user", cn);
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

        private void UC_User_Load(object sender, EventArgs e)
        {

        }
        //search button
        private void btn_search_Click(object sender, EventArgs e)
        {

            if (txt_userid.Text == "")
            {
                MessageBox.Show("Enter the Valid User ID", "Enter Details Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SEARCUSERDETAILS();
                    getuserrecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //search User details
        public void SEARCUSERDETAILS()
        {
            usr.IDs = int.Parse(txt_userid.Text);

            usr.Search_user();

            txt_un.Text = usr.un;
            txt_pw.Text = usr.pw;
            txt_ut.Text = usr.ut;
            cb_ur.Text = usr.ur;
        }

        //clear all button
        private void label2_Click(object sender, EventArgs e)
        {
            //clear textboxed details
            txt_userid.Clear();

            txt_un.Clear();
            txt_pw.Clear();
            txt_ut.Clear();
            cb_ur.ResetText();
        }

        //deleted 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETEUSER();
            getuserrecord();
            //clear textbox data

            txt_un.Clear();
            txt_pw.Clear();
            txt_ut.Clear();
            cb_ur.ResetText();
        }

        //Deleted User Method
        public void DELETEUSER()
        {
            try
            {
                if (txt_userid.Text == "")
                {
                    MessageBox.Show("Select the User to Delete Details", "Selection Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    usr.Deleteuid = int.Parse(txt_userid.Text);
                    usr.delete_user();
                    MessageBox.Show("User Details Deleted Successfully !", "Delected Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //user update details button
        private void btn_update_Click(object sender, EventArgs e)
        {

            UPDATEUSERDETAILS();
            getuserrecord();
        }

        //update user details
        public void UPDATEUSERDETAILS()
        {
            if (txt_userid.Text == "" || txt_un.Text == "" || txt_pw.Text == "" || txt_ut.Text == "" || cb_ur.Text == "")
            {
                MessageBox.Show("Enter the Updating User Details Correctly !", "Updated Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    usr.U_ID = int.Parse(txt_userid.Text);
                    usr.usrnam = txt_un.Text;
                    usr.pwd = txt_pw.Text;
                    usr.usrtyp = txt_ut.Text;
                    usr.url = int.Parse(cb_ur.Text);

                    usr.update_userdata();
                    MessageBox.Show("User Details Updated Successfully !", "Updated Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //click the cell and show details in textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[rindex];
            txt_userid.Text = row.Cells[0].Value.ToString();
            txt_un.Text = row.Cells[1].Value.ToString();
            txt_pw.Text = row.Cells[2].Value.ToString();
            txt_ut.Text = row.Cells[3].Value.ToString();
            cb_ur.Text = row.Cells[4].Value.ToString();
        }

        //open add user form
        private void btn_useradd_Click(object sender, EventArgs e)
        {
            add_user addusr = new add_user();

            addusr.Show();
            getuserrecord();

        }
    }
    
}
