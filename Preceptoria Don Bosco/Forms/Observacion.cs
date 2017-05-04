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
    public partial class Observacion : Form
    {
        string nombre;
        string id;
        int caso;

        String connectionString;
        String query;
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;

        string[] casos = new string[] {"Estudio", "Conducta", "Citacion"};
        public Observacion(string n, string i, int c)
        {
            InitializeComponent();
            nombre = n;
            id = i;
            caso = c;
        }

        private void Observacion_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Preceptoria_Don_Bosco.Properties.Settings.PreceptoriaConnectionString"].ConnectionString;
            this.Text = nombre + ": " +  casos[caso];
            setup();
        }

        private void setup()
        {
        }

        private void guardar()
        {
            string fecha = bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd");
            query = "INSERT INTO " + casos[caso] + " VALUES(@id, '" + fecha + "', @descripcion)";
            using (connection = new SqlConnection(connectionString))
            using (command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@descripcion", richTextBox1.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                guardar();
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Err";
                notifyIcon1.BalloonTipText = "Err";
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.ShowBalloonTip(2000, "PRECEPTORIA DON BOSCO", "Guardado exitosamente", ToolTipIcon.Info);
                richTextBox1.Text = null;
            }
            catch (Exception ex)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Err";
                notifyIcon1.BalloonTipText = "Err";
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.ShowBalloonTip(3000, "PRECEPTORIA DON BOSCO", "No pudo ser guardado", ToolTipIcon.Error);
            }
        }
    }
}
