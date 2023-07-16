using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace Fitness_Management_System
{
    public partial class Membership : Form
    {
        SqlDataAdapter adt = new SqlDataAdapter();
        DataSet ds = new DataSet();
        connection cd = new connection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public void showinfo()
        {
            adt = new SqlDataAdapter("select * from membershipTb", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].HeaderText = "ໄອດີສະມາຊິກ";
            guna2DataGridView1.Columns[1].HeaderText = "ຊື່ແລະນາມສະກຸນ";
            guna2DataGridView1.Columns[2].HeaderText = "ທີ່ຢູ່";
            guna2DataGridView1.Columns[3].HeaderText = "ອີເມວ";
            guna2DataGridView1.Columns[4].HeaderText = "ເບີໂທ";
            guna2DataGridView1.Columns[5].HeaderText = "ເພດ";
            guna2DataGridView1.Columns[6].HeaderText = "ແພັກເກັດ";
            guna2DataGridView1.Columns[7].HeaderText = "ສະຖານະ";
            guna2DataGridView1.Columns[8].HeaderText = "ວັນທີ່ສະໝັກ";
            guna2DataGridView1.Columns[9].HeaderText = "ນໍ້າໝັກ";
            guna2DataGridView1.Columns[10].HeaderText = "ລວມທັງໝົດ";
            guna2DataGridView1.Columns[11].HeaderText = "ໄລຍະເວລາ";
            guna2DataGridView1.Columns[12].HeaderText = "ຮູບ";
        }
        public Membership()
        {
            InitializeComponent();
            this.guna2DataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.guna2DataGridView1_DataError);
        }

        SqlDataAdapter dapkname = new SqlDataAdapter();
        DataSet dspkname = new DataSet();
        connection cdpkname = new connection();
        SqlCommand cmdpkname = new SqlCommand();
        DataTable dtpkname = new DataTable();

        public void packagename()
        {
            SqlDataAdapter dapkname = new SqlDataAdapter("select package_name,package_price from packageTb", cdpkname.conder);
            dapkname.Fill(dtpkname);
            txtPackage.DataSource = dtpkname;
            txtPackage.DisplayMember = "package_name";
            txtPackage.ValueMember = "package_name";
            txtprice.DataSource = dtpkname;
            txtprice.DisplayMember = "package_price";
            txtprice.ValueMember = "package_price";
        }

        private void Membership_Load(object sender, EventArgs e)
        {
            cd.connectder();
            showinfo();

            cdpkname.connectder();
            packagename();
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
            if (txtLahutmem.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtNameSurname.Text == "")
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
                    SqlCommand cmd = new SqlCommand("insert into membershipTb(mem_id,name_surname,address,mail,tel,gender,package,status,doj,weight,total,duration,pic)values(@mem_id,@name_surname,@address,@mail,@tel,@gender,@package,@status,@doj,@weight,@total,@duration,@pic)", cd.conder);
                    cmd.Parameters.AddWithValue("@mem_id", txtLahutmem.Text);
                    cmd.Parameters.AddWithValue("@name_surname", txtNameSurname.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                    cmd.Parameters.AddWithValue("@gender", txtGen.Text);
                    cmd.Parameters.AddWithValue("@package", txtPackage.Text);
                    cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                    cmd.Parameters.AddWithValue("@doj", txtDoj.Value.Date);
                    cmd.Parameters.AddWithValue("@weight", txtWeight.Text);
                    cmd.Parameters.AddWithValue("@total", txtprice.Text);
                    cmd.Parameters.AddWithValue("@duration", txtDuration.Text);
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
                    txtLahutmem.Text = "";
                    txtNameSurname.Text = "";
                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtTel.Text = "";
                    txtGen.Text = null;
                    txtPackage.Text = "";
                    txtStatus.Text = null;
                    txtDoj.Text = "";
                    txtWeight.Text = "";
                    txtprice.Text = "";
                    txtDuration.Text = null;
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
            if (txtLahutmem.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtNameSurname.Text == "")
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

                SqlCommand cmd = new SqlCommand("update membershipTb set name_surname=@name_surname,address=@address,mail=@mail,tel=@tel,gender=@gender,package=@package,status=@status,doj=@doj,weight=@weight,total=@total,duration=@duration,pic=@pic where mem_id=@mem_id", cd.conder);
                cmd.Parameters.AddWithValue("@mem_id", txtLahutmem.Text);
                cmd.Parameters.AddWithValue("@name_surname", txtNameSurname.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@gender", txtGen.Text);
                cmd.Parameters.AddWithValue("@package", txtPackage.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@doj", txtDoj.Value.Date);
                cmd.Parameters.AddWithValue("@weight", txtWeight.Text);
                cmd.Parameters.AddWithValue("@total", txtprice.Text);
                cmd.Parameters.AddWithValue("@duration", txtDuration.Text);
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
                txtLahutmem.Text = "";
                txtNameSurname.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtTel.Text = "";
                txtGen.Text = null;
                txtPackage.Text = "";
                txtStatus.Text = null;
                txtDoj.Text = "";
                txtWeight.Text = "";
                txtprice.Text = "";
                txtDuration.Text = null;
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
            if (txtLahutmem.Text == "")
            {
                errMsg += "ກະລຸນາໃສ່ຂໍ້ມູນ";
            }
            if (txtNameSurname.Text == "")
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
            cmd = new SqlCommand("delete membershipTb where mem_id=@mem_id", cd.conder);
            cmd.Parameters.AddWithValue("@mem_id", txtLahutmem.Text);

            if (cmd.ExecuteNonQuery() == 1)
            {
                showinfo();
                MessageBox.Show("ລົບຂໍ້ມູນສໍາເລັດ", "ລົບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("ລົບຂໍ້ມູນບໍ່ໄດ້", "ລົບຂໍ້ມູນ", MessageBoxButtons.OKCancel);
            }
            txtLahutmem.Text = "";
            txtNameSurname.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtGen.Text = null;
            txtPackage.Text = "";
            txtStatus.Text = null;
            txtDoj.Text = "";
            txtWeight.Text = "";
            txtprice.Text = "";
            txtDuration.Text = null;
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
            adt = new SqlDataAdapter("select * from membershipTb where name_surname='" + txtSearch.Text + "'", cd.conder);
            adt.Fill(ds);
            ds.Tables[0].Clear();
            adt.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLahutmem.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameSurname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddress.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTel.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGen.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPackage.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtStatus.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDoj.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtWeight.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtprice.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtDuration.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            byte[] imgData = (byte[])guna2DataGridView1.SelectedRows[0].Cells[12].Value;
            MemoryStream ms = new MemoryStream(imgData);
            pichoupbox.Image = Image.FromStream(ms);
        }

        private void guna2DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.guna2DataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.guna2DataGridView1_DataError);
        }
    }
}
