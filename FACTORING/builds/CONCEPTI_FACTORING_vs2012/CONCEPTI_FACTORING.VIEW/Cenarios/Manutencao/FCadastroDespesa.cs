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
using CLvalidacao;
using Concepti.Factoring.Data.Entidades;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao
{
    public partial class FCadastroDespesa : Form
    {
        public FCadastroDespesa()
        {
            InitializeComponent();
            bindComboDespesas();

        }
        #region Métodos
        private bool validar(Control c)
        {
            bool controle = true;
            foreach (Control c1 in c.Controls)
            {
                if (c1.GetType().ToString().Contains("GroupBox") || c1.GetType().ToString().Contains("Panel"))
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
        private void bindComboDespesas()
        {
            cmbDespesas.DataSource = new TipoDespesaDAO().GetAll().ToList<TipoDespesa>();
            cmbDespesas.SelectedIndex = -1;
        }
        private void bindDespesa()
        {
            txtDecricao.Text = ((TipoDespesa)cmbDespesas.SelectedItem).DESCRICAO_DESPESA;
            pnInfo.Visible = true;
        }

        private void SalvarDespesa()
        {
            TipoDespesa novaDespesa = new TipoDespesa();
            TipoDespesaDAO despesaDAO = new TipoDespesaDAO();
            novaDespesa.DESCRICAO_DESPESA = txtDecricao.Text;
            despesaDAO.Add(novaDespesa);
            despesaDAO.SaveChanges();
            novaDespesa = null;

        }

        private void AtualizarDespesa()
        {
            TipoDespesaDAO despesaDAO = new TipoDespesaDAO();
            TipoDespesa atual = despesaDAO.Find(d => d.COD_TIPO_DESPESA == ((TipoDespesa)cmbDespesas.SelectedItem).COD_TIPO_DESPESA).First<TipoDespesa>();
            atual.DESCRICAO_DESPESA = txtDecricao.Text;
            despesaDAO.SaveChanges();

        }

        private void ExcluirDespesa()
        {
            TipoDespesa despesa = new TipoDespesa();
            TipoDespesaDAO despesaDAO = new TipoDespesaDAO();
            despesa = despesaDAO.Find(d => d.COD_TIPO_DESPESA == ((TipoDespesa)cmbDespesas.SelectedItem).COD_TIPO_DESPESA).First<TipoDespesa>();
            despesaDAO.Delete(despesa);
            despesaDAO.SaveChanges();
        }
        #endregion

       

        private void cmbDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDespesas.SelectedIndex != -1)
            {
                button1.Visible = true;
                bindDespesa();
            }
            else
            {
                button1.Visible = false;
                txtDecricao.Text = "";
            }
        }

        private void btNovaDespesa_Click(object sender, EventArgs e)
        {
            cmbDespesas.SelectedIndex = -1;
            errorProvider1.SetError(txtDecricao, "");
        }

        private void txtDecricao_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtDecricao.Text))
            {
                errorProvider1.SetError(txtDecricao, "Campo Obrigatório!");
            }
            else
            {
                errorProvider1.SetError(txtDecricao, "");
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                if (cmbDespesas.SelectedIndex == -1)
                {
                    SalvarDespesa();
                    MessageBox.Show("Operação Realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    AtualizarDespesa();
                    MessageBox.Show("Operação Realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                bindComboDespesas();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ExcluirDespesa();
                MessageBox.Show("Operação Realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bindComboDespesas();
            }
            catch
            {
                MessageBox.Show("Essa despesa não pode ser excluída.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
