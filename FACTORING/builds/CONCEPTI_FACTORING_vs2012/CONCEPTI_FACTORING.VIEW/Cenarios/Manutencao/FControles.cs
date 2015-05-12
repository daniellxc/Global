using Concepti.Factoring.Data.Business;
using Concepti.Factoring.Data.DAO_Classes;
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

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao
{
    public partial class FControles : Form
    {
        public FControles()
        {
            InitializeComponent();
            BindUf();
            BindGridCidade(UF);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "tabCidades" :
                    BindGridCidade(UF);
                    break;
                case"tabFeriados":
                    BindFeriados();
                    break;
                case "tabPeriodicidade":
                    BindPeriodicidade();
                    break;


            }
        }

       



        #region Controle Cidades


        #region Propriedades

        public Cidade CIDADE { get; set; }

        public string UF { get { return cmbEstado.SelectedValue.ToString(); } }

        #endregion

        private void BindGridCidade(string uf)
        {
            if (uf == "")
                gridCidades.DataSource = new CidadeDAO().GetAll().OrderBy(c => c.ESTADO).ToList();
            else
                gridCidades.DataSource = new CidadeDAO().Find(c => c.ESTADO == uf).ToList();

        }

        private void BindUf()
        {
            cmbEstado.DataSource = new CidadeBO().GetUf();
           
        }

        private void AtualizarCidade()
        {
            try
            {
                if (CIDADE != null)
                {
                    Cidade cidadeAux = new CidadeBO().GetCidade(((Cidade)gridCidades.CurrentRow.DataBoundItem).COD_CIDADE);
                    cidadeAux.ATIVO = !((Cidade)gridCidades.CurrentRow.DataBoundItem).ATIVO;
                    new CidadeBO().SalvarCidade(cidadeAux);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro>" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void gridCidades_SelectionChanged(object sender, EventArgs e)
        {
            CIDADE = (Cidade)gridCidades.CurrentRow.DataBoundItem;

        }





        private void gridCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                AtualizarCidade();
                BindGridCidade(UF);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridCidade(UF);
        }


        #endregion


        #region Controle Feriados
       
        
        private bool editando = false;

        private void BindFeriados()
        {
            gridFeriados.DataSource = new FeriadoDAO().GetAll().OrderBy(f => f.COD_FERIADO).ToList<Feriado>();
            btExcluir.Visible = false;
        }

        private void SalvarFeriado()
        {
            FeriadoDAO fDAO = new FeriadoDAO();
            Feriado novoFeriado = novoFeriado = fDAO.Find(f => f.COD_FERIADO == ((Feriado)gridFeriados.CurrentRow.DataBoundItem).COD_FERIADO).First<Feriado>();
            try
            {
                if (editando)
                {
                    novoFeriado.DESCRICAO = txtFeriado.Text;
                    novoFeriado.DIAMES = dtFeriado.Value.Day.ToString().PadLeft(2, '0') + "/" + dtFeriado.Value.Month.ToString().PadLeft(2, '0');
                    fDAO.SaveChanges();
                    MessageBox.Show("Operação realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Util.LimparForm(this);
                    fDAO = null;
                    novoFeriado = null;
                    editando = false;
                }

                else
                {

                    novoFeriado = new Feriado();
                    novoFeriado.DESCRICAO = txtFeriado.Text;
                    novoFeriado.DIAMES = dtFeriado.Value.Day.ToString().PadLeft(2, '0') + "/" + dtFeriado.Value.Month.ToString().PadLeft(2, '0');
                    fDAO.Add(novoFeriado);
                    fDAO.SaveChanges();
                    MessageBox.Show("Operação realizada com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    fDAO = null;
                    editando = false;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Editar()
        {
            try
            {
                Feriado novoFeriado = new FeriadoDAO().Find(f => f.COD_FERIADO == ((Feriado)gridFeriados.CurrentRow.DataBoundItem).COD_FERIADO).First<Feriado>();
                if (novoFeriado.COD_FERIADO != 0)
                {
                    txtFeriado.Text = novoFeriado.DESCRICAO;
                    dtFeriado.Value = DateTime.Parse(novoFeriado.DIAMES + "/" + DateTime.Now.Year.ToString());
                    btExcluir.Visible = true;

                    editando = true;
                }
                else
                {
                    btExcluir.Visible = false;
                    editando = false;
                }

            }
            catch { }
        }

        private void ExcluirFeriado()
        {
            FeriadoDAO fDAO = new FeriadoDAO();
            Feriado _feriado = fDAO.Find(f => f.COD_FERIADO == ((Feriado)gridFeriados.CurrentRow.DataBoundItem).COD_FERIADO).First<Feriado>();
            fDAO.Delete(_feriado);
            fDAO.SaveChanges();
            Util.LimparForm(this);
            editando = false;
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            SalvarFeriado();
            BindFeriados();
            Util.LimparForm(this);
        }

        private void gridFeriados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gridFeriados.CurrentCell.Value == "Editar")
                Editar();
            else Util.LimparForm(this);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFeriado();
            BindFeriados();
        }

        #endregion


        #region Controle Periodicidades

        public Periodicidade PERIODICIDADE { get; set; }

        private void BindPeriodicidade()
        {
            gridPeriodicidade.DataSource = new PeriodicidadeBO().GetAll();
        }

        private void AtualizarPeriodicidade()
        {
            PERIODICIDADE = new PeriodicidadeBO().GetPeriodicidade(((Periodicidade)gridPeriodicidade.CurrentRow.DataBoundItem).COD_PERIODICIDADE);
            PERIODICIDADE.ATIVO = !((Periodicidade)gridPeriodicidade.CurrentRow.DataBoundItem).ATIVO;

            new PeriodicidadeBO().SalvarPeriodicidade(PERIODICIDADE);

        }

        private void gridPeriodicidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                AtualizarPeriodicidade();
                BindPeriodicidade();
            }
        }

        #endregion

        




    }
}
