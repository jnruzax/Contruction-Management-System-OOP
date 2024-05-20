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
    public partial class UC_Home : UserControl
    {
        private static UC_Home _obj;
        public static UC_Home Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_Home();
                return _obj;

            }
        }
        public UC_Home()
        {
            InitializeComponent();
            OPEN_LOAD(); // loading open 
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        //check project dtails clck
        private void button1_Click(object sender, EventArgs e)
        {

            //Connection            
            string pass = "";
            //connection string
            string connectionstring = "datasource = localhost; database= wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
            MySqlConnection con = new MySqlConnection(connectionstring);

            /*--------------------------------------------------------------------------------------------*/

            con.Open();//start connection
             //Complete projects
            string totalproQuery = "SELECT COUNT(*) FROM projects WHERE p_startdate BETWEEN '" + dateTimePicker1.Text+ "' AND '" + dateTimePicker2.Text + "' AND (p_state='Completed') ";
            
            MySqlCommand cmd = new MySqlCommand(totalproQuery, con);
            
            MySqlDataReader dr = cmd.ExecuteReader();

            int countcomp = 0;
            while (dr.Read())
            {
                countcomp = dr.GetInt32(0);
            }
           label14.Text = "" + countcomp + ""; // show Total Employee Dashboard
            con.Close(); // close connection

            /*--------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------*/


            con.Open(); //start Connection
            //active projects
            string totalActQuery = "SELECT COUNT(*) FROM projects WHERE p_startdate BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND (p_state='Active') ";

            MySqlCommand cmdAct = new MySqlCommand(totalActQuery, con);

            MySqlDataReader drAct = cmdAct.ExecuteReader();

            int countAct = 0;
            while (drAct.Read())
            {
                countAct = drAct.GetInt32(0);
            }

            label13.Text = "" + countAct + ""; 


            con.Close(); // close connection

            /*--------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------*/


            con.Open(); //start Connection
            //Not active projects
            string NotStart = "SELECT COUNT(*) FROM projects WHERE p_startdate BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND (p_state='Not_Start') ";

            MySqlCommand cmdNotAct = new MySqlCommand(NotStart, con);

            MySqlDataReader drNotAct = cmdNotAct.ExecuteReader();

            int countNotAct = 0;
            while (drNotAct.Read())
            {
                countNotAct = drNotAct.GetInt32(0);
            }

            label15.Text = "" + countNotAct + "";


            con.Close(); // close connection
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void lbl_day_Click(object sender, EventArgs e)
        {

        }

        public void OPEN_LOAD()
        {
            //Date and Time show;

            time.Text = DateTime.Now.ToString("hh:mm:tt");
            lbl_day.Text = System.DateTime.Now.Date.ToString("MM/dd/yyyy");


            //Connection            
            string pass = "";
            //connection string
            string connectionstring = "datasource = localhost; database= wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
            MySqlConnection con = new MySqlConnection(connectionstring);



            /*-------------------------------------------------------------------*/
            /*-------------------------Show Total Employee--------------------------*/
            con.Open();
            string totalEmployeeQuery = "SELECT COUNT(*) FROM employee";
            MySqlCommand cmd = new MySqlCommand(totalEmployeeQuery, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            int countemp = 0;
            while (dr.Read())
            {
                countemp = dr.GetInt32(0);
            }

            label5.Text = "" + countemp + ""; // show Total Employee Dashboard

            con.Close(); // close connection



            /*-------------------------------------------------------------------*/
            /*---------------------------Total income---------------------------*/

            con.Open(); //open connection
            //Total Profit

            var totalprfitqury = "SELECT SUM(pay_amount) FROM payment";
            using (var cmdt = new MySqlCommand(totalprfitqury, con))
            {
                label6.Text = cmdt.ExecuteScalar().ToString(); // show all profit
            }
            con.Close(); //close connection




            /*-------------------------------------------------------------------*/
            /*----------------------------Total Project--------------------------*/
            con.Open(); //open connection
            var totalprojectQuery = "SELECT COUNT(*) FROM projects";
            using (var cmdtx = new MySqlCommand(totalprojectQuery, con))
            {
                MySqlDataReader dr2 = cmdtx.ExecuteReader();

                int countproject = 0;
                while (dr2.Read())
                {
                    countproject = dr2.GetInt32(0);
                }
                // show Total project Dashboard
                label7.Text = "" + countproject + "";

            }
            con.Close();//close connection

            /*-------------------------------------------------------------------*/
            /*-------Today Attendance Employee Project--------------------------*/

            con.Open(); //open connection
            var totalattTodayQuery = "SELECT COUNT(*) FROM attendance Where att_date = '"+ System.DateTime.Now.Date.ToString("yyyy/MM/dd") + "'";
            using (var cmdatt = new MySqlCommand(totalattTodayQuery, con))
            {
                MySqlDataReader dr3 = cmdatt.ExecuteReader();

                int countatttoday = 0;
                while (dr3.Read())
                {
                    countatttoday = dr3.GetInt32(0);
                }
                // show Today Attendance Employee  Dashboard
                label24.Text = "" + countatttoday + "";

            }
            con.Close();//close connection

            /*-------------------------------------------------------------------*/            
            /*-------------------------------------------------------------------*/

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        //check Profile dtails clck
        private void button2_Click(object sender, EventArgs e)
        {
            //Connection            
            string pass = "";
            //connection string
            string connectionstring = "datasource = localhost; database= wfmconst; port=3306; username=root; passwoard=" + pass + "; SslMode=none; ";
            MySqlConnection con = new MySqlConnection(connectionstring);

            /*--------------------------------------------------------------------------------------------*/

            con.Open();//start connection
                       //Complete projects
            string totalproQuery = "SELECT COUNT(*) FROM projects WHERE p_startdate BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND (p_state='Completed') ";

            MySqlCommand cmd = new MySqlCommand(totalproQuery, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            int countcomp = 0;
            while (dr.Read())
            {
                countcomp = dr.GetInt32(0);
            }
            label21.Text = "" + countcomp + ""; // show Total Employee Dashboard
            con.Close(); // close connection


            /*--------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------*/

            //Income Profit
            con.Open(); //open connection
            //Total Profit

            var totalprfitqury = "SELECT SUM(pay_amount) FROM payment WHERE Pay_date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'";
            using (var cmdt = new MySqlCommand(totalprfitqury, con))
            {
                label20.Text = cmdt.ExecuteScalar().ToString(); // show all profit
            }
            con.Close(); //close connection

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
