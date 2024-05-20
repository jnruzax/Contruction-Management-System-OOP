using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace WFM.myclass
{
    class DB
    {
        public MySqlConnection con = new MySqlConnection() ;

        public DB()
        {
            string host = "localhost";
            string db = "wfmconst";
            string port = "3306";
            string user = "root";
            string pass = "";

            //connection string
            string connectionstring = "datasource = "+host+"; database="+db+"; port="+port+"; username="+user+"; passwoard="+pass+"; SslMode=none; ";
            con = new MySqlConnection(connectionstring);

        }
    }
    
  
}
