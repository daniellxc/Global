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

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FConsultarCarnesCliente : Form
    {
        public FConsultarCarnesCliente()
        {
            InitializeComponent();
            
        }

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

            gridContratos.DataSource = _contratoDAO.Find(contr => contr.COD_CONTRATANTE.Equals(((Contratante)gridClientes.CurrentRow.DataBoundItem).COD_CONTRATANTE) && contr.ATIVO == true).ToList<Contrato>();

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
            DataTable dt = contratoBO.pegarBoletos();
          

        }

        private void gridContratos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ContratoBO contratoBO = new ContratoBO((Contrato)gridContratos.CurrentRow.DataBoundItem);
            DataTable dt = contratoBO.pegarBoletos();
            DataTable dt2 = contratoBO.pegarDadosContrato();
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FCarneCliente Cc = new FCarneCliente(dt,dt2);
            Cc.ShowDialog();
        }

     

    }
}
