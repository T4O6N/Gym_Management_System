using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class ViewUser : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            adt = new SqlDataAdapter("select * from userTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ຊື່ຄົນໃຊ້";
            guna2DataGridView1.Columns[1].HeaderText = "ນາມສະກຸນ";
            guna2DataGridView1.Columns[2].HeaderText = "ລະຫັດຜ່ານ";
            guna2DataGridView1.Columns[3].HeaderText = "ຢືນຢັນລະຫັດຜ່ານ";
            guna2DataGridView1.Columns[4].HeaderText = "ຄໍາຖາມ";
            guna2DataGridView1.Columns[5].HeaderText = "ຕອບຄໍາຖາມ";
            guna2DataGridView1.Columns[6].HeaderText = "ເບີໂທ";
            guna2DataGridView1.Columns[7].HeaderText = "ທີ່ຢູ່";
            guna2DataGridView1.Columns[8].HeaderText = "ອາຍຸ";
            guna2DataGridView1.Columns[9].HeaderText = "ອີເມວ";
        }
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            cd.connectder();
            sadaeng();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            User us = new User();
            us.TopLevel = false;
            panel1.Controls.Add(us);
            us.BringToFront();
            us.Show();
        }
    }
}
