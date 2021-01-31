using bookland3.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookland3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form3 F2 = new Form3())
            {
                F2.ShowDialog();
                using(UC_Home dd=new UC_Home())
                {
                   
                }
                this.Hide();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength >= 1)
            {
                panel6.BackColor = Color.Teal;
            }
            else
            {
                panel6.BackColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength >= 1)
            {
                panel3.BackColor = Color.Teal;
            }
            else
            {
                panel3.BackColor = Color.Gray;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 vv = new Form3();
            vv.Show();
            this.Hide();
        }
    }
}
