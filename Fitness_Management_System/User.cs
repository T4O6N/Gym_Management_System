using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class User : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showinfo()
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
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm ms = new MainForm();
            ms.Show();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            ViewUser vu = new ViewUser();
            vu.TopLevel = false;
            panel1.Controls.Add(vu);
            vu.BringToFront();
            vu.Show();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtUserName.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPass.Text == "")
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
            SqlCommand cmd = new SqlCommand("insert into UserTb(username,lname,pass,con_pass,question,answer,tel,address,age,mail)values(@username,@lname,@pass,@con_pass,@question,@answer,@tel,@address,@age,@mail)", cd.conder);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@lname", txtLname.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            cmd.Parameters.AddWithValue("@con_pass", txtPassConfrim.Text);
            cmd.Parameters.AddWithValue("@question", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@answer", txtAnswer.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@age", dobAge.Value.Date);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
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
            };
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtUserName.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPass.Text == "")
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
            SqlCommand cmd = new SqlCommand("update userTb set username=@username,lname=@lname,pass=@pass,con_pass=@con_pass,question=@question,answer=@answer,tel=@tel,address=@address,age=@age,mail=@mail where username=@username", cd.conder);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@lname", txtLname.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            cmd.Parameters.AddWithValue("@con_pass", txtPassConfrim.Text);
            cmd.Parameters.AddWithValue("@question", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@answer", txtAnswer.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@age", dobAge.Text);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);


            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ແກ້ໄຂແລ້ວ", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ແກ້ໄຂບໍ່ໄດ້", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtUserName.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtPass.Text == "")
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
                cmd = new SqlCommand("delete userTb where username=@username", cd.conder);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);

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

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPass.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassConfrim.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQuestion.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAnswer.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTel.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAddress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dobAge.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtMail.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

    }
}
