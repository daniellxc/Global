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
using System.Data.Common;
using System.Transactions;
using Concepti.Factoring.Business.Classes;
using Concepti.Factoring.Data.Entidades;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Rotas
{
    public partial class FCadastroRota : Form
    {
        public FCadastroRota()
        {
            InitializeComponent();
            bindVendedores();
        }

        #region Métodos

        private void bindVendedores()
        {

            cmbVendedor.DataSource = new VendedorBO().buscarVendedoresSemRota();
            cmbVendedor.SelectedIndex = -1;
        }

        private void bindDadosRota()
        {
            lblDataInicio.Text = DateTime.Now.ToString();
            lblNomeVendedor.Text = ((Vendedor)cmbVendedor.SelectedItem).NOME;
            lblValorSaida.Text = String.Format("{0:c}", decimal.Parse(txtFundo.Text.Replace('.', ',')));
            pnDadosRota.Visible = true;
        }

        private void ConfirmarRota()
        {
            bool sucesso;
            try
            {
                
                RotaDAO rotaDao = new RotaDAO();
                MovimentoDAO movimentoDao = new MovimentoDAO();
                MovimentoRotaDAO movimentoRotaDao = new MovimentoRotaDAO();
                Rota novaRota = instanciarRota();
                MovimentoRota novoMovimentoRota = new MovimentoRota();
                Movimento novoMovimento = new Movimento();

                using (TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        rotaDao.Add(novaRota);
                        rotaDao.SaveChanges();

                        //instancia o movimento
                        novoMovimento.COD_TIPO_MOVIMENTO = 1;
                        novoMovimento.MOMENTO = novaRota.DATA_INICIO;
                        novoMovimento.VALOR = novaRota.FUNDO;
                        //salva o movimento
                        movimentoDao.Add(novoMovimento);
                        movimentoDao.SaveChanges();


                        //instancia movimento_rota
                        novoMovimentoRota.COD_MOVIMENTO = novoMovimento.COD_MOVIMENTO;
                        novoMovimentoRota.COD_ROTA = novaRota.COD_ROTA;
                        //salva movimento_rota
                        movimentoRotaDao.Add(novoMovimentoRota);
                        movimentoRotaDao.SaveChanges();
                        sucesso = true;
                    }
                    catch
                    {
                        sucesso = false;
                        throw new Exception("Erro ao criar rota.");
                    }
                
                    if (sucesso)
                    {
                        scope.Complete();
                    }

                   
                   
                }
            }
            catch
            {

                throw new Exception("Erro ao criar rota.");
            }


        }



        private Rota instanciarRota()
        {
            Rota rota = new Rota();

            RotaDAO rotaDao = new RotaDAO();

            rota.COD_VENDEDOR = ((Vendedor)cmbVendedor.SelectedItem).COD_VENDEDOR;
            rota.DATA_INICIO = DateTime.Parse(lblDataInicio.Text);
            rota.DATA_FIM = DateTime.MinValue;
            rota.FUNDO = decimal.Parse(txtFundo.Text.Replace('.', ','));
            rota.CONCLUIDA = false;
            return rota;

        }

        private void SalvarRota()
        {
            ConfirmarRota();

        }

        private void Reset()
        {
            bindVendedores();
            Util.LimparForm(this);  
            cmbVendedor.SelectedIndex = -1 ;
            gbFundo.Visible = false;
            pnDadosRota.Visible = false;
        }

        #endregion

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVendedor.SelectedIndex != -1)
            {
                gbFundo.Visible = true;
            }
            else
            {
                gbFundo.Visible = false;
                pnDadosRota.Visible = false;
            }
        }

        private void btConfirmarValor_Click(object sender, EventArgs e)
        {
            bindDadosRota();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btConfirmarRota_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Confirmar esta Rota?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    ConfirmarRota();
                    Reset();
                    MessageBox.Show("Rota Criada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }
    }
}