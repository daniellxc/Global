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
using CLvalidacao;
using System.Transactions;
using Concepti.Factoring.Data.Entidades;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Emprestimo
{
    public partial class FContratacao : Form
    {
        public FContratacao()
        {
            InitializeComponent();
        }

       

        #region Métodos

        private bool validar(Control c)
        {
            bool controle = true;
            foreach (Control c1 in c.Controls)
            {
                if (c1.GetType().ToString().Contains("GroupBox"))
                    foreach (Control c2 in c1.Controls)
                    {
                        if (c2.GetType().ToString().Contains("TextBox"))
                        {
                            c2.Focus();
                            this.Validate();
                            if (!errorProvider1.GetError(c2).Equals(""))
                                return false;
                        }

                    }

            }

            return controle;

        }
           

        private void bindClientes()
        {
             
            gridClientes.DataSource = new ContratanteDAO().Find(c=>c.NOME.Contains(txtNomeCliente.Text)).ToList<Contratante>();
           
            gridClientes.Visible = true;

        }

       

        private void bindVendedores()
        {

            cmbVendedores.DataSource = new ContratoBO().buscaVendedoresComRotaArea(((Contratante)gridClientes.CurrentRow.DataBoundItem).COD_AREA);
            if (cmbVendedores.Items.Count == 0)
            {
               
                cmbVendedores.Enabled = false;
                txtJuros.Enabled = false;
                txtPeriodo.Enabled = false;
                txtJuros.Enabled = false;
                txtValor.Enabled = false;
                cmbPeriodicidade.Enabled = false;
                btContratar.Enabled = false;
                MessageBox.Show("Não há vendedores desta área com rota aberta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmbVendedores.Enabled = true;
                txtJuros.Enabled = true;
                txtPeriodo.Enabled = true;
                txtValor.Enabled = true;
                txtJuros.Enabled = true;
                cmbPeriodicidade.Enabled = true;
                btContratar.Enabled = true;
            }
        }

        private void bindPeriodicidade()
        {
            cmbPeriodicidade.DataSource = new PeriodicidadeDAO().Find(p=>p.ATIVO == true).ToList<Periodicidade>();
            
        }

        private void bindPanelContratação()
        {
            lblCliente.Text = ((Contratante)gridClientes.CurrentRow.DataBoundItem).NOME;
            lblArea.Text = ((Contratante)gridClientes.CurrentRow.DataBoundItem).AREA_FK.NOME;
            gbContratacao.Visible = true;
            bindPeriodicidade();
            bindVendedores();
        }

        private Contrato Contratar(Contratante contratante)
        {
           
            Contrato _contrato = new Contrato();
            ContratoDAO _contratoDAO = new ContratoDAO();
            using (TransactionScope scope = new TransactionScope())
            {
                bool sucesso = false;
                try
                {
                    _contrato.COD_CONTRATANTE = contratante.COD_CONTRATANTE;
                    _contrato.COD_PERIODICIDADE = ((Periodicidade)cmbPeriodicidade.SelectedItem).COD_PERIODICIDADE;
                    _contrato.DATA_ABERTURA = DateTime.Parse(DateTime.Now.ToShortDateString());
                    _contrato.JUROS = decimal.Parse(txtJuros.Text.Replace('.', ','));
                    _contrato.PERIODO = int.Parse(txtPeriodo.Text);
                    _contrato.VALOR = decimal.Parse(txtValor.Text.Replace('.', ','));
                    _contrato.COD_ROTA = (new RotaDAO().Find(r => r.COD_VENDEDOR == ((Vendedor)cmbVendedores.SelectedItem).COD_VENDEDOR && r.CONCLUIDA == false).First()).COD_ROTA;
                    _contrato.ATIVO = true;
                    _contratoDAO.Add(_contrato);
                    _contratoDAO.SaveChanges();
                    
                    //if (new Concepti.Factoring.Business.Classes.Rota(_contrato.rota).podeContratar())
                    //{
                        
                    //    sucesso = true;
                    //}
                    //else
                    //{
                        
                    //    sucesso = false;
                    //    throw new Exception("Não há saldo para realizar esta contratação.");
                    //}
                    sucesso = true;

                }
                catch(Exception ex)
                {
                    sucesso = false;
                    throw new Exception(ex.Message);
                   
                }
                if (sucesso)
                {
                    scope.Complete();
                }
            }
       

            return _contrato;
        }

        private void GerarBoletos(Contrato contrato)
        {
            Contrato c = new ContratoBO().Find(co => co.COD_CONTRATO == contrato.COD_CONTRATO).First();
            new ContratoBO(c).gerarBoletos();
        }

        private void EsconderCampos()
        {
            gbContratacao.Visible = false;
            gridClientes.Visible = false;
        }
        #endregion

        private void btBuscar_Click(object sender, EventArgs e)
        {
           
            bindClientes();
        }

        private void gridClientes_DoubleClick(object sender, EventArgs e)
        {

            bindPanelContratação();
            //txtPeriodo.Focus();
        }

        private void btContratar_Click(object sender, EventArgs e)
        {
            
            if(validar(this)){
            Contratante _contratante = (Contratante)gridClientes.CurrentRow.DataBoundItem;
            Contrato contrato;
            if (decimal.Parse(txtValor.Text.Replace('.',',')) <= _contratante.LIMITE)
            {
                
                    try
                    {
                        contrato = Contratar(_contratante);
                        GerarBoletos(contrato);
                        MessageBox.Show("Operação Realizada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Util.LimparForm(this);
                        EsconderCampos();
                        

                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Erro! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                
            }
            else
            {
                MessageBox.Show("Valor superior ao limite de crédito concedido ao cliente.");
            }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPeriodo_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtPeriodo.Text))
            {
                errorProvider1.SetError(txtPeriodo, "Campo Obrigatório!");
               // e.Cancel = true;
            }
            else if (!validacao.NumeroInteiro(txtPeriodo.Text))
            {
                errorProvider1.SetError(txtPeriodo, "Informe Apenas Números!");
                //e.Cancel = true;
            }
            else errorProvider1.SetError(txtPeriodo, "");
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtValor.Text))
            {
                errorProvider1.SetError(txtValor, "Campo Obrigatório!");
                //e.Cancel = true;
            }
            else if (!validacao.NumeroDecimal(txtValor.Text))
            {
                errorProvider1.SetError(txtValor, "Informe Apenas Números!");
            }
            else errorProvider1.SetError(txtValor, "");
        }

        private void txtJuros_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtValor.Text))
            {
                errorProvider1.SetError(txtJuros, "Campo Obrigatório!");
               // e.Cancel = true;
            }
            else if (!validacao.NumeroDecimal(txtJuros.Text))
            {
                errorProvider1.SetError(txtValor, "Informe Apenas Números!");
            }
            else errorProvider1.SetError(txtJuros, "");
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindPanelContratação();
            txtPeriodo.Focus();
        }

     
    }
}
