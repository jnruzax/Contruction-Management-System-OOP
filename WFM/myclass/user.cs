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
    class user:DB
    {
        //adding
        public string usrname { set; get; }
        public string pass { set; get; }
        public string usrtype { set; get; }
        public int usrrol { set; get; }

        //searching
        public int IDs { set; get; }
        public string un { set; get; }
        public string pw { set; get; }
        public string ut { set; get; }
        public string ur { set; get; }

        //deleting
        public int Deleteuid { set; get; }

        //updating
        public int U_ID { set; get; }
        public string usrnam { set; get; }
        public string usrtyp { set; get; }
        public string pwd { set; get; }
        public int url { set; get; }


        //search User
        public void Search_user()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Select * from user where u_id = @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameter
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = IDs;

                MySqlDataReader dt = cmd.ExecuteReader();

                while (dt.Read())
                {
                    un = dt.GetValue(1).ToString();
                    pw = dt.GetValue(2).ToString();
                    ut = dt.GetValue(3).ToString();
                    ur = dt.GetValue(4).ToString();
                }
                con.Close();

            }


        }


        //Delete User Record
        public void delete_user()
        {
            con.Open(); //connecion open
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM user WHERE u_id= @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(Deleteuid));

                cmd.ExecuteNonQuery();
                con.Close(); //close connection
            }
        }


        //add data 
        public void add_details()
        {
            con.Open(); // open connection
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Insert Into user(u_id,username,password,User_type,role) values(null, @usrnam , @pass , @usrtyp , @usrrol)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                
                //parameters
                cmd.Parameters.AddWithValue("@usrnam", Convert.ToString(usrname));
                cmd.Parameters.AddWithValue("@pass", Convert.ToString(pass));
                cmd.Parameters.AddWithValue("@usrtyp", Convert.ToString(usrtype));
                cmd.Parameters.AddWithValue("@usrrol", Convert.ToInt32(usrrol));

                cmd.ExecuteNonQuery();
                con.Close(); //connecion close

            }
            con.Close(); // close connection

        }

        //update the user data
        public void update_userdata()
        {
            con.Open(); // open connection

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE user SET username = @usrnam, 	password = @pwd , User_type = @usrtyp , role = @url where u_id = @U_ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@U_ID", Convert.ToInt32(U_ID));
                cmd.Parameters.AddWithValue("@usrnam", Convert.ToString(usrnam));
                cmd.Parameters.AddWithValue("@pwd", Convert.ToString(pwd));
                cmd.Parameters.AddWithValue("@usrtyp", Convert.ToString(usrtyp));
                cmd.Parameters.AddWithValue("@url", Convert.ToInt32(url));

                cmd.ExecuteNonQuery();
                con.Close(); //connecion close

            }
        }
    }
}
