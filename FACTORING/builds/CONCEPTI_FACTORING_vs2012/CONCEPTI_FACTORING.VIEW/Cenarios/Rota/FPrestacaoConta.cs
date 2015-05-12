using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using CLvalidacao;
using System.Transactions;
using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data.Entidades;
using Concepti.Factoring.Business.Classes;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Rotas
{
    public partial class FPrestacaoConta : Form
    {
        public FPrestacaoConta()
        {
            InitializeComponent();
            bindVendedores();
        }


        private Rota _Rota
        {
            get
            {
               Rota rota = (new RotaDAO().Find(r => r.COD_VENDEDOR == ((Vendedor)cmbVendedores.SelectedItem).COD_VENDEDOR && r.CONCLUIDA == false).First<Concepti.Factoring.Data.Entidades.Rota>());
                return rota;
            }
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

        private void bindVendedores()
        {

            cmbVendedores.DataSource = new VendedorBO().buscaVendedoresComRota();
            cmbVendedores.SelectedIndex = -1;
        }

        private void bindDespesas()
        {
            cmbTipoDespesa.DataSource = new TipoDespesaDAO().GetAll().ToList<TipoDespesa>();
        }

        private void bindContratos(Vendedor vendedor)
        {
            gridContratos.DataSource = new VendedorBO(vendedor).buscarDadosDosContratosFirmadosAtuais();

        }

        private Decimal totalizarValorContratos()
        {
            Decimal retorno = 0;

            for (int i = 0; i < gridContratos.RowCount; i++)
            {
                retorno += decimal.Parse(gridContratos["VALOR", i].Value.ToString());
            }
            return retorno;
        }

        private void bindPanel()
        {
            gridDespesas.Rows.Clear();
            Vendedor vend = (Vendedor)cmbVendedores.SelectedItem;
            bindContratos(vend);
            Decimal valorContratos = totalizarValorContratos();
            Decimal fundo = decimal.Parse(new RotaDAO().Find(r => r.COD_VENDEDOR == vend.COD_VENDEDOR && r.CONCLUIDA == false).First().FUNDO.ToString());
            Decimal totalRecebido = new Concepti.Factoring.Business.Classes.RotaBO(new RotaDAO().Find(r => r.COD_VENDEDOR == vend.COD_VENDEDOR && r.CONCLUIDA == false).First()).pegarTotalBoletosBaixados();
            Decimal complemento = 0;
            if (valorContratos > (fundo + totalRecebido))
            {
                complemento = valorContratos - (fundo + totalRecebido);
            }
            
            bindDespesas();
            lblRecebido.Text = string.Format("{0:c}", totalRecebido);
            lblVendedor.Text = vend.NOME;
            lblValorSaida.Text = string.Format("{0:c}", fundo);
            lblSaldo.Text = string.Format("{0:c}", (((fundo+totalRecebido+complemento) - valorContratos)));
            lblTotalContratos.Text = string.Format("{0:c}", valorContratos);
            lblComplemento.Text = string.Format("{0:c}", complemento);
            pnPrestacao.Visible = true;

        }

        private void Reset()
        {
            gridDespesas.Rows.Clear();
            cmbVendedores.SelectedIndex = -1;
            cmbTipoDespesa.SelectedIndex = -1;
            txtValorDespesa.Text = "";
            pnPrestacao.Visible = false;
       
        }

        private void Cancelar()
        {
            gridDespesas.Rows.Clear();
            cmbVendedores.SelectedIndex = -1;
            cmbTipoDespesa.SelectedIndex = -1;
            txtValorDespesa.Text = "";
            
        }

        private void AddDespesa()
        {

            decimal saldo = decimal.Parse(lblSaldo.Text.Remove(0, 2));
            decimal despesa =  decimal.Parse(txtValorDespesa.Text.Replace(".", ","));
            decimal saldoAtual = saldo - despesa;
            decimal complemento = decimal.Parse(lblComplemento.Text.Remove(0,2));
            if (saldoAtual <= 0)
            {
                if (decimal.Parse(txtValorDespesa.Text.Replace(",", ".")) > decimal.Parse(lblSaldo.Text.Remove(0, 2)))
                complemento += Math.Abs(decimal.Parse(txtValorDespesa.Text.Replace(".", ",")) - decimal.Parse(lblSaldo.Text.Remove(0, 2)));
                lblComplemento.Text = string.Format("{0:c}", complemento);
                lblSaldo.Text = string.Format("{0:c}", 0);
            }
            else
            {

                lblSaldo.Text = string.Format("{0:c}", saldoAtual);
            }
            gridDespesas.Rows.Add();
            gridDespesas.Rows[gridDespesas.Rows.Count - 1].Cells["cod_despesa"].Value = ((TipoDespesa)cmbTipoDespesa.SelectedItem).COD_TIPO_DESPESA;
            gridDespesas.Rows[gridDespesas.Rows.Count - 1].Cells["TIPO"].Value = ((TipoDespesa)cmbTipoDespesa.SelectedItem).DESCRICAO_DESPESA;
            gridDespesas.Rows[gridDespesas.Rows.Count - 1].Cells["CUSTO"].Value = string.Format("{0:F}", decimal.Parse(txtValorDespesa.Text.Replace(".", ",")));
            Util.LimparForm(gbDespesa);

        }

        private void RemDespesa()
        {
            if (gridDespesas.CurrentCell.ColumnIndex == gridDespesas.ColumnCount - 1)
            {
                if(decimal.Parse(lblComplemento.Text.Remove(0,2)) > 0)
                    {
                    if (decimal.Parse(gridDespesas.CurrentRow.Cells["CUSTO"].Value.ToString()) > decimal.Parse(lblComplemento.Text.Remove(0, 2)))
                    {                        
                        lblSaldo.Text = string.Format("{0:c}",((decimal.Parse(gridDespesas.CurrentRow.Cells["CUSTO"].Value.ToString()) - decimal.Parse(lblComplemento.Text.Remove(0, 2)))));
                        lblComplemento.Text = string.Format("{0:c}", 0);
                        gridDespesas.Rows.Remove(gridDespesas.CurrentRow);
                    }
                    else
                    {
                        if (decimal.Parse(lblSaldo.Text.Remove(0, 2)) == 0)
                        {
                            //decimal saldoAtual = decimal.Parse(lblSaldo.Text.Remove(0, 2)) + decimal.Parse(gridDespesas.CurrentRow.Cells["CUSTO"].Value.ToString());
                            //lblSaldo.Text = string.Format("{0:c}", saldoAtual);
                            lblComplemento.Text = string.Format("{0:c}", (decimal.Parse(lblComplemento.Text.Remove(0, 2))) - (decimal.Parse(gridDespesas.CurrentRow.Cells["CUSTO"].Value.ToString())));
                            gridDespesas.Rows.Remove(gridDespesas.CurrentRow);

                        }
                    }
                    
                }

                
                Util.LimparForm(gbDespesa);
            }

        }

        private void SalvarItensDespesa()
        {
            ItemDespesaDAO itemDAO = new ItemDespesaDAO();
            try
            {
                for (int i = 0; i < gridDespesas.Rows.Count; i++)
                {
                    ItemDespesa item = new ItemDespesa();
                    item.COD_ROTA = _Rota.COD_ROTA;
                    item.COD_TIPO_DESPESA = int.Parse(gridDespesas["cod_despesa", i].Value.ToString());
                    item.VALOR = decimal.Parse(gridDespesas["CUSTO", i].Value.ToString());
                    itemDAO.Add(item);
                }
                itemDAO.SaveChanges();
            }
            catch
            {
                throw new Exception("Erro ao Salvar Itens.");
            }
        }

        private void SalvarRetornoSaldo(decimal saldo)
        {
            //bool sucesso;
            //movimento        movimento = new movimento();
            //movimentorota    movimentoRota = new movimentorota();
            //MovimentoDAO     movimentoDao = new MovimentoDAO();
            //MovimentoRotaDAO movimentoRotaDao = new MovimentoRotaDAO();
            //using (TransactionScope scope = new TransactionScope())
            //{
            //    try
            //    {
            //        movimento.COD_TIPO_MOVIMENTO = 2;
            //        movimento.MOMENTO = DateTime.Now;
            //        movimento.VALOR = saldo;
            //        movimentoDao.Add(movimento);
            //        movimentoDao.SaveChanges();

            //        movimentoRota.COD_MOVIMENTO = movimento.COD_MOVIMENTO;
            //        movimentoRota.COD_ROTA = _Rota.COD_ROTA;
            //        movimentoRotaDao.Add(movimentoRota);
            //        movimentoRotaDao.SaveChanges();

            //        sucesso = true;

            //    }
            //    catch
            //    {
            //        sucesso = false;
            //        throw new EntityException("Erro.");
            //    }

            //    if (sucesso)
            //    {
            //        scope.Complete();
            //    }

            //}
            new Concepti.Factoring.Business.Classes.RotaBO(_Rota).RegistrarMovimento(saldo, 2);
        }

        private void ComplementarRota(decimal valor)
        {
            //bool sucesso;
            //movimento movimento = new movimento();
            //movimentorota movimentoRota = new movimentorota();
            //MovimentoDAO movimentoDao = new MovimentoDAO();
            //MovimentoRotaDAO movimentoRotaDao = new MovimentoRotaDAO();
            //using (TransactionScope scope = new TransactionScope())
            //{
            //    try
            //    {
            //        movimento.COD_TIPO_MOVIMENTO = 1;
            //        movimento.MOMENTO = DateTime.Now;
            //        movimento.VALOR = valor;
            //        movimentoDao.Add(movimento);
            //        movimentoDao.SaveChanges();

            //        movimentoRota.COD_MOVIMENTO = movimento.COD_MOVIMENTO;
            //        movimentoRota.COD_ROTA = _Rota.COD_ROTA;
            //        movimentoRotaDao.Add(movimentoRota);
            //        movimentoRotaDao.SaveChanges();

            //        sucesso = true;

            //    }
            //    catch
            //    {
            //        sucesso = false;
            //        throw new EntityException("Erro ao registrar complemento rota.");
            //    }

            //    if (sucesso)
            //    {
            //        scope.Complete();
            //    }

            //}
            new Concepti.Factoring.Business.Classes.RotaBO(_Rota).RegistrarMovimento(valor, 1);
        }

        private void FinalizarRota()
        {
            bool sucesso;
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew,new TimeSpan(0,0,120)))
            {
                try
                {
                    decimal saldoFinal = decimal.Parse(lblSaldo.Text.Remove(0, 2));
                    decimal pegouComEmpresa = decimal.Parse(lblComplemento.Text.Remove(0,2));
                    Concepti.Factoring.Business.Classes.RotaBO rotaBO = new Concepti.Factoring.Business.Classes.RotaBO(_Rota);
                    SalvarItensDespesa();

                    if (saldoFinal > 0)
                    {
                        MessageBox.Show("Há um saldo de " + string.Format("{0:c}", saldoFinal) + " desta rota. Este dinheiro deve retornar ao caixa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SalvarRetornoSaldo(saldoFinal);
                    }

                    if (pegouComEmpresa > 0)
                    {
                        ComplementarRota(pegouComEmpresa);
                    }

                    rotaBO.FecharRota();
                    sucesso = true;
                }
                catch
                {
                    sucesso = false;
                    throw new Exception("Erro ao finalizar rota.");
                }
                if (sucesso)
                {
                    scope.Complete();
                }
            }
        }

        #endregion

        private void cmbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVendedores.SelectedIndex != -1)
                bindPanel();
            else Reset();
        }

        private void btAdicionarDespesa_Click(object sender, EventArgs e)
        {

            if (validar(pnPrestacao))
            {
                try
                {
                    AddDespesa();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a prestação de contas atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cancelar();

                if (MessageBox.Show("Deseja sair da prestação de contas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
        }

        private void txtValorDespesa_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtValorDespesa.Text))
            {
                errorProvider1.SetError(txtValorDespesa, "Campo Obrigatório!");
            }
            else if (!validacao.NumeroDecimal(txtValorDespesa.Text))
            {
                errorProvider1.SetError(txtValorDespesa, "Apenas Números!");
            }
            else
                errorProvider1.SetError(txtValorDespesa, "");
        }

        private void gridDespesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RemDespesa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente finalizar esta rota? Confira os dados e clique em Sim para continuar ou Não para retornar.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    FinalizarRota();
                    MessageBox.Show("Rota Finalizada com Sucesso! Vendedor disponível para uma nova rota.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    bindVendedores();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Dispose();
                }
            }
        }
    }
}
