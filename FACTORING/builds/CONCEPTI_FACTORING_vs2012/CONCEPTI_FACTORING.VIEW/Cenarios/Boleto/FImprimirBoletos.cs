using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data;
using Concepti.Factoring.Business.Classes;
using Concepti.Factoring.Data.Entidades;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Boletos
{
    public partial class FImprimirBoletos : Form
    {
        public FImprimirBoletos()
        {
            InitializeComponent();
        }

        #region Propriedades

        public int TipoRelatorio {
            get
            {
                if (rdbTodos.Checked)
                    return 1;
                else
                    if (rdbAbertos.Checked)
                        return 2;
                return 1;

            }
        
        
        }

        #endregion

        #region Métodos

        private void bindClientes()
        {
            ContratanteDAO _contratanteDAO = new ContratanteDAO();

            gridClientes.DataSource = _contratanteDAO.Find(cont => cont.NOME.Contains(txtNomeCliente.Text)).ToList<Contratante>();

            gbContratantes.Visible = true;
            gbContratos.Visible = false;
        }

        private void bindContratos()
        {
            ContratoDAO _contratoDAO = new ContratoDAO();

            gridContratos.DataSource = _contratoDAO.Find(contr => contr.COD_CONTRATANTE.Equals(((Contratante)gridClientes.CurrentRow.DataBoundItem).COD_CONTRATANTE) && contr.ATIVO==true).ToList<Contrato>();

            gbContratos.Visible = true;

        }


        #endregion
        private void btPesquisarCliente_Click(object sender, EventArgs e)
        {
            bindClientes();
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindContratos();
        }

        private void gridContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ContratoBO contratoBO = new ContratoBO((Contrato)gridContratos.CurrentRow.DataBoundItem);
            DataTable dt = new DataTable();

            switch (TipoRelatorio.ToString())
            {
                case "1" :
                    dt = contratoBO.pegarBoletos();
                    break;
                case "2" :
                    dt = contratoBO.pegarBoletosAbertos();
                    break;
            }
              
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FBoletos fb = new Relatorio.FBoletos(dt);
            fb.ShowDialog();

        }

      

      
    }
}
