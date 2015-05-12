using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Reporting.WinForms;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FCarneCliente : Form
    {
        public FCarneCliente()
        {
            InitializeComponent();
        }


        public FCarneCliente(DataTable carne, DataTable cabecalho)
        {
            InitializeComponent();

            ReportDocument report = new ReportDocument();

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\JCExpress\RptCarnesCliente.rdlc";
            ReportDataSource dataSource = new ReportDataSource("DataSet1", carne);
            ReportDataSource dataSource2 = new ReportDataSource("DataSet2", cabecalho);
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.LocalReport.DataSources.Add(dataSource2);
            reportViewer1.LocalReport.Refresh();

        }

        private void FCarneCliente_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
