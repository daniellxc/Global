using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concepti.Factoring.Data;
using Concepti.Factoring.Data.DAO_Classes;
using CLvalidacao;
using Concepti.Factoring.Data.Entidades;
using Concepti.Factoring.Business.Classes;
using Concepti.Factoring.Business;
using Concepti.Factoring.Data.Business;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro
{
    public partial class FCadastroCliente : Form
    {
        Contratante contratanteEdit;
        ContratanteBO contratanteBO = new ContratanteBO();
       
        public FCadastroCliente()
        {
            InitializeComponent();
            bindCidades();
            bindEscolaridade();
            bindArea();
            bindDias();
            
        }

        public FCadastroCliente(Contratante _contratante)
        {
            InitializeComponent();
            bindCidades();
            bindEscolaridade();
            bindArea();
            bindDias();
            contratanteEdit = contratanteBO.GetContratante(_contratante.COD_CONTRATANTE);

            txtBairroCom.Text = _contratante.BAIRRO_COM;
            txtBairroRes.Text = _contratante.BAIRRO_RES;
            txtCPF.Text = _contratante.CPF;
            txtDataExpedicao.Text = _contratante.DATE_EXP.ToShortDateString();
            txtLimiteCredito.Text = _contratante.LIMITE.ToString();
            txtNOME.Text = _contratante.NOME;
            txtNomeMae.Text = _contratante.NOME_MAE;
            txtNomePai.Text = _contratante.NOME_PAI;
            txtNumCom.Text = _contratante.NUMERO_COM.ToString();
            txtNumRes.Text = _contratante.NUMERO_RES.ToString();
            txtObs.Text = _contratante.OBS;
            txtOrgExp.Text = _contratante.ORG_EXP;
            txtRG.Text = _contratante.RG;
            txtRuaCom.Text = _contratante.RUA_COM;
            txtRuaRes.Text = _contratante.RUA_RES;
            txtTelCom.Text = _contratante.TEL_COM;
            txtTelRes.Text = _contratante.TEL_RES;
            rdbFeminino.Checked = _contratante.SEXO.Equals("F") ? true : false;
            rdbMasculino.Checked = _contratante.SEXO.Equals("M") ? true : false;
            cmbCidadeCom.SelectedValue = _contratante.CIDADE_COM;
            cmbCidadeRes.SelectedValue= _contratante.CIDADE_RES;
            cmbESCOLARIDADE.SelectedValue = _contratante.ESCOLARIDADE_FK.COD_ESCOLARIDADE;
            cmbDia.SelectedValue = _contratante.DIA_INDISPONIVEL;
            cmbArea.SelectedValue = _contratante.COD_AREA ;

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
           
           
        

        private void bindCidades()
        {
            List<Cidade> cidade = new CidadeBO().GetAtivas();// new CidadeDAO().GetAll().Where(c=>c.ATIVO == true).ToList<Cidade>();

            cmbCidadeCom.DataSource = cidade;
            cmbCidadeRes.DataSource = cidade; ;
           
            
        }

        private void bindEscolaridade()
        {
            cmbESCOLARIDADE.DataSource = new EscolaridadeDAO().GetAll().ToList<Escolaridade>();

        }

        private void bindArea()
        {
            cmbArea.DataSource = new AreaDAO().GetAll().ToList<Area>();
        }

        private void bindDias()
        {
            cmbDia.DataSource = new DiaDAO().GetAll().ToList<Dia>();
        }

        private void InstanciarContratante()
        {
          
            if (contratanteEdit==null)
                contratanteEdit = new Contratante();


            contratanteEdit.NOME = txtNOME.Text.ToUpper();
            contratanteEdit.BAIRRO_COM = txtBairroCom.Text.ToUpper();
            contratanteEdit.BAIRRO_RES = txtBairroRes.Text.ToUpper();
            contratanteEdit.CIDADE_RES = ((Cidade)cmbCidadeRes.SelectedItem).COD_CIDADE;
            contratanteEdit.COD_ESCOLARIDADE = ((Escolaridade)cmbESCOLARIDADE.SelectedItem).COD_ESCOLARIDADE;
            contratanteEdit.CPF = txtCPF.Text;
            contratanteEdit.DATE_EXP = DateTime.Parse(txtDataExpedicao.Text);
            contratanteEdit.LIMITE = decimal.Parse(txtLimiteCredito.Text.Replace('.', ','));
            contratanteEdit.NOME_MAE = txtNomeMae.Text.ToUpper();
            contratanteEdit.NOME_PAI = txtNomePai.Text.ToUpper();
            contratanteEdit.NUMERO_COM = txtNumCom.Text;
            contratanteEdit.NUMERO_RES = txtNumRes.Text;
            contratanteEdit.OBS = txtObs.Text;
            contratanteEdit.ORG_EXP = txtOrgExp.Text.ToUpper();
            contratanteEdit.RG = txtRG.Text;
            contratanteEdit.RUA_COM = txtRuaCom.Text.ToUpper();
            contratanteEdit.RUA_RES = txtRuaRes.Text.ToUpper();
            contratanteEdit.CIDADE_COM = ((Cidade)cmbCidadeCom.SelectedItem).COD_CIDADE;
            contratanteEdit.SEXO = rdbFeminino.Checked ? "F" : "M";
            contratanteEdit.TEL_COM = txtTelCom.Text;
            contratanteEdit.TEL_RES = txtTelRes.Text;
            contratanteEdit.DIA_INDISPONIVEL = ((Dia)cmbDia.SelectedItem).COD_DIA;
            contratanteEdit.COD_AREA = ((Area)cmbArea.SelectedItem).COD_AREA;
        }

        private void Encerrar()
        {
            this.Dispose();
        }

        #endregion

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (validar(this))
            {

                try
                {

                    InstanciarContratante();

                 new ContratanteBO().SalvarContratante(contratanteEdit);
                   




                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Util.LimparForm(this);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro! " + ex.Message);
                }
            }
        }

            
        

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Util.LimparForm(this);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Encerrar();
        }

        #region Validações
        private void txtNOME_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtNOME.Text))
            {
                errorProvider1.SetError(txtNOME, "Campo Obrigatório!");
               // e.Cancel = true;
            }
            else errorProvider1.SetError(txtNOME, "");

        }

        private void txtRG_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtRG.Text))
            {
                errorProvider1.SetError(txtRG, "Campo Obrigatório!");
               // e.Cancel = true;
            }
            else 

            if (!validacao.NumeroInteiro(txtRG.Text))
            {
                errorProvider1.SetError(txtRG, "Digite Apenas Números!");
                //e.Cancel = true;
            }
            else errorProvider1.SetError(txtRG, "");
        }

        private void txtOrgExp_Validating(object sender, CancelEventArgs e)
        {
            if(!validacao.CampoPreenchido(txtOrgExp.Text)){
                errorProvider1.SetError(txtOrgExp,"Campo Obrigatório!");
               // e.Cancel=true;
            }else errorProvider1.SetError(txtOrgExp, "");
        }

        private void txtDataExpedicao_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtDataExpedicao.Text))
            {
                errorProvider1.SetError(txtDataExpedicao, "Campo Obrigatório!");
               // e.Cancel = true;
            }
            else if (!validacao.DataValida(txtDataExpedicao.Text))
            {
                errorProvider1.SetError(txtDataExpedicao, "Informe a Data do Formato DD/MM/AAAA!");
                //e.Cancel = true;
            }
            else errorProvider1.SetError(txtDataExpedicao, "");

        }

        private void txtCPF_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtCPF.Text))
            {
                errorProvider1.SetError(txtCPF, "Campo Obrigatório!");
              //  e.Cancel = true;
            }
            else if (!validacao.NumeroInteiro(txtCPF.Text))
            {
                errorProvider1.SetError(txtCPF, "Digite Apenas Números!");
               // e.Cancel = true;
            }
            else errorProvider1.SetError(txtCPF, "");
        }

        private void txtLimiteCredito_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtLimiteCredito.Text))
            {
                errorProvider1.SetError(txtLimiteCredito, "Campo Obrigatório!");
               // e.Cancel = true;
            }
            else if (!validacao.NumeroDecimal(txtLimiteCredito.Text))
            {
                errorProvider1.SetError(txtLimiteCredito, "Informe Apenas Números!");
               // e.Cancel = true;
            }
            else errorProvider1.SetError(txtLimiteCredito, "");


        }

        private void txtRuaRes_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtRuaRes.Text))
            {
                errorProvider1.SetError(txtRuaRes, "Campo Obrigatório!");
               // e.Cancel = true;
            }
            else errorProvider1.SetError(txtRuaRes, "");
        }

        private void txtNumRes_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtNumRes.Text))
            {
                errorProvider1.SetError(txtNumRes, "Campo Obrigatório!");
              //  e.Cancel = true;
            }else if(!validacao.NumeroInteiro(txtNumRes.Text)){
                errorProvider1.SetError(txtNumRes,"Informe Apenas Números!");
               // e.Cancel = true; 
            }
                else errorProvider1.SetError(txtNumRes,"");
        }

        private void txtBairroRes_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtBairroRes.Text))
            {
                errorProvider1.SetError(txtBairroRes, "Campo Obrigatório!");
              //  e.Cancel = true;
            }
            else errorProvider1.SetError(txtBairroRes, "");
        }

        private void txtTelRes_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtTelRes.Text))
            {
                errorProvider1.SetError(txtTelRes, "Campo Obrigatório!");
              //  e.Cancel = true;
            }
            else if (!validacao.NumeroInteiro(txtTelRes.Text))
            {
                errorProvider1.SetError(txtTelRes, "Informe Apenas Números!");
              //  e.Cancel = true;
            }
            else errorProvider1.SetError(txtTelRes, "");
        }

        #endregion

       

    }


    
        
}
