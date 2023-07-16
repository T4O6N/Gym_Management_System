using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Management_System
{
    internal class connection
    {
        public string con = "Data Source=LAPTOP-VPACFSN0\\SQLEXPRESS;Initial Catalog=GymDb;Integrated Security=True";
        public SqlConnection conder = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public void connectder()
        {
            conder.ConnectionString = con;
            conder.Open();
        }
    }
}
