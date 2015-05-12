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
using System.IO;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FBoletos : Form
    {
        public FBoletos()
        {
            InitializeComponent();
        }

        public FBoletos(DataTable boletos)
        {
            InitializeComponent();

            ReportDocument report = new ReportDocument();
            
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath =  @"C:\JCExpress\RptBoletos.rdlc";
            ReportDataSource dataSource = new ReportDataSource("DataSet1", boletos);
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.LocalReport.Refresh();
            //Warning[] warnings;
            //string[] streamids;
            //string mimeType;
            //string encoding;
            //string extension;
            //byte[] bytes = reportViewer1.LocalReport.Render(
            //   "PDF", null, out mimeType, out encoding, out extension,
            //   out streamids, out warnings);
            //FileStream fs = new FileStream(@"c:\output.pdf", FileMode.Create);
            //fs.Write(bytes, 0, bytes.Length);
            //fs.Close();
            //System.Diagnostics.Process.Start(@"c:\output.pdf");
            //MessageBox.Show("Relatório exportado com sucesso", "Info");
        }

        private void FBoletos_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
        }
    }
}
