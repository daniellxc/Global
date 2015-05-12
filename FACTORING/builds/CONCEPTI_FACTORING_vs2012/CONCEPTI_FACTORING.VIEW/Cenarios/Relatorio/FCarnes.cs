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
    public partial class FCarnes : Form
    {
        public FCarnes()
        {
            InitializeComponent();
        }

        public FCarnes(DataTable carnes)
        {
            InitializeComponent();
            ReportDocument document = new ReportDocument();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\JCExpress\RptCarnes.rdlc";
            ReportDataSource dataSource = new ReportDataSource("DataSet1", carnes);
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.LocalReport.Refresh();
        }

        private void FCarnes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
