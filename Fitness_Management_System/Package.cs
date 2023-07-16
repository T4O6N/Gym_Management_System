using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class Package : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showinfo()
        {
            adt = new SqlDataAdapter("select * from PackageTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີສິນຄ້າ";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            guna2DataGridView1.Columns[2].HeaderText = "ລາຄາ";
            guna2DataGridView1.Columns[3].HeaderText = "ລາຍລະອຽດ";
        }

        public Package()
        {
            InitializeComponent();
        }

        private void Package_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtPackageId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPackageName.Text == "")
            {
                errMsg += "";
            }
            if (errMsg != "")
            {
                MessageBox.Show(errMsg, "ມີຂໍ້ຜິດພາດ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
            SqlCommand cmd = new SqlCommand("insert into packageTb(package_id,package_name,package_price,details)values(@package_id,@package_name,@package_price,@details)", cd.conder);
            cmd.Parameters.AddWithValue("@package_id", txtPackageId.Text);
            cmd.Parameters.AddWithValue("@package_name", txtPackageName.Text);
            cmd.Parameters.AddWithValue("@package_price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@details", txtDetails.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ເພີ່ມສໍາເລັດ");
            }
            else
            {
                MessageBox.Show("ເພີ່ມບໍ່ໄດ້");
            }
            txtPackageId.Text = "";
            txtPackageName.Text = "";
            txtPrice.Text = "";
            txtDetails.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtPackageId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPackageName.Text == "")
            {
                errMsg += "";
            }
            if (errMsg != "")
            {
                MessageBox.Show(errMsg, "ມີຂໍ້ຜິດພາດ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
            SqlCommand cmd = new SqlCommand("update packageTb set package_id=@package_id,package_name=@package_name,package_price=@package_price,details=@details where package_id=@package_id", cd.conder);
            cmd.Parameters.AddWithValue("@package_id", txtPackageId.Text);
            cmd.Parameters.AddWithValue("@package_name", txtPackageName.Text);
            cmd.Parameters.AddWithValue("@package_price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@details", txtDetails.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ແກ້ໄຂແລ້ວ", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ແກ້ໄຂບໍ່ໄດ້", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtPackageId.Text = "";
            txtPackageName.Text = "";
            txtPrice.Text = "";
            txtDetails.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtPackageId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPackageName.Text == "")
            {
                errMsg += "";
            }
            if (errMsg != "")
            {
                MessageBox.Show(errMsg, "ມີຂໍ້ຜິດພາດ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cmd = new SqlCommand("delete packageTb where package_id=@package_id", cd.conder);
            cmd.Parameters.AddWithValue("@package_id", txtPackageId.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ລົບຂໍ້ມູນສໍາເລັດ", "ລົບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtPackageId.Text = "";
            txtPackageName.Text = "";
            txtPrice.Text = "";
            txtDetails.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm ms = new MainForm();
            ms.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            adt = new SqlDataAdapter("select * from packageTb where package_name='" + txtSearch.Text + "'", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPackageId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPackageName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDetails.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
