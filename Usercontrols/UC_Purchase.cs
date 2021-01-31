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
    public partial class UC_Purchase : UserControl
    {
        public UC_Purchase()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(AddNewBook ww=new AddNewBook())
            {
                ww.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (addcategory qq = new addcategory())
            {
                qq.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
