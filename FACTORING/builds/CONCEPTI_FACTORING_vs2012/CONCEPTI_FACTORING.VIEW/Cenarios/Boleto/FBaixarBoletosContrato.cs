using Concepti.Factoring.Business;
using Concepti.Factoring.Business.Classes;
using Concepti.Factoring.Data.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Boletos
{
    public partial class FBaixarBoletosContrato : Form
    {
        public FBaixarBoletosContrato()
        {
            InitializeComponent();
            Inicia();
        }

        #region Propriedades

        private string NomeCliente
        {
            get
            {
                return txtNomeCliente.Text;
            }
        }


        private Contratante _Contratante { get; set; }

        private Contrato _Contrato { get; set; }
        #endregion

        #region Métodos

        private void Inicia()
        {
            gbAcao.Visible = false;
            gridClientes.Visible = false;
            gridContratos.Visible = false;
        }

        private void BindClientes()
        {
            gridClientes.DataSource = new ContratanteBO().Consultar(NomeCliente);
            gridClientes.Visible = true;
            gridClientes.Enabled = gridClientes.Rows.Count > 0;
         
        }

        private void BindContratos(int codContratante)
        {
            gridContratos.DataSource = new ContratoBO().ContratosAbertosDoContrante(codContratante);
            gridContratos.Visible = true;
            gridContratos.Enabled = gridContratos.Rows.Count > 0;
        }


        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Inicia();
            BindClientes();
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                _Contratante = ((Contratante)gridClientes.CurrentRow.DataBoundItem);
                BindContratos(_Contratante.COD_CONTRATANTE);
            }
        }

        private void gridContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 )
            {
            _Contrato = (Contrato)gridContratos.CurrentRow.DataBoundItem;

            gbAcao.Visible = _Contrato != null;
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            gbAcao.Visible = false;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            try
            {
                if (new ContratoBO().BaixarBoletosAberto(_Contrato.COD_CONTRATO))
                {
                    MessageBox.Show("Operação realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Inicia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Operação não concluída." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

     
    }
}
