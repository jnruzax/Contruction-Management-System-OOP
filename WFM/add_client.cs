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
    public partial class add_client : Form
    {
        //add object
        clients clint = new clients();



        public add_client()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //form close
        }

        //add client details button
        private void txt_save_employe_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_cfname.Text == "" || txt_clname.Text == "" || txt_cemail.Text == "" || txt_cphone.Text == "" || txt_cadd.Text == "")
                {
                    label4.Text = "Please Enter the Above Informations";
                    txt_cfname.Focus();                                        
                    label4.ForeColor = Color.Red;                    
                }
                else
                {
                    ADDCLIENT(); // call method
                    
                    //show success message
                    MessageBox.Show("New Client Details Added Successfully !", "SAVED", MessageBoxButtons.OK);
                    
                    
                    //clear the entered data 
                    txt_cfname.Clear();
                    txt_clname.Clear();
                    txt_cemail.Clear();
                    txt_cphone.Clear();
                    txt_cadd.Clear();

                    label4.Text = "";
                    this.Close();
                    

                }

            }
            catch (Exception ex)
            {
                //show error message 
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            
        }

        //ASS client method 
        public void ADDCLIENT()
        {
            clint.cfname = txt_cfname.Text;
            clint.clname = txt_clname.Text;
            clint.cemail = txt_cemail.Text;
            clint.cphone = txt_cphone.Text;
            clint.cadd = txt_cadd.Text;

            clint.add_client_entry();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear button code
            txt_cfname.Clear();
            txt_clname.Clear();
            txt_cemail.Clear();
            txt_cphone.Clear();
            txt_cadd.Clear();
            label4.Text = "";
        }

        private void txt_cfname_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_clname_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_cfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_client_Load(object sender, EventArgs e)
        {

        }

        //client first name entered textbox validation
        private void txt_cfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Client First Name,  Client First Name Can't Enter with Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //client last  name entered textbox validation
        private void txt_clname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Client Last Name,  Client Last Name Can't Enter with Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //phone number validation
        private void txt_cphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please entered Valid Phone Number, Phone Number Can't Enter with Letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
