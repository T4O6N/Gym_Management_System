using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace Fitness_Management_System
{
    public partial class Purchase : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showinfo()
        {
            adt = new SqlDataAdapter("select purchase_id,pro_name,price,quantity,UOM,Total from purchaseTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີການຊື້";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            guna2DataGridView1.Columns[2].HeaderText = "ລາຄາ";
            guna2DataGridView1.Columns[3].HeaderText = "ຈໍານວນ";
            guna2DataGridView1.Columns[4].HeaderText = "ປະເພດນໍ້າໜັກ";
            guna2DataGridView1.Columns[5].HeaderText = "ລວມທັງໝົດ";
        }
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtStockId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPurchaseId.Text == "")
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
            SqlCommand cmd = new SqlCommand("insert into purchaseTb(purchase_id,deli_name,tel,deli_time,purchase_date,pro_name,price,quantity,UOM,total)values(@purchase_id,@deli_name,@tel,@deli_time,@purchase_date,@pro_name,@price,@quantity,@UOM,@total)", cd.conder);
            cmd.Parameters.AddWithValue("@purchase_id", txtPurchaseId.Text);
            cmd.Parameters.AddWithValue("@deli_name", txtDeliName.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@deli_time", txttime_deli.Text);
            cmd.Parameters.AddWithValue("@purchase_date", txtPurchase_Date.Value.Date);
            cmd.Parameters.AddWithValue("@pro_name", txtProName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("UOM", txtUOM.Text);
            cmd.Parameters.AddWithValue("@total", txtTotal.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ເພີ່ມສໍາເລັດ", "ເພີ່ມຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ເພີ່ມບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
                getsumofcellvalue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtStockId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPurchaseId.Text == "")
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
            SqlCommand cmd = new SqlCommand("update purchaseTb set pro_name=@pro_name,price=@price,quantity=@quantity,UOM=@UOM,total=@total where purchase_id=@purchase_id", cd.conder);
            cmd.Parameters.AddWithValue("purchase_id", txtPurchaseId.Text);
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
            txtPurchaseId.Text = "";
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

        private void btClear_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtStockId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPurchaseId.Text == "")
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
                showinfo();
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
        private void btView_Click(object sender, EventArgs e)
        {
            ViewPurchase vw = new ViewPurchase();
            vw.TopLevel = false;
            panel1.Controls.Add(vw);
            vw.BringToFront();
            vw.Show();
        }

        private void btToStock_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into stockTb(stock_id,pro_name,quantity,price,uom)values(@stock_id,@pro_name,@quantity,@price,@uom)", cd.conder);
            cmd.Parameters.AddWithValue("stock_id", txtStockId.Text);
            cmd.Parameters.AddWithValue("@pro_name", txtProName.Text);
            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@uom", txtUOM.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ເພີ່ມສໍາເລັດ", "ເພີ່ມຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ເພີ່ມບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtPurchaseId.Text = "";
            txtDeliName.Text = "";
            txtTel.Text = "";
            txttime_deli.Text = "";
            txtPurchase_Date.Text = "";
            txtTotal.Text = "";
            txtStockId.Text = "";
            txtProName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtUOM.Text = "";
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm ms = new MainForm();
            ms.Show();
        }

        private void getsumofcellvalue()
        {
            double sum = 0;
            for(int i = 0; i < guna2DataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(guna2DataGridView1.Rows[i].Cells[5].Value);
            }
            txtGrandTotal.Text = sum.ToString();
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

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            string text = txtGrandTotal.Text;

            if (!int.TryParse(text, out int number))
            {
                return;
            }

            string formattedNumber = number.ToString("0.000");

            txtGrandTotal.Text = formattedNumber;

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPurchaseId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUOM.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTotal.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btOpenReport_Click(object sender, EventArgs e)
        {
            PurchaseReportForm prf = new PurchaseReportForm();
            prf.ShowDialog();
        }
    }
}
