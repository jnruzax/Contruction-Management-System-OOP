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
    public partial class add_project : Form
    {
        //create object
        project proj = new project();

        public add_project()
        {
            InitializeComponent();
            CLIENTLOAD();
        }

        private void add_project_Load(object sender, EventArgs e)
        {

        }

        private void txt_cfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_clname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            this.Close(); //close form
        }

        private void txt_save_project_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ptitle.Text == "" || txt_cost.Text == "" || txt_dura.Text == "" || cb_state.Text == "" || cb_state.Text == "")
                {
                    label8.Text = "Please Enter the Above Informations";
                    txt_ptitle.Focus();
                    label8.ForeColor = Color.Red;                   

                }
                else
                {

                    ADDPROJECT(); //call method

                    //show success method
                    MessageBox.Show("Project Added Successfully", "Saved Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear entered data
                    txt_ptitle.Clear();
                    txt_dura.Clear();
                    txt_cost.Clear();
                    cb_clint.ResetText();
                    cb_state.ResetText();
                    label8.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //add project method
        public void ADDPROJECT()
        {
            proj.ptitle = txt_ptitle.Text;
            proj.pstartdate = dt_startdate.Text;
            proj.pdura = txt_dura.Text;
            proj.pcost = txt_cost.Text;
            proj.pstate = cb_state.Text;
            proj.pclient = cb_clint.Text;

            proj.addadd_project_entry();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear entered data
            txt_ptitle.Clear();
            txt_dura.Clear();
            txt_cost.Clear();
            cb_clint.ResetText();
            cb_state.ResetText();
            label8.Text = "";
        }

        //data add to combo method
        public void CLIENTLOAD() { 
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

                    MySqlCommand cmd = new MySqlCommand("select * from client", cn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                        {
                        string clientF_name = dr[1].ToString();
                        string clientL_name = dr[2].ToString();
                        string cname = clientF_name + "" + clientL_name;

                        cb_clint.Items.Add(cname);

                        }
                    dr.Close();
                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        //project title textbox validation
        private void txt_ptitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        //project durations validation
        private void txt_dura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Project Durations with Number of Month, Project Duration Can't Enter with Letter (Enter the Month with Number).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //project cost validation
        private void txt_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Project Cost, Project Cost Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
