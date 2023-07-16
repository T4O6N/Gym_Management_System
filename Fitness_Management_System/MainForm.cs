using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Guna.UI2.WinForms;

namespace Fitness_Management_System
{
    public partial class MainForm : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showdata()
        {
            adt = new SqlDataAdapter("select * from membershipTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Db = new Dashboard();
            Db.TopLevel = false;
            panel3.Controls.Add(Db);
            Db.BringToFront();
            Db.Show();
        }

        private void btnTrainer_Click_1(object sender, EventArgs e)
        {
            Trainer Tn = new Trainer();
            Tn.TopLevel = false;
            panel3.Controls.Add(Tn);
            Tn.BringToFront();
            Tn.Show();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            Membership mbs = new Membership();
            mbs.TopLevel = false;
            panel3.Controls.Add(mbs);
            mbs.BringToFront();
            mbs.Show();
        }

        private void btnDailymembers_Click(object sender, EventArgs e)
        {
            Stock St = new Stock();
            St.TopLevel = false;
            panel3.Controls.Add(St);
            St.BringToFront();
            St.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showdata();

            Dashboard ds = new Dashboard();
            ds.TopLevel = false;
            panel3.Controls.Add(ds);
            ds.BringToFront();
            ds.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbToday.Text = DateTime.Now.ToLongTimeString();
            LbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            Package Pk = new Package();
            Pk.TopLevel = false;
            panel3.Controls.Add(Pk);
            Pk.BringToFront();
            Pk.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment Py = new Payment();
            Py.TopLevel = false;
            panel3.Controls.Add(Py);
            Py.BringToFront() ;
            Py.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Purchase Pc = new Purchase();
            Pc.TopLevel = false;
            panel3.Controls.Add(Pc);
            Pc.BringToFront();
            Pc.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Sale Sl = new Sale();
            Sl.TopLevel = false;
            panel3.Controls.Add(Sl);
            Sl.BringToFront();
            Sl.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            User Ur = new User();
            Ur.TopLevel = false;
            panel3.Controls.Add(Ur);
            Ur.BringToFront();
            Ur.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
