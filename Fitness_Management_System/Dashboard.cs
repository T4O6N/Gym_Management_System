using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Fitness_Management_System
{
    public partial class Dashboard : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showinfo()
        {
            adt = new SqlDataAdapter("select * from paymentTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີສະມາຊິກ";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ແລະນາມສະກຸນ";
            guna2DataGridView1.Columns[2].HeaderText = "ໄລຍະເວລາ";
            guna2DataGridView1.Columns[3].HeaderText = "ລວມທັງໝົດ";
            guna2DataGridView1.Columns[4].HeaderText = "ຊໍາລະເງີນ";
            guna2DataGridView1.Columns[5].HeaderText = "ວັນທີ";
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();

            SqlCommand cmdd = new SqlCommand("Select count(*) from trainerTb", cd.conder);
            var count1 = cmdd.ExecuteScalar();
            lbTotalTrainer.Text = count1.ToString();

            SqlCommand cmddd = new SqlCommand("Select count(*) from membershipTb", cd.conder);
            var count2 = cmddd.ExecuteScalar();
            label5.Text = count2.ToString();

            SqlCommand cmd = new SqlCommand("Select total from paymentTb", cd.conder);
            cmd.Parameters.AddWithValue("@id", lbTotal.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbTotal.Text = dr.GetValue(0).ToString();
            }
            dr.Close();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm ms = new MainForm();
            ms.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            adt = new SqlDataAdapter("select * from paymentTb where name_surname='" + txtSearch.Text + "'", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
