using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace Fitness_Management_System
{
    public partial class Sale : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showinfo()
        {
            adt = new SqlDataAdapter("select sale_id,pro_name,stock_id,price,quantity,UOM,total from saleTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີການຂາຍ";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            guna2DataGridView1.Columns[2].HeaderText = "ໄອດີສະຕ໋ອກ";
            guna2DataGridView1.Columns[3].HeaderText = "ລາຄາ";
            guna2DataGridView1.Columns[4].HeaderText = "ຈໍານວນ";
            guna2DataGridView1.Columns[5].HeaderText = "ປະເພດປະລິມານ";
            guna2DataGridView1.Columns[6].HeaderText = "ລວມທັງໝົດ";
        }

        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();

            cdpcname.connectder();
            PurchaseName();

            cdstockId.connectder();
            StockId();
        }
        SqlDataAdapter dapcname = new SqlDataAdapter();
        DataSet dspcname = new DataSet();
        connection cdpcname= new connection();
        SqlCommand cmdpcname = new SqlCommand();
        DataTable dtpcname = new DataTable();

        public void PurchaseName()
        {
            SqlDataAdapter dapcname = new SqlDataAdapter("select pro_name,quantity,total from purchaseTb", cdpcname.conder);
            dapcname.Fill(dtpcname);
            txtProName.DataSource = dtpcname;
            txtProName.DisplayMember = "pro_name";
            txtProName.ValueMember = "pro_name";
            txtTotalQuantity.DataSource = dtpcname;
            txtTotalQuantity.DisplayMember = "quantity";
            txtTotalQuantity.ValueMember = "quantity";
            txtPrice.DataSource = dtpcname;
            txtPrice.DisplayMember = "total";
            txtPrice.ValueMember = "total";
        }

        SqlDataAdapter dastockId = new SqlDataAdapter();
        DataSet dastockIdd = new DataSet();
        connection cdstockId = new connection();
        SqlCommand cmdstockId = new SqlCommand();
        DataTable dtstockId = new DataTable();

        public void StockId()
        {
            SqlDataAdapter dastockId = new SqlDataAdapter("select stock_id from stockTb", cdstockId.conder);
            dastockId.Fill(dtstockId);
            cbStockId.DataSource = dtstockId;
            cbStockId.DisplayMember = "stock_id";
            cbStockId.ValueMember = "stock_id";
        }

        private void btSave_Click_1(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("insert into saleTb(sale_id,cus_name,tel,sell_date,pro_name,stock_id,price,quantity,UOM,total)values(@sale_id,@cus_name,@tel,@sell_date,@pro_name,@stock_id,@price,@quantity,@UOM,@total)", cd.conder);
                cmd.Parameters.AddWithValue("@sale_id", txtSaleId.Text);
                cmd.Parameters.AddWithValue("@cus_name", txtCusName.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@sell_date", dobSaleDate.Text);
                cmd.Parameters.AddWithValue("@pro_name", txtProName.Text);
                cmd.Parameters.AddWithValue("@stock_id", cbStockId.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@UOM", txtUOM.Text);
                cmd.Parameters.AddWithValue("@total", txtTotal.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    showinfo();
                    MessageBox.Show("ເພີ່ມສໍາເລັດ", "ເພີ່ມຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    // Discount the number of stock
                    string sql = "update stockTb set quantity = quantity - @quantity where stock_id = @stock_id";
                    SqlCommand cmdStock = new SqlCommand(sql, cd.conder);
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    cmdStock.Parameters.AddWithValue("@quantity", quantity);
                    cmdStock.Parameters.AddWithValue("@stock_id", cbStockId.Text);
                    cmdStock.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("ເພີ່ມບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
                }
                txtSaleId.Text = "";
                txtCusName.Text = "";
                txtTel.Text = "";
                txtProName.Text = "";
                cbStockId.Text = "";
                txtTotalQuantity.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtUOM.Text = "";
                txtTotal.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            SqlCommand cmd = new SqlCommand("update saleTb set pro_name=@pro_name,price=@price,quantity=@quantity,UOM=@UOM,total=@total where sale_id=@sale_id", cd.conder);
            cmd.Parameters.AddWithValue("sale_id", txtSaleId.Text);
            cmd.Parameters.AddWithValue("@pro_name", txtProName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("UOM", txtUOM.Text);
            cmd.Parameters.AddWithValue("total", txtTotal.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ແກ້ໄຂແລ້ວ", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ແກ້ໄຂບໍ່ໄດ້", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtSaleId.Text = "";
            txtProName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtUOM.Text = "";
            txtTotal.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
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
                showinfo();
                MessageBox.Show("ລົບຂໍ້ມູນສໍາເລັດ", "ລົບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtSaleId.Text = "";
            txtCusName.Text = "";
            txtTel.Text = "";
            txtProName.Text = "";
            cbStockId.Text = "";
            txtTotalQuantity.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtUOM.Text = "";
            txtTotal.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btView_Click(object sender, EventArgs e)
        {
            ViewSale vs = new ViewSale();
            vs.TopLevel = false;
            panel1.Controls.Add(vs);
            vs.BringToFront();
            vs.Show();
            }
            private void btScan_Click(object sender, EventArgs e)
           {
            if (txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text) > 0) 
            {
                MessageBox.Show("ຈໍານວນບໍ່ພຽງພໍ");
            }
            else
            {
                MessageBox.Show("ຈໍານວນພຽງພໍ");
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = (float.Parse(txtPrice.Text) * float.Parse(txtQuantity.Text)).ToString();
            }
            catch
            {

            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            string text = txtTotal.Text;

            if (!int.TryParse(text, out int number))
            {
                return;
            }

            string formattedNumber = number.ToString("0.000");

            txtTotal.Text = formattedNumber;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm ms = new MainForm();
            ms.Show();
        }

        private void btOpenReport_Click(object sender, EventArgs e)
        {
            SaleReportForm srf = new SaleReportForm();
            srf.ShowDialog();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSaleId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbStockId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQuantity.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtUOM.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTotal.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
