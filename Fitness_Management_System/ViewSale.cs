using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class ViewSale : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            adt = new SqlDataAdapter("select sale_id,cus_name,tel,sell_date from saleTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີການຂາຍ";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ຄົນຊື້";
            guna2DataGridView1.Columns[2].HeaderText = "ເບີໂທ";
            guna2DataGridView1.Columns[3].HeaderText = "ມື້ທີ່ຂາຍ";
        }
        public ViewSale()
        {
            InitializeComponent();
        }

        private void ViewSale_Load(object sender, EventArgs e)
        {
            cd.connectder();
            sadaeng();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale sl = new Sale();
            sl.TopLevel = false;
            panel1.Controls.Add(sl);
            sl.BringToFront();
            sl.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtSaleId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtCusName.Text == "")
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
            SqlCommand cmd = new SqlCommand("update saleTb set sale_id=@sale_id,cus_name=@cus_name,tel=@tel,sell_date=@sell_date where sale_id=@sale_id", cd.conder);
            cmd.Parameters.AddWithValue("@sale_id", txtSaleId.Text);
            cmd.Parameters.AddWithValue("@cus_name", txtCusName.Text);
            cmd.Parameters.AddWithValue("@sell_date", dobSaleDate.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                sadaeng();
                MessageBox.Show("ເພີ່ມສໍາເລັດ", "ເພີ່ມຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ເພີ່ມບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtSaleId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtCusName.Text == "")
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
                cmd = new SqlCommand("delete saleTb where sale_id=@sale_id", cd.conder);
                cmd.Parameters.AddWithValue("@sale_id", txtSaleId.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    sadaeng();
                    MessageBox.Show("ລົບຂໍ້ມູນສໍາເລັດ", "ລົບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("ລົບຂໍ້ມູນບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtSaleId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCusName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTel.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dobSaleDate.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
