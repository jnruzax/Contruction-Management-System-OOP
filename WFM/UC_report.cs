using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using WFM.myclass;
using MySql.Data.MySqlClient;

namespace WFM
{
    public partial class UC_report : UserControl
    {
        private static UC_report _obj;
        public static UC_report Obj
        {
            get
            {
                if (_obj == null)
                    _obj = new UC_report();
                return _obj;

            }
        }
        public UC_report()
        {
            InitializeComponent();
            STARTUPREPORT();
            

        }
        //form load start
        private void STARTUPREPORT()
        {
            profit.ForeColor = Color.Orange;//clicked
            atte.ForeColor = Color.White;
            project.ForeColor = Color.White;
            client.ForeColor = Color.White;

            //load uc_report report

            if (!panel2.Controls.Contains(UC_Profit_Report.Obj))
            {
                panel2.Controls.Add(UC_Profit_Report.Obj);
                UC_Profit_Report.Obj.Dock = DockStyle.Fill;
                UC_Profit_Report.Obj.BringToFront();
            }
            else
            {
                UC_Profit_Report.Obj.BringToFront();

            }
        }

        //profit reports
        private void profit_Click(object sender, EventArgs e)
        {
            profit.ForeColor = Color.Orange;//clicked
            atte.ForeColor = Color.White;
            project.ForeColor = Color.White;
            client.ForeColor = Color.White;

            //load uc_report report

            if (!panel2.Controls.Contains(UC_Profit_Report.Obj))
            {
                panel2.Controls.Add(UC_Profit_Report.Obj);
                UC_Profit_Report.Obj.Dock = DockStyle.Fill;
                UC_Profit_Report.Obj.BringToFront();
            }
            else
            {
                UC_Profit_Report.Obj.BringToFront();

            }

        }

        //project report
        private void project_Click(object sender, EventArgs e)
        {
            profit.ForeColor = Color.White;
            atte.ForeColor = Color.White;
            project.ForeColor = Color.Orange;//clicked
            client.ForeColor = Color.White;


            //load UC_project report

            if (!panel2.Controls.Contains(UC_project_report.Obj))
            {
                panel2.Controls.Add(UC_project_report.Obj);
                UC_project_report.Obj.Dock = DockStyle.Fill;
                UC_project_report.Obj.BringToFront();
            }
            else
            {
                UC_project_report.Obj.BringToFront();

            }
        }

        //attendance report
        private void atte_Click(object sender, EventArgs e)
        {
            profit.ForeColor = Color.White;
            atte.ForeColor = Color.Orange;//clicked
            project.ForeColor = Color.White;
            client.ForeColor = Color.White;

            //load UC_attendance_report 

            if (!panel2.Controls.Contains(UC_attendance_report.Obj))
            {
                panel2.Controls.Add(UC_attendance_report.Obj);
                UC_attendance_report.Obj.Dock = DockStyle.Fill;
                UC_attendance_report.Obj.BringToFront();
            }
            else
            {
                UC_attendance_report.Obj.BringToFront();

            }
        }

        //client report
        private void label1_Click(object sender, EventArgs e)
        {
            profit.ForeColor = Color.White;
            atte.ForeColor = Color.White;
            project.ForeColor = Color.White;
            client.ForeColor = Color.Orange;//clicked

            //load UC_client_report 

            if (!panel2.Controls.Contains(UC_client_report.Obj))
            {
                panel2.Controls.Add(UC_client_report.Obj);
                UC_client_report.Obj.Dock = DockStyle.Fill;
                UC_client_report.Obj.BringToFront();
            }
            else
            {
                UC_client_report.Obj.BringToFront();

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
