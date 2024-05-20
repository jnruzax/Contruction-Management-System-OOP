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
    public partial class UC_Profit_Report : UserControl
    {
        public UC_Profit_Report()
        {
            InitializeComponent();
        }

        private static UC_Profit_Report _obj;
        public static UC_Profit_Report Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_Profit_Report();
                return _obj;

            }
        }

        private void UC_Profit_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
