using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Preceptoria_Don_Bosco
{
    public partial class ang : UserControl
    {

        String connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;
        public ang()
        {
            InitializeComponent();            
        }

        private void ang_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                connectionString = ConfigurationManager.ConnectionStrings["Preceptoria_Don_Bosco.Properties.Settings.PreceptoriaConnectionString"].ConnectionString;
                string query = "SELECT * FROM Alumno";
                using (connection = new SqlConnection(connectionString))
                using (adapter = new SqlDataAdapter(query, connection))
                {
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
