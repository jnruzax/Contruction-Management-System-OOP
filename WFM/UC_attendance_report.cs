using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFM
{
    public partial class UC_attendance_report : UserControl
    {
        public UC_attendance_report()
        {
            InitializeComponent();
        }

        private static UC_attendance_report _obj;
        public static UC_attendance_report Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_attendance_report();
                return _obj;

            }
        }

        private void UC_attendance_report_Load(object sender, EventArgs e)
        {

        }
    }
}
