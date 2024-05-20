using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using WFM.myclass;

namespace WFM.myclass
{
    class project : DB
    {
        //adding
        public string ptitle { set; get; }
        public string pstartdate { set; get; }
        public string pdura { set; get; }
        public string pcost { set; get; }
        public string pstate { set; get; }
        public string pclient { set; get; }

        //clientname to combo
        public string clienttocombo { set; get; }

        //searching
        public int PID { set; get; }
        public string ppt { set; get; }
        public string ppd { set; get; }
        public string ppa { set; get; }
        public string pps { set; get; }

        //deleting
        public int deletedPid { set; get; }

        //updating
        public int PUID { set; get;}
        public string Ptitles { set; get; }
        public int produra { set; get; }
        public int procost { set; get; }
        public string pstates { set; get; }


        //add project details
        public void addadd_project_entry()
        {
            con.Open(); // open connection

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Insert into projects (p_id, p_title,p_startdate,p_duration,p_cost,p_state,client) values(null,@p_title,@p_startdate,@p_duration,@p_cost,@p_state,@client) ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //project parameter
                cmd.Parameters.Add("@p_title", MySqlDbType.VarChar).Value = ptitle;
                cmd.Parameters.Add("@p_startdate", MySqlDbType.VarChar).Value = pstartdate;
                cmd.Parameters.Add("@p_duration", MySqlDbType.VarChar).Value = pdura;
                cmd.Parameters.Add("@p_cost", MySqlDbType.VarChar).Value = pcost;
                cmd.Parameters.Add("@p_state", MySqlDbType.VarChar).Value = pstate;
                cmd.Parameters.Add("@client", MySqlDbType.VarChar).Value = pclient;

                cmd.ExecuteNonQuery();
                con.Close(); // connection close

            }
        }

        //client details get to combo
        public void clint_to_combo()
        {
            con.Open(); // connection open
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Select * from client";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //client first name
                    string clienttocombo1 = dr.GetString("c_fname");
                    //client last name
                    string clienttocombo2 = dr.GetString("c_lname");

                    //client full name
                    clienttocombo = clienttocombo1 + " " + clienttocombo2;
                }
                con.Close(); // connection close

            }

        }

        //project search button
        public void project_search()
        {
            con.Open(); // open connection
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM projects WHERE p_id=@PID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameter
                cmd.Parameters.Add("@PID", MySqlDbType.Int32).Value = PID;
                MySqlDataReader dt = cmd.ExecuteReader();

                while (dt.Read())
                {
                    ppt = dt.GetValue(1).ToString();
                    ppd = dt.GetValue(3).ToString();
                    ppa = dt.GetValue(4).ToString();
                    pps = dt.GetValue(5).ToString();
                }
                con.Close(); // close connection
            }
        }

        //deleted the project details
        public void Project_details_delete()
        {
            con.Open(); // open the connection
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM projects WHERE p_id= @P_ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@P_ID", Convert.ToInt32(deletedPid));

                cmd.ExecuteNonQuery();
            }
            con.Close(); // close connectiom
        }

        //update the project details
        public void update_projectdata()
        {
            con.Open(); // open connection

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE projects SET p_title = @Ptitle , p_duration = @pdura, p_cost = @pcost , p_state = @pstates WHERE p_id = @PUID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                
                cmd.Parameters.AddWithValue("@PUID", Convert.ToInt32(PUID));
                cmd.Parameters.AddWithValue("@Ptitle", Convert.ToString(Ptitles));
                cmd.Parameters.AddWithValue("@pdura", Convert.ToInt32(produra));
                cmd.Parameters.AddWithValue("@pcost", Convert.ToInt32(procost));
                cmd.Parameters.AddWithValue("@pstates", Convert.ToString(pstates));

                cmd.ExecuteNonQuery();
                con.Close(); //connecion close

            }
        }
    }
}

