using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Preceptoria_Don_Bosco
{
    public partial class Query : Form
    {
        String connectionString;
        String query;

        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;

        public Query()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Preceptoria_Don_Bosco.Properties.Settings.PreceptoriaConnectionString"].ConnectionString;
        }

        private void execute()
        {
            try
            {
                query = textBox1.Text;
                using (connection = new SqlConnection(connectionString))
                using (adapter = new SqlDataAdapter(query, connection))
                using (dataTable = new DataTable())
                {
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch {}
        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            execute();
        }
    }
}
