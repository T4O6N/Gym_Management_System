using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Management_System
{
    public partial class Login : Form
    {
        public string con = "Data Source=LAPTOP-VPACFSN0\\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtUser.Text;
            password = txtPass.Text;

            try
            {
                String querry = "Select * from userTb where username = '" + txtUser.Text + "' And pass  = '" + txtPass.Text + "'";
                SqlDataAdapter adt = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                adt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUser.Text;
                    password = txtPass.Text;

                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ລະຫັດ ຫຼື ຊື່ບໍ່ຖືກ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPass.Text = "";

                    txtUser.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {

            }
        }
    }
}
