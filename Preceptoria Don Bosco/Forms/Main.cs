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
    public partial class Main : Form
    {
        private Query FormQuery;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTab3.Text = "";
            cursosUserControl1.Visible = false;
            cursosUserControl1.Enabled = false;
            alumnosUserControl1.Visible = true;
            alumnosUserControl1.Enabled = true;
            alumnosUserControl1.BringToFront(); 
            tabInd.Width = lblTab1.Width;
            tabInd.Left = lblTab1.Left;
        }
         
        public void getAlumno(string nombre, string id)
        {
            alumnosUserControl1.Visible = false;
            alumnosUserControl1.Enabled = false;
            cursosUserControl1.Visible = false;
            cursosUserControl1.Enabled = false;
            informacionAlumno1.mostrarDatos(id);
            informacionAlumno1.Visible = true;
            informacionAlumno1.Enabled = true;
            informacionAlumno1.BringToFront();//sacar de los otros
            lblTab3.Text = nombre;
            tabInd.Width = lblTab3.Width;
            tabInd.Left = lblTab3.Left;          
        }   
         
        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customQuery();
        }

        private void lblTab1_Click(object sender, EventArgs e)
        {
            lblTab3.Text = "";
            informacionAlumno1.Visible = false;
            informacionAlumno1.Enabled = false;
            cursosUserControl1.Visible = false;
            cursosUserControl1.Enabled = false;
            alumnosUserControl1.Visible = true;
            alumnosUserControl1.Enabled = true;
            alumnosUserControl1.BringToFront();
            tabInd.Width = lblTab1.Width;
            tabInd.Left = lblTab1.Left;
            alumnosUserControl1.populateAlumnos();
        }

        private void lblTab2_Click(object sender, EventArgs e)
        {
            lblTab3.Text = "";
            informacionAlumno1.Visible = false;
            informacionAlumno1.Enabled = false;
            alumnosUserControl1.Visible = false;
            alumnosUserControl1.Enabled = false;
            cursosUserControl1.Visible = true;
            cursosUserControl1.Enabled = true;
            cursosUserControl1.BringToFront();
            tabInd.Width = lblTab2.Width;
            tabInd.Left = lblTab2.Left;
        }

        private void lblTab3_Click(object sender, EventArgs e)
        {
            
        }

        private void customQuery()
        {
            FormQuery = new Query();
            FormQuery.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            testE t = new testE();
            t.ShowDialog();
        }
    }
}
