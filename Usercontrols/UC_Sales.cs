using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bookland3.Forms;

namespace bookland3.Usercontrols
{
    public partial class UC_Sales : UserControl
    {
        public UC_Sales()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using(sup_sales qa =new sup_sales())
            {
                qa.ShowDialog();
            }
        }
    }
}
