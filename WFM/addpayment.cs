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
    public partial class addpayment : Form
    {
        payment pay = new payment();

        public addpayment()
        {
            InitializeComponent();
            PROJECTLOAD(); // call method

            //show time and Date
            datelbl.Text = DateTime.Now.ToString("hh:mm:tt");
            time_labl.Text = System.DateTime.Now.Date.ToString("MM/dd/yyyy");

        }

        //add_payment btn
        private void btn_payment_Click(object sender, EventArgs e)
        {
            int copyamount;
            copyamount = Convert.ToInt32(txt_amount.Text);

            //checking code with try catch
            try
            {
                //check empty
                if (txt_amount.Text == "" || cb_project.Text == "" || txt_clint_fm_pro.Text =="" )
                {
                    label8.Text = "Please Enter the Above Informations";
                    txt_amount.Focus();
                    label8.ForeColor = Color.Red;
                }
                else
                {

                    ADDPAYMENT();
                    //show success message
                    MessageBox.Show("New Payment Details Added Successfully !", "SAVED", MessageBoxButtons.OK);

                    //fild auto now paid amount 
                    txt_paidd_today.Text = Convert.ToString(copyamount);

                    label8.Text = ""; 

                
                    /*--------------------------------------------------------------------------------------*/
                    /*-----------------------Show Full Paid Price for Project------------------------*/
                    
                    //Connection            
                    string pass = "";
                    //connection string
                    string connectionstring = "datasource = localhost; database= wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";

                    MySqlConnection con = new MySqlConnection(connectionstring);

                    /*--------------------------------------------------------------------------------------------*/
                   
                    con.Open(); //open connection
                     //Total Paid

                    var totalprofitProject = "SELECT SUM(pay_amount) FROM payment WHERE project = '"+cb_project.Text+"' ";
                    using (var cmdt = new MySqlCommand(totalprofitProject, con))
                    {
                        txt_full_paid.Text = cmdt.ExecuteScalar().ToString(); // show paid Price
                    }
                    con.Close(); //close connection

                    /*--------------------------------------------------------------------------------------------*/
                    /*----------------------------------------Calculate More Paid Price---------------------*/

                    //more paid = project cost - paid full cost
                    int More_paid = int.Parse(txt_project_cost.Text) - int.Parse(txt_full_paid.Text);

                    //check More paid prices 
                    if(More_paid >0)
                    {
                        txt_more_paid.Text = Convert.ToString(More_paid);
                    }
                    else
                    {
                        txt_more_paid.Text = "00";
                    }
                    

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        //add payement
        public void ADDPAYMENT()
        {
            
            pay.date = dt_pick.Text;

            pay.amount = txt_amount.Text;
            pay.clintname = txt_clint_fm_pro.Text;
            pay.project = cb_project.Text;

            pay.addpayment_entry();
            
        }

        //load project details to combobox
        public void PROJECTLOAD()
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

                MySqlCommand cmd = new MySqlCommand("select * from projects", cn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {    
                    cb_project.Items.Add(dr[1].ToString());
                                                        
                }
                
                cn.Close();
                
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

        //select index change combvobox
        private void cb_project_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                string pass = "";

                //connection string
                string connectionstring = "datasource = localhost; database=wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
                MySqlConnection cn = new MySqlConnection(connectionstring);
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from projects Where p_title = '" + cb_project.Text+"'", cn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //cb_project.Items.Add(dr[1].ToString());

                    string clientnameforproject = (string)dr["client"].ToString();
                    txt_clint_fm_pro.Text = clientnameforproject;

                    string ProjectCostFull = (string)dr["p_cost"].ToString();
                    txt_project_cost.Text = ProjectCostFull;

                }

                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //clear txtbox data
        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            txt_amount.Clear();
            txt_clint_fm_pro.Clear();
            txt_paidd_today.Clear();
            cb_project.ResetText();
            txt_full_paid.Clear();
            txt_more_paid.Clear();
            txt_project_cost.Clear();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        //Print Button
        private void btn_print_Click(object sender, EventArgs e)
        {

            
            /*
            label8.Text = "";
            txt_amount.Clear();
            txt_clint_fm_pro.Clear();
            txt_paidd_today.Clear();
            cb_project.ResetText();
            txt_full_paid.Clear();
            txt_more_paid.Clear();
            txt_project_cost.Clear();
            */
        }

        private void cb_client_TextChanged(object sender, EventArgs e)
        {


        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }
        private void txt_paidd_today_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_full_paid_TextChanged(object sender, EventArgs e)
        {

        }
        //Amount Text Box
        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Amount, Amount Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //paid amount text box validation
        private void txt_paidd_today_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Amount, Amount Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //paid full price text box validation
        private void txt_full_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Price, Price Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //project cost validation
        private void txt_project_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Cost, Cost Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //more price validation
        private void txt_more_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Price, Price Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
