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
    class login :DB
    {
        public string user_name { set; get; }
        public string user_password { set; get; }
        public int user_role { set; get; }

        public bool user_validation()
        {
            bool check = false; 

            con.Open(); // connection open 
            MySqlDataReader rd;

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM user where username = @usrnm And password=@pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //Parameters
                cmd.Parameters.Add("@usrnm", MySqlDbType.VarChar).Value = user_name;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = user_password;

                rd = cmd.ExecuteReader();

                while(rd.Read())
                {
                    check = true;
                    user_role = rd.GetInt32("role"); // read database data 
                }
            }

            con.Close(); // close connection
            return check; // return 
        }
    }
}
