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
using Microsoft.Reporting.WinForms;

namespace Preceptoria_Don_Bosco
{
    public partial class testE : Form
    {
        string connectionString;
        string query;
        SqlConnection connection;
        SqlDataAdapter adapter;

        public testE()
        {
            InitializeComponent();
        }

        private void testE_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Preceptoria_Don_Bosco.Properties.Settings.PreceptoriaConnectionString"].ConnectionString;
            llenar();
        }

        private void llenar()
        {  
            #region estudio
            query = "SELECT * FROM Estudio";
            EstudioDS estudio = new EstudioDS();
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(estudio, estudio.Tables[0].TableName);
            ReportDataSource reds = new ReportDataSource("EstduioReportDS", estudio.Tables[0]);
            #endregion

            #region Conducta
            query = "SELECT * FROM Conducta";
            ConductaDS conducta = new ConductaDS();
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(conducta, conducta.Tables[0].TableName);
            ReportDataSource rconds = new ReportDataSource("ConductaReportDS", conducta.Tables[0]);
            #endregion

            #region Citacion
            query = "SELECT * FROM Citacion";
            CitacionDS citacion = new CitacionDS();
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(citacion, citacion.Tables[0].TableName);
            ReportDataSource rcitds = new ReportDataSource("CitacionReportDS", citacion.Tables[0]);
            #endregion

            #region Asistencia
            query = "SELECT * FROM Faltas";
            AsistenciaDS asistencia = new AsistenciaDS();
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(asistencia, asistencia.Tables[0].TableName);
            ReportDataSource rads = new ReportDataSource("AsistenciaReportDS", asistencia.Tables[0]);
            #endregion
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reds);
            this.reportViewer1.LocalReport.DataSources.Add(rconds);
            this.reportViewer1.LocalReport.DataSources.Add(rcitds);
            this.reportViewer1.LocalReport.DataSources.Add(rads);

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("NombreParam", "nombre"));
            parameters.Add(new ReportParameter("DocParam", "40492474"));
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

    }
}
