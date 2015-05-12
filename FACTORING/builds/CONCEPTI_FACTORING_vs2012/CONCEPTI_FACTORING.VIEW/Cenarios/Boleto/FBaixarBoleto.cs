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
using Concepti.Factoring.Business.Classes;
using Concepti.Factoring.Data.Entidades;


namespace CONCEPTI_FACTORING.VIEW.Cenarios.Boletos
{
    public partial class FBaixarBoleto : Form
    {
        public FBaixarBoleto()
        {
            InitializeComponent();
        }

        #region Métodos

        private void bindBoletos()
        {
            
           
            if (rdbCodigo.Checked)
            {
                try
                {
                    int codigo = int.Parse(txtParam.Text);
                    gridBoletos.DataSource = new BoletoDAO().Find(b => b.COD_BOLETO == codigo && b.COD_SITUACAO_BOLETO == 1).OrderBy(b=>b.COD_CONTRATO);
                }
                catch
                {
                    MessageBox.Show("Parâmetro Incorreto. Verifique o método de busca.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else if (rdbCliente.Checked)
            {
                gridBoletos.DataSource = new BoletoDAO().Find(b => b.CONTRATO_FK.CONTRATANTE_FK.NOME.Contains(txtParam.Text) && b.COD_SITUACAO_BOLETO==1);
                    
            }

            gridBoletos.Visible = true;
            btBaixar.Visible = true;

            foreach (DataGridViewRow r in gridBoletos.Rows)
            {
                if (new VendedorBO(((Boleto)r.DataBoundItem).CONTRATO_FK.ROTA_FK.VENDEDOR_FK).buscarRotaAberta().COD_ROTA == 0)
                {
                    ((r.Cells[4] as DataGridViewCheckBoxCell)).ReadOnly = true;
                }
                else
                {
                    ((r.Cells[4] as DataGridViewCheckBoxCell)).ReadOnly = false;
                }
            }

        }


        #endregion

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            gbChave.Visible = true;
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            gbChave.Visible = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            bindBoletos();
        }

        private void gridBoletos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                if (new VendedorBO(((Boleto)gridBoletos.CurrentRow.DataBoundItem).CONTRATO_FK.ROTA_FK.VENDEDOR_FK).buscarRotaAberta().COD_ROTA == 0)
                {
                    MessageBox.Show("Não há rota aberta para a área deste boleto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            //if (MessageBox.Show("Deseja realmente baixar este boleto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {


            //        boleto boletoAntigo = (boleto)gridBoletos.CurrentRow.DataBoundItem;

            //        new Concepti.Factoring.Business.Classes.Boleto(boletoAntigo).BaixarBoleto();
            //        MessageBox.Show("Boleto baixado com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            //        bindBoletos();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Erro! " + ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
            //else return;
        }

        private void btBaixar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente baixar este boleto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow r in gridBoletos.Rows)
                    {
                        if (Convert.ToBoolean((r.Cells[4] as DataGridViewCheckBoxCell).Value) == true)
                        {
                            Boleto boletoAntigo = (Boleto)r.DataBoundItem;

                            new Concepti.Factoring.Business.Classes.BoletoBO(boletoAntigo).BaixarBoleto();
                           

                        }
                    }
                    bindBoletos();
                    MessageBox.Show("Boleto(s) baixado(s) com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }

      
    }
}
