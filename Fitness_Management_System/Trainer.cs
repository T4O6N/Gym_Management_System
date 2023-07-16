using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Management_System
{
    public partial class Trainer : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showinfo()
        {
            adt = new SqlDataAdapter("select * from trainerTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີເທັນເນີ";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ແລະນາມສະກຸນ";
            guna2DataGridView1.Columns[2].HeaderText = "ອີເມວ";
            guna2DataGridView1.Columns[3].HeaderText = "ເບີໂທ";
            guna2DataGridView1.Columns[4].HeaderText = "ເພດ";
            guna2DataGridView1.Columns[5].HeaderText = "ວັນທີ່ສະໝັກ";
            guna2DataGridView1.Columns[6].HeaderText = "ທີ່ຢູ່";
            guna2DataGridView1.Columns[7].HeaderText = "ເງີນເດືອນ";
            guna2DataGridView1.Columns[8].HeaderText = "ຮູບ";
        }
        public Trainer()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.guna2DataGridView1_DataError);
        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();
        }

        private void btPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Title = "Open Image";
            ofdlg.Filter = "Image Files(*.JPG;*.PNG;*.GiF) |*.JPG;*.PNG;*.GiF";

            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                pichoupbox.Image = Image.FromFile(ofdlg.FileName);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtTrainerId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtTrainerName.Text == "")
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
            Image pic = pichoupbox.Image;
            ImageConverter Converter = new ImageConverter();
            var ImageConvert = Converter.ConvertTo(pic, typeof(byte[]));
            {
                SqlCommand cmd = new SqlCommand("insert into trainerTb(trainer_id,trainer_name,mail,tel,gender,doj,address,salary,pic)values(@trainer_id,@trainer_name,@mail,@tel,@gender,@doj,@address,@salary,@pic)", cd.conder);
                cmd.Parameters.AddWithValue("@trainer_id", txtTrainerId.Text);
                cmd.Parameters.AddWithValue("@trainer_name", txtTrainerName.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@gender", txtGen.Text);
                cmd.Parameters.AddWithValue("@doj", txtDoj.Value.Date);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@pic", ImageConvert);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    showinfo();
                    MessageBox.Show("ເພີ່ມສໍາເລັດ", "ເພີ່ມຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("ເພີ່ມບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
                }
                txtTrainerId.Text = "";
                txtTrainerName.Text = "";
                txtEmail.Text = "";
                txtTel.Text = "";
                txtGen.Text = null;
                txtDoj.Text = null;
                txtAddress.Text = "";
                txtSalary.Text = null;
                pichoupbox.Image = null;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtTrainerId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtTrainerName.Text == "")
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
            Image pic = pichoupbox.Image;
            ImageConverter Converter = new ImageConverter();
            var ImageConvert = Converter.ConvertTo(pic, typeof(byte[]));

            SqlCommand cmd = new SqlCommand("update trainerTb set trainer_name=@trainer_name,@mail=@mail,tel=@tel,gender=@gender,doj=@doj,address=@address,salary=@salary,pic=@pic where trainer_id=@trainer_id", cd.conder);
            cmd.Parameters.AddWithValue("@trainer_id", txtTrainerId.Text);
            cmd.Parameters.AddWithValue("@trainer_name", txtTrainerName.Text);
            cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@gender", txtGen.Text);
            cmd.Parameters.AddWithValue("@doj", txtDoj.Value.Date);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
            cmd.Parameters.AddWithValue("@pic", ImageConvert);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ແກ້ໄຂແລ້ວ", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ແກ້ໄຂບໍ່ໄດ້", "ແກ້ໄຂຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtTrainerId.Text = "";
            txtTrainerName.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtGen.Text = null;
            txtDoj.Text = null;
            txtAddress.Text = "";
            txtSalary.Text = null;
            pichoupbox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (txtTrainerId.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtTrainerName.Text == "")
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
            cmd = new SqlCommand("delete trainerTb where trainer_id=@trainer_id", cd.conder);
            cmd.Parameters.AddWithValue("@trainer_id", txtTrainerId.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ລົບຂໍ້ມູນສໍາເລັດ", "ລົບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtTrainerId.Text = "";
            txtTrainerName.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtGen.Text = null;
            txtDoj.Text = null;
            txtAddress.Text = "";
            txtSalary.Text = null;
            pichoupbox.Image = null;
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
            adt = new SqlDataAdapter("select * from trainerTb where trainer_name ='" + txtSearch.Text + "'", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTrainerId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTrainerName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTel.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGen.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDoj.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSalary.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void guna2DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.guna2DataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.guna2DataGridView1_DataError);
        }
    }
}
