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
    public partial class Form3 : Form
    {
        int panelwidth;
        bool isCollapsed;
        public Form3()
        {
            InitializeComponent();
            timerTime.Start();
            panelwidth = panelLeft.Width;
            isCollapsed = false;
            

            UC_Home aa = new UC_Home();
            Addcontrolstopanel(aa);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelwidth + 10;
                if (panelLeft.Width >= panelwidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
      
    }
       
        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSlidpanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;

        }
        private void Addcontrolstopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelHome.Controls.Clear();
            panelHome.Controls.Add(c);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSlidpanel(btnHome);


            UC_Home aa = new UC_Home();
            Addcontrolstopanel(aa);

        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSlidpanel(btnSaleBooks);
            UC_Sales ss = new UC_Sales();
            Addcontrolstopanel(ss);

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            moveSlidpanel(btnPurchase);
            UC_Purchase zz = new UC_Purchase();
            Addcontrolstopanel(zz);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            moveSlidpanel(btnExpense);
            UC_Expenses tt = new UC_Expenses();
            Addcontrolstopanel(tt);
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSlidpanel(btnViewSales);
            UC_ViewSales yy = new UC_ViewSales();
            Addcontrolstopanel(yy);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            moveSlidpanel(btnSettings);
            Form2 cc = new Form2();
            cc.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

