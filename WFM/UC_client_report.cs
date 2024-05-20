using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using WFM.myclass;

namespace WFM
{
    public partial class UC_client_report : UserControl
    {
        public UC_client_report()
        {
            InitializeComponent();
        }

        private static UC_client_report _obj;
        public static UC_client_report Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_client_report();
                return _obj;

            }
        }

        private void UC_client_report_Load(object sender, EventArgs e)
        {

        }
    }
}
