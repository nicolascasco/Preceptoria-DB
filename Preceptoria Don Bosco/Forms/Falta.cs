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
    public partial class Falta : Form
    {
        String connectionString;
        String query;

        SqlConnection connection;
        SqlCommand command;

        private string nombre;
        string id;

        public Falta(string nombre, string id)
        {
            InitializeComponent();

            this.nombre = nombre;
            this.id = id;
            connectionString = ConfigurationManager.ConnectionStrings["Preceptoria_Don_Bosco.Properties.Settings.PreceptoriaConnectionString"].ConnectionString;
        }

        private void Falta_Load(object sender, EventArgs e)
        {
            this.Text = nombre;
            comboBox1.Items.Add("Aula");
            comboBox1.Items.Add("E.F.");
            comboBox1.Items.Add("Tardanza");

            comboBox2.Visible = false;
            comboBox2.Items.Add("0.5");
            comboBox2.Items.Add("0.25");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        string falta;

            #region insert
            string diaSelec = (dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
           query = "WITH Tot as(SELECT SUM(Aula + [E.F.] + Tardanza) as suma FROM Faltas WHERE AlumnoId = @id)" + 
                    "INSERT INTO Faltas(AlumnoId, Fecha, [" + comboBox1.SelectedItem.ToString() + "], Justificacion, Total) " +
                    "VALUES (@id,  '" + diaSelec + "' , @falta, @justificacion, coalesce((SELECT suma FROM Tot) + @falta, @falta, @falta))";

            using (connection = new SqlConnection(connectionString))                                                                        
            using (command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);

                if (comboBox1.SelectedItem.ToString() == "Tardanza")
                {
                    falta = comboBox2.SelectedItem.ToString();
                }
                else
                {
                    falta = "1";
                }
                command.Parameters.AddWithValue("@falta", falta);

                string just;
                if (checkBox1.Checked)
                {
                    just = "1";
                }
                else
                {
                    just = "0";
                }
                command.Parameters.AddWithValue("@justificacion", just);
                command.ExecuteNonQuery();
                connection.Close();
            }
            #endregion

            #region update
           /* if (checkBox1.Checked)
            {
                query = "UPDATE Alumno SET FaltasJ = (FaltasJ + @falta) where Documento = @id";
            }
            else
            {
                query = "UPDATE Alumno SET FaltasI = (FaltasI + @falta) where Documento = @id";
            }
            using (connection = new SqlConnection(connectionString))
            using (command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@falta", falta);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
            }*/

            #endregion// no se usa 

            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox2.Visible = false;
            checkBox1.Checked = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Tardanza")
            {
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
            }
        }
    }
}
