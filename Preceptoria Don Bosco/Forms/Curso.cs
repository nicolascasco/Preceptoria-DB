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
    public partial class Curso : Form
    {
        string curso = "Err";
        string año = "Err";

        String connectionString;
        String query;

        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;
        SqlCommand command;

        public Curso(string text, string año)
        {
            curso = text;
            this.año = año;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Preceptoria_Don_Bosco.Properties.Settings.PreceptoriaConnectionString"].ConnectionString;
        }

        private void Curso_Load(object sender, EventArgs e)
        {      
            this.Text = "Alumnos de " + curso + " " + año;
            #region switch curso
            switch (curso)
            {
                case "1°A":
                    curso = "Curso_1A";
                    break;
                case "1°B":
                    curso = "Curso_1B";
                    break;
                case "2°A":
                    curso = "Curso_2A";
                    break;
                case "2°B":
                    curso = "Curso_2B";
                    break;
                case "3°A":
                    curso = "Curso_3A";
                    break;
                case "3°B":
                    curso = "Curso_3B";
                    break;
                case "4 Nat.":
                    curso = "Curso_4Nat";
                    break;
                case "4 Soc.":
                    curso = "Curso_4Soc";
                    break;
                case "5 Nat.":
                    curso = "Curso_5Nat";
                    break;
                case "5 Soc.":
                    curso = "Curso_5Soc";
                    break;
                case "6 Nat.":
                    curso = "Curso_6Nat";
                    break;
                case "6 Soc.":
                    curso = "Curso_6Soc";
                    break;
            }
            #endregion
            buscar(nombreTextBox.Text);
            populateAlumnos();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            buscar(nombreTextBox.Text);
        }

        private void selectButton_Click(object sender, EventArgs e)//****
        {
            string name = dataGridView.CurrentRow.Cells[1].Value.ToString();
            string id = dataGridView.CurrentRow.Cells[2].Value.ToString();
            insert(name, id);
            populateAlumnos();
        }

        private void elimButton_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            eliminar(id);
            populateAlumnos(); 
        }

        private void insert(string nombre, string id)
        {
            for (int n = 1; n < 7; n++)
            {
                try
                {
                    query = "INSERT INTO " + curso + " (AlumnoId, año,etapa, Nombre) VALUES(" + id + ", " + año + "," + n.ToString() + ", '" + nombre + "')";
                    using (connection = new SqlConnection(connectionString))
                    using (command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void eliminar(string id)
        {
            query = "DELETE FROM " + curso + " where AlumnoId = " + id;
            using (connection = new SqlConnection(connectionString))
            using (command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void buscar(string busqueda)
        {
            query = "SELECT Nombre, NombrePlanilla, Documento FROM Alumno WHERE Nombre LIKE @Busqueda OR NombrePlanilla LIKE @Busqueda OR Documento LIKE @Busqueda";
            using (connection = new SqlConnection(connectionString))
            using (command = new SqlCommand(query, connection))
            using (adapter = new SqlDataAdapter(command))
            using (dataTable = new DataTable())
            {
                command.Parameters.AddWithValue("@Busqueda", '%' + busqueda + '%');
                dataGridView.DataSource = null;
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                dataGridView.Columns[0].Visible = false;
            }
        }//datagridview

        private void populateAlumnos()//listbox
        {
            query = "SELECT Nombre, AlumnoId FROM " + curso + " WHERE año = " + año + " GROUP BY Nombre, AlumnoId";
            using (connection = new SqlConnection(connectionString))
            using (command = new SqlCommand(query, connection))
            using (adapter = new SqlDataAdapter(command))
            using (dataTable = new DataTable())
            {
                dataGridView1.DataSource = null;
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[1].Visible = false;
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
