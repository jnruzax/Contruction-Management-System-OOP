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
    class employee : DB
    {
        public string fname { set; get; }
        public string lname { set; get; }
        public string job { set; get; }
        public string gender { set; get; }
        public string dob { set; get; }
        public string email { set; get; }
        public string phone { set; get; }
        public string address { set; get; }
        public string about { set; get; }

        public string jobname { set; get; }

        //Searching
        public int EIDs { set; get; }
        public string efn { set; get; }
        public string eln { set; get; }
        public string ejob { set; get; }
        public string eem { set; get; }
        public string etp { set; get; }
        public string eadrs { set; get; }
        public string eabout { set; get; }    
        
        //deleting
        public string deletedid { set; get; }

        //Updating 
        public int Emp_ID { set; get; }
        public string Efnm { set; get; }
        public string Elnm { set; get; }
        public string Ejb { set; get; }
        public string Eeml { set; get; }
        public int Ephn { set; get; }
        public string Eadds { set; get; }
        public string Eabut { set; get; }


        //add employee
        public void addemployee_entry()
        {
            con.Open(); //connection open

            using (MySqlCommand cmd = new MySqlCommand())
            {
                                
                cmd.CommandText = "INSERT INTO employee (E_id,E_fname,E_lname,E_job,E_gen,E_DOB,E_email,E_phone,E_address,E_about) values(null,@E_fname,@E_lname,@E_job,@E_gen,@E_DOB,@E_mail,@E_phone,@E_address,@E_about)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //employee parameters
                cmd.Parameters.Add("@E_fname", MySqlDbType.VarChar).Value = fname;
                cmd.Parameters.Add("@E_lname", MySqlDbType.VarChar).Value = lname;
                cmd.Parameters.Add("@E_job", MySqlDbType.VarChar).Value = job;
                cmd.Parameters.Add("@E_gen", MySqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@E_DOB", MySqlDbType.VarChar).Value = dob;
                cmd.Parameters.Add("@E_mail", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@E_phone", MySqlDbType.VarChar).Value = phone;
                cmd.Parameters.Add("@E_address", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@E_about", MySqlDbType.VarChar).Value = about;


                cmd.ExecuteNonQuery();
                con.Close(); //connection close

            }

        }

        //save job
        public void add_job_entry()
        {
            con.Open(); // open connection 
                using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "insert into jobs(job_id,job_Name)values(null,@jobname)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@jobname", MySqlDbType.VarChar).Value = jobname;

                cmd.ExecuteNonQuery();
                con.Close(); // close connection

            }
        }


        //search employee
        public void Search_employee()
        {
            con.Open(); //open connection
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "Select * from employee where E_id = @EID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameter
                cmd.Parameters.Add("@EID", MySqlDbType.Int32).Value = EIDs;

                MySqlDataReader dt = cmd.ExecuteReader();

                while (dt.Read())
                {
                    efn = dt.GetValue(1).ToString();
                    eln = dt.GetValue(2).ToString();
                    ejob = dt.GetValue(3).ToString();
                    eem = dt.GetValue(6).ToString();
                    etp = dt.GetValue(7).ToString();
                    eadrs = dt.GetValue(8).ToString();
                    eabout = dt.GetValue(9).ToString();
                }
                con.Close(); // close connection

            }


        }

        //Delete employee Record
        public void delete_employee()
        {
            con.Open(); //connecion open
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM employee WHERE E_id= @E_ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@E_ID", Convert.ToInt32(deletedid));

                cmd.ExecuteNonQuery();
                con.Close(); //close connection
            }
        }

        //update employee details
        public void update_empdata()
        {
            con.Open(); // open connection

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE employee SET E_fname = @Efnm , E_lname = @Elnm, E_job = @Ejb, E_email = @Eeml ,E_phone = @Ephn, E_address = @Eadds, E_about = @Eabut where E_id = @Emp_ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                //parameters
                cmd.Parameters.AddWithValue("@Emp_ID", Convert.ToInt32(Emp_ID));
                cmd.Parameters.AddWithValue("@Efnm", Convert.ToString(Efnm));
                cmd.Parameters.AddWithValue("@Elnm", Convert.ToString(Elnm));
                cmd.Parameters.AddWithValue("@Ejb", Convert.ToString(Ejb));
                cmd.Parameters.Add("@Eeml", MySqlDbType.VarChar).Value = Eeml;
                cmd.Parameters.Add("@Ephn", MySqlDbType.Int32).Value = Ephn;
                cmd.Parameters.Add("@Eadds", MySqlDbType.VarChar).Value = Eadds;
                cmd.Parameters.Add("@Eabut", MySqlDbType.VarChar).Value = Eabut;

                cmd.ExecuteNonQuery();
                con.Close(); //connecion close

            }
        }
    }
}
