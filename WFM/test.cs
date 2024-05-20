using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFM
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           

           e.Graphics.DrawString("Construction Company Name", new Font("Arial", 24, FontStyle.Bold),Brushes.Black, new Point(10,10));

            e.Graphics.DrawString("Amount 1: ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString("'"+textBox1.Text+"'", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(250, 60));
        }

        private void button1_Click(object sender, EventArgs e)
        {

                   
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
