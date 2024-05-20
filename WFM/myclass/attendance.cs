using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using WFM.myclass;

namespace WFM.myclass
{
    class attendance:DB
    {
        //attendance
        public int Emid { set; get; }
        public string attdate { set; get; }
        public string atttime { set; get; }

        // update leave time
        public int Emp_ID { set; get; }
        public string Lvtime { set; get; }
        public string date { set; get; }


        //save Employee attendance
        public void save_attendance()
        {
            con.Open();//open connection

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Insert into attendance(att_id,att_date,att_time,E_id) values(null,@att_date,@att_time,@E_id)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.Add("@att_date", MySqlDbType.VarChar).Value = attdate;
                cmd.Parameters.Add("@att_time", MySqlDbType.VarChar).Value = atttime;
                cmd.Parameters.Add("@E_id", MySqlDbType.Int32).Value = Emid;

                cmd.ExecuteNonQuery();
                con.Close(); //close connection
            }
        }

        //Update Employee attendance
        public void update_leave_time()
        {
            con.Open();//open connection

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE attendance SET leave_time = @Lvtime where E_id = @Emp_ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                
                //parameters
                cmd.Parameters.Add("@Lvtime", MySqlDbType.VarChar).Value = Lvtime;
                cmd.Parameters.Add("@Emp_ID", MySqlDbType.Int32).Value = Emp_ID;

                cmd.ExecuteNonQuery();
                con.Close(); //close connection
            }
        }

    }
}
