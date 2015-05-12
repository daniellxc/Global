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

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FConsultaContrato : Form
    {
        public FConsultaContrato()
        {
            InitializeComponent();
        }

        #region Propriedades

        private string _Nome { get { return txtNomeContratante.Text; } }

        private Contratante _Contratante
        {
            get
            {
                if (gridContratante.Rows.Count > 0)
                    if (gridContratante.CurrentRow.DataBoundItem != null)
                        return (Contratante)gridContratante.CurrentRow.DataBoundItem;
                    
                 return null;

            }

        }

        private Contrato _Contrato
        {
            get
            {
                if (gridContratos.Rows.Count > 0)
                    if (gridContratos.CurrentRow.DataBoundItem != null)
                        return (Contrato)gridContratos.CurrentRow.DataBoundItem;

                return null;

            }

        }

        #endregion


        #region Métodos

        private void Iniciar()
        {
            gbContratos.Visible = false;
            gbContratante.Visible = false;
            gbOpcoes.Visible = false;

        }

        private void BindContratantes()
        {
            gridContratante.DataSource = new ContratanteBO().Consultar(_Nome);
            gbContratante.Visible = true;

        }

        private void BindContratos()
        {
            if (_Contratante != null)
            {
                gridContratos.DataSource = new ContratoBO().ContratosDoContrante(_Contratante.COD_CONTRATANTE);
                gbContratos.Visible = true;
                gbOpcoes.Visible = false;
            }

        }

        private void BindOpcoes()
        {
            btnCancelar.Enabled = new ContratoBO(_Contrato).PodeCancelar();
            gbOpcoes.Visible = true;
                

        }

        private void CancelarContrato()
        {


        }

        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BindContratantes();
        }

        private void gridContratante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                BindContratos();
            }
        }

        private void gridContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindOpcoes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                new ContratoBO(_Contrato).CancelarContrato();
                
                BindContratos();
                MessageBox.Show("Operação finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
       
    }
}
