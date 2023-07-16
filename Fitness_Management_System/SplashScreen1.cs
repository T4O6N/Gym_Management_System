using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Management_System
{
    public partial class SplashScreen1 : Form
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 4;

                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Login mf = new Login();
                mf.Show();
                this.Hide();
            }
        }
    }
}
