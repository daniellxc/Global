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

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro
{
    public partial class FCadastroVendedor : Form
    {
        public FCadastroVendedor()
        {
            InitializeComponent();
            bindAreas();
            bindVendedores();
          
        }

        Vendedor _vendedor;


        #region Métodos

        private void bindVendedores()
        {

            cmbVendedor.DataSource = new VendedorDAO().GetAll().OrderBy(v => v.NOME).ToList<Vendedor>();
            cmbVendedor.SelectedIndex = -1;
        }

        private void bindAreas()
        {
            cmbArea.DataSource = new AreaDAO().GetAll().ToList<Area>();
        }

        private void bindVendedor()
        {
            if (cmbVendedor.SelectedIndex != -1)
            {
                _vendedor = (Vendedor)cmbVendedor.SelectedItem;

                txtNomeVendedor.Text = _vendedor.NOME;
                txtDataContratacao.Text = _vendedor.DATA_CONTRATACAO.ToShortDateString();
                txtRG.Text = _vendedor.RG;
                txtTelefone.Text = _vendedor.TELEFONE;
                txtCelular.Text = _vendedor.CELULAR;
                cmbArea.SelectedValue = _vendedor.COD_AREA;

            }
            else
            {
                Util.LimparForm(gbVendedor);
              
            }

            gbVendedor.Visible = true;
        }

        private void SalvarNovoVendedor()
        {
            VendedorDAO vendDAO = new VendedorDAO();
            _vendedor = new Vendedor();

            _vendedor.CELULAR = txtCelular.Text;
            _vendedor.COD_AREA = ((Area)cmbArea.SelectedItem).COD_AREA;
            _vendedor.DATA_CONTRATACAO = DateTime.Parse(txtDataContratacao.Text);
            _vendedor.TELEFONE = txtTelefone.Text;
            _vendedor.NOME = txtNomeVendedor.Text.ToUpper();
            _vendedor.RG = txtRG.Text;

            vendDAO.Add(_vendedor);
            vendDAO.SaveChanges();
            vendDAO = null;
        }

        private void AtualizarVendedor()
        {
            VendedorDAO vendDAO = new VendedorDAO();

            _vendedor = vendDAO.Find(v => v.COD_VENDEDOR == ((Vendedor)cmbVendedor.SelectedItem).COD_VENDEDOR).First<Vendedor>();
            _vendedor.CELULAR = txtCelular.Text;
            _vendedor.COD_AREA = ((Area)cmbArea.SelectedItem).COD_AREA;
            _vendedor.DATA_CONTRATACAO = DateTime.Parse(txtDataContratacao.Text);
            _vendedor.TELEFONE = txtTelefone.Text;
            _vendedor.NOME = txtNomeVendedor.Text.ToUpper();
            _vendedor.RG = txtRG.Text;

            vendDAO.SaveChanges();

        }

        #endregion

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                bindVendedor();
                gbVendedor.Visible = true;
     
        }

        private void btNovoVendedor_Click(object sender, EventArgs e)
        {
            cmbVendedor.SelectedValue = -1;
            bindVendedor();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(validar(this)){
            if (cmbVendedor.SelectedIndex != -1)
            {
                AtualizarVendedor();
                MessageBox.Show("Operação Realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                SalvarNovoVendedor();
                MessageBox.Show("Operação Realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            bindVendedores();
        }
        }


        private void txtNomeVendedor_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtNomeVendedor.Text))
            {
                errorProvider1.SetError(txtNomeVendedor, "Campo Obrigatório!");
            }
            else errorProvider1.SetError(txtNomeVendedor, "");
        }

        private void txtDataContratacao_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtDataContratacao.Text))
            {
                errorProvider1.SetError(txtDataContratacao, "Campo Obrigatório!");
            }
            else errorProvider1.SetError(txtDataContratacao, "");
        }


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
           

    }
}
