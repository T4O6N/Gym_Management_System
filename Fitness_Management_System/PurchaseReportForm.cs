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
    public partial class PurchaseReportForm : Form
    {
        public PurchaseReportForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.purchaseTb' table. You can move, or remove it, as needed.
            this.purchaseTbTableAdapter.Fill(this.dataSet1.purchaseTb);

            this.reportViewer1.RefreshReport();
        }
    }
}
