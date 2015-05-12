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
using Concepti.Factoring.Data.Entidades;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FClientes : Form
    {
        public FClientes()
        {
            InitializeComponent();
        }

        #region Métodos

        private void bindClientes()
        {
            ContratanteDAO _contratanteDAO = new ContratanteDAO();

            gridClientes.DataSource = _contratanteDAO.Find(cont => cont.NOME.Contains(txtNomeCliente.Text)).ToList<Contratante>();

            gridClientes.Visible = true;
        }

        #endregion

        private void btPesquisarCliente_Click(object sender, EventArgs e)
        {
            bindClientes();
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro.FCadastroCliente fc = new Cadastro.FCadastroCliente((Contratante)gridClientes.CurrentRow.DataBoundItem);
            fc.ShowDialog();
        }
    }
}
