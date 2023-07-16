using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class Stock : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            adt = new SqlDataAdapter("select * from stockTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີສຕ໋ອກ";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            guna2DataGridView1.Columns[2].HeaderText = "ຈໍໍານວນ";
            guna2DataGridView1.Columns[3].HeaderText = "ລາຄາ6";
            guna2DataGridView1.Columns[4].HeaderText = "ປະເພດປະລິມານ";
        }
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            cd.connectder();
            sadaeng();  
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm ms = new MainForm();
            ms.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            adt = new SqlDataAdapter("select * from stockTb where pro_name='" + txtSearch.Text + "'", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
