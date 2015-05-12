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
    public partial class FCadastroArea : Form
    {
        public FCadastroArea()
        {
            InitializeComponent();
            bindComboAreas();
        }

        #region Métodos

        private bool validar(Control c)
        {
            bool controle = true;
            foreach (Control c1 in c.Controls)
            {
                if (c1.GetType().ToString().Contains("GroupBox") )
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

        private void bindComboAreas()
        {
            cmbArea.DataSource = new AreaDAO().GetAll().ToList<Area>();
            cmbArea.SelectedIndex = -1;
        }

        private void bindArea()
        {
            if (cmbArea.SelectedIndex != -1)
            {
                txtDescricao.Text = ((Area)cmbArea.SelectedItem).DESCRICAO;
                txtNome.Text = ((Area)cmbArea.SelectedItem).NOME;
            }
            else
            {
                txtNome.Text = "";
                txtDescricao.Text = "";
            }
            gbArea.Visible = true;

        }

        private void SalvarArea()
        {
            AreaDAO areaDAO = new AreaDAO();
            Area area = new Area();

            area.DESCRICAO = txtDescricao.Text;
            area.NOME = txtNome.Text.ToUpper() ;

            areaDAO.Add(area);
            areaDAO.SaveChanges();

        }

        private void AtualizarArea()
        {
            AreaDAO areaDAO = new AreaDAO();
            Area areaAtual = areaDAO.Find(a => a.COD_AREA == ((Area)cmbArea.SelectedItem).COD_AREA).First<Area>();
            areaAtual.DESCRICAO = txtDescricao.Text;
            areaAtual.NOME = txtNome.Text.ToUpper();
            areaDAO.SaveChanges();
        }


        #endregion

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindArea();
            gbArea.Visible = true;
        }

        private void btNovaArea_Click(object sender, EventArgs e)
        {
            cmbArea.SelectedIndex = -1;
            bindArea();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                if (cmbArea.SelectedIndex == -1)
                {
                    SalvarArea();
                    MessageBox.Show("Operação Realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    AtualizarArea();
                    MessageBox.Show("Operação Realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                bindComboAreas();
            } 
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (!validacao.CampoPreenchido(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Campo Obrigatório!");
            }
            else errorProvider1.SetError(txtNome, "");
        }

      
    }
}
