using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concepti.Factoring.Business.Classes;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FConsultaCarnes : Form
    {
        public FConsultaCarnes()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FCarnes fCarnes = new FCarnes(new ContratoBO().pegarHistoricoContratos(txtNome.Text));
            fCarnes.ShowDialog();
        }
    }
}
