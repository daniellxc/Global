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
using Concepti.Factoring.Data.Entidades;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao
{
    public partial class FCadastroFeriado : Form
    {
        private bool editando = false;


    

        public FCadastroFeriado()
        {
            InitializeComponent();
            bindFeriados();
        }

        #region Controle Feriados

        private void bindFeriados()
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
            
            catch(Exception ex){
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


        #endregion

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SalvarFeriado();
            bindFeriados();
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
            bindFeriados();
        }

       
    }
}