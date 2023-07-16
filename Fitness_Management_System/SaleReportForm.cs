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
    public partial class SaleReportForm : Form
    {
        public SaleReportForm()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.saleTb' table. You can move, or remove it, as needed.
            this.saleTbTableAdapter.Fill(this.dataSet1.saleTb);

            this.reportViewer1.RefreshReport();
        }
    }
}
