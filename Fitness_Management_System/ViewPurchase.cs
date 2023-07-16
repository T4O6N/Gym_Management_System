using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class ViewPurchase : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void sadaeng()
        {
            adt = new SqlDataAdapter("select purchase_id,deli_name,tel,deli_time,purchase_date from purchaseTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີການຊື້";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ຄົນສົ່ງ";
            guna2DataGridView1.Columns[2].HeaderText = "ເບີໂທຄົນສົ່ງ";
            guna2DataGridView1.Columns[3].HeaderText = "ເວລາສົ່ງ";
            guna2DataGridView1.Columns[4].HeaderText = "ມື້ທີ່ຊື້";
        }
        public ViewPurchase()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            cd.connectder();
            sadaeng();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtPurchaseId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtDeliName.Text == "")
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
                SqlCommand cmd = new SqlCommand("update purchaseTb set deli_name=@deli_name,tel=@tel,deli_time=@deli_time,purchase_date=@purchase_date where purchase_id=@purchase_id", cd.conder);
            cmd.Parameters.AddWithValue("@purchase_id", txtPurchaseId.Text);
            cmd.Parameters.AddWithValue("@deli_name", txtDeliName.Text);
            cmd.Parameters.AddWithValue("@tel", txtDeliTel.Text);
            cmd.Parameters.AddWithValue("@deli_time", txtDeliTime.Text);
            cmd.Parameters.AddWithValue("@purchase_date", dobBuyDate.Value.Date);

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
            if (txtPurchaseId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtDeliName.Text == "")
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
                cmd = new SqlCommand("delete purchaseTb where purchase_id=@purchase_id", cd.conder);
                cmd.Parameters.AddWithValue("@purchase_id", txtPurchaseId.Text);

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

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase pc = new Purchase();
            pc.TopLevel = false;
            panel1.Controls.Add(pc);
            pc.BringToFront();
            pc.Show();
        }

        private void guna2DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPurchaseId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDeliName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDeliTel.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDeliTime.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dobBuyDate.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
