using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class Payment : Form
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
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();
        }

        private void txtMemId_TextChanged(object sender, EventArgs e)
        {
            if (txtMemId.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select name_surname, total, duration from membershipTb where mem_id =@id ", cd.conder);
                cmd.Parameters.AddWithValue("@id", txtMemId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtMemberName.Text = dr.GetValue(0).ToString();
                    txtTotal.Text = dr.GetValue(1).ToString();
                    txtDuration.Text = dr.GetValue(2).ToString();
                }
                dr.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtMemId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPayment.Text == "")
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
            SqlCommand cmd = new SqlCommand("insert into paymentTb(mem_id,name_surname,duration,total,payment,date)values(@mem_id,@name_surname,@duration,@total,@payment,@date)", cd.conder);
            cmd.Parameters.AddWithValue("@mem_id", txtMemId.Text);
            cmd.Parameters.AddWithValue("@name_surname", txtMemberName.Text);
            cmd.Parameters.AddWithValue("@duration", txtDuration.Text);
            cmd.Parameters.AddWithValue("@total", txtTotal.Text);
            cmd.Parameters.AddWithValue("@payment", txtPayment.Text);
            cmd.Parameters.AddWithValue("@date", txtDate.Value.Date);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ເພີ່ມສໍາເລັດ", "ເພີ່ມຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ເພີ່ມບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtMemId.Text = "";
            txtMemberName.Text = "";
            txtDuration.Text = "";
            txtTotal.Text = "";
            txtPayment.Text = "";
            txtDate.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtMemId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPayment.Text == "")
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
            SqlCommand cmd = new SqlCommand("update paymentTb set name_surname=@name_surname,duration=@duration,total=@total,payment=@payment,date=@date where mem_id=@mem_id", cd.conder);
            cmd.Parameters.AddWithValue("@mem_id", txtMemId.Text);
            cmd.Parameters.AddWithValue("@name_surname", txtMemberName.Text);
            cmd.Parameters.AddWithValue("@duration", txtDuration.Text);
            cmd.Parameters.AddWithValue("@total", txtTotal.Text);
            cmd.Parameters.AddWithValue("@payment", txtPayment.Text);
            cmd.Parameters.AddWithValue("@date", txtDate.Value.Date);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ແກ້ໄຂແລ້ວ", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ແກ້ໄຂບໍ່ໄດ້", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtMemId.Text = "";
            txtMemberName.Text = "";
            txtDuration.Text = "";
            txtTotal.Text = "";
            txtPayment.Text = "";
            txtDate.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtMemId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPayment.Text == "")
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
                cmd = new SqlCommand("delete paymentTb where mem_id=@mem_id", cd.conder);
            cmd.Parameters.AddWithValue("@mem_id", txtMemId.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ລົບຂໍ້ມູນສໍາເລັດ", "ລົບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtMemId.Text = "";
            txtMemberName.Text = "";
            txtDuration.Text = "";
            txtTotal.Text = "";
            txtPayment.Text = "";
            txtDate.Text = "";
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
            adt = new SqlDataAdapter("select * from paymentTb where name_surname='" + txtSearch.Text + "'", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMemberName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDuration.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTotal.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPayment.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDate.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
