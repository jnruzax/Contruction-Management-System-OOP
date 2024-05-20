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
    public partial class add_user : Form
    {
        user usr = new user();
        public add_user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_usrname_TextChanged(object sender, EventArgs e)
        {
            
        }

        //username textbox validate

        private void txt_usrname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Username, Username Can't Enter with Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //clear button code
        private void button1_Click(object sender, EventArgs e)
        {
            //clear Textbox details
            txt_usrname.Clear();
            txt_pass.Clear();
            cb_urole.ResetText();
            cb_usr_typ.ResetText();
        }

        //add user
        private void txt_save_employe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pass.Text == "" || txt_usrname.Text == "" || cb_urole.Text == "" || cb_usr_typ.Text == "")
                {
                    label12.Text = "Please Enter the Above Informations";
                    txt_usrname.Focus();
                    label12.ForeColor = Color.Red;
                }

                else
                {

                    ADDUSER(); //call method

                    //show Succeass message 

                    MessageBox.Show("New User Details Added Successfully !", "SAVED", MessageBoxButtons.OK);

                    //clear Textbox details
                    txt_usrname.Clear();
                    txt_pass.Clear();
                    cb_urole.ResetText();
                    cb_usr_typ.ResetText();
                    label12.Text = "";
                }
            }
            catch (Exception ex)
            {
                //show error message
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        //add user method
        private void ADDUSER()
        {
            usr.usrname = txt_usrname.Text;
            usr.pass = txt_pass.Text;
            usr.usrtype = cb_usr_typ.Text;
            usr.usrrol = int.Parse(cb_urole.Text);

            usr.add_details();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
