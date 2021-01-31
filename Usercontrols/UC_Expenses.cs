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
    public partial class UC_Expenses : UserControl
    {
        public UC_Expenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(addexpense rr=new addexpense())
            {
                rr.ShowDialog();
            }
        }
    }
}
