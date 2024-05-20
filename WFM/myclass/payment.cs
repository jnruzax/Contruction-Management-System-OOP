using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WFM.myclass;
using MySql.Data.MySqlClient;

namespace WFM.myclass
{
    class payment : DB
    {
        public string date { set; get; }
        public string amount { set; get; }
        public string clintname { set; get; }
        public string project { set; get; }
        
        //add payment
        public void addpayment_entry()
        {
            con.Open(); // open connection
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO payment(Pay_id,Pay_date,pay_amount,Client,project) values(null, @paydate, @amount, @client,@project)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@paydate", MySqlDbType.VarChar).Value = date;
                cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;
                cmd.Parameters.Add("@client", MySqlDbType.VarChar).Value = clintname;
                cmd.Parameters.Add("@project", MySqlDbType.VarChar).Value = project;

                cmd.ExecuteNonQuery();
                con.Close(); //close connection
            }
        }  
                
    }
}
