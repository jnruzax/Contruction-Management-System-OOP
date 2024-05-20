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
 
    class clients :DB
    {
        public string cfname { set; get; }
        public string clname { set; get; }
        public string cemail { set; get; }
        public string cphone { set; get; }
        public string cadd { set; get; }

        //searching
        public int IDs { set; get; }
        public string fn { set; get; }
        public string ln { set; get; }
        public string em { set; get; }
        public string tp { set; get; }
        public string adrs { set; get; }


        //updating 
        public string cfn { set; get; }
        public string cln { set; get; }
        public string cem { set; get; }
        public int cph { set; get; }
        public string caddress { set; get; }
        public int C_ID { set; get; }

        //deleting 
        public int Deletecid { set; get; }




        //add client data
        public void add_client_entry()
        {
            con.Open(); //connecion open
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Insert into client (c_id,c_fname ,c_lname ,c_email ,c_phone ,c_address) values(null, @fname, @lname, @emailnum , @phone , @address)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameter
                cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = cfname;
                cmd.Parameters.Add("@lname", MySqlDbType.VarChar).Value = clname;
                cmd.Parameters.Add("@emailnum", MySqlDbType.VarChar).Value = cemail;
                cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = cphone;
                cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = cadd;

                cmd.ExecuteNonQuery();
                con.Close(); //connecion close

            }
        }
        
        //search clients
        public void Search_client()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Select * from client where c_id = @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameter
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = IDs ;

                MySqlDataReader dt = cmd.ExecuteReader();

                while (dt.Read())
                {
                    fn = dt.GetValue(1).ToString();
                    ln = dt.GetValue(2).ToString();
                    em =  dt.GetValue(3).ToString();
                    tp = dt.GetValue(4).ToString();
                    adrs = dt.GetValue(5).ToString();
                }
                con.Close();

            }
                

        }

        
        //update the client data
        public void update_clientdata()
        {
            con.Open(); // open connection

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE client SET c_fname = @cfn, c_lname = @cln, c_email = @cem, c_phone = @cph, c_address = @cadd where c_id = @C_ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@C_ID", Convert.ToInt32(C_ID));
                cmd.Parameters.AddWithValue("@cfn", Convert.ToString(cfn));
                cmd.Parameters.AddWithValue("@cln", Convert.ToString(cfn));
                cmd.Parameters.Add("@cem", MySqlDbType.VarChar).Value = cem;
                cmd.Parameters.Add("@cph", MySqlDbType.Int32).Value = cph;
                cmd.Parameters.Add("@cadd", MySqlDbType.VarChar).Value = caddress;

                cmd.ExecuteNonQuery();
                con.Close(); //connecion close

            }
        }

        
        //Delete Client Record
        public void delete_client()
        {
            con.Open(); //connecion open
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM client WHERE c_id= @C_ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@C_ID", Convert.ToInt32(Deletecid));

                cmd.ExecuteNonQuery();
                con.Close(); //close connection
            }
        }
    }
}
