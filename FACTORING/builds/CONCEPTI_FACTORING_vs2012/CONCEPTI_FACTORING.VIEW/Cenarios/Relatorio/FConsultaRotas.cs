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
using Concepti.Factoring.Data.Entidades;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FConsultaRotas : Form
    {
        public FConsultaRotas()
        {
            InitializeComponent();
            bindVendedores();
        }

        #region Métodos

        private void bindVendedores()
        {
            cmbVendedores.DataSource = new VendedorDAO().GetAll().ToList();
            cmbVendedores.SelectedIndex = -1;

        }

        private bool validarIntervaloDatas()
        {
            return DateTime.Parse(dtpInicio.Value.ToShortDateString()) <= DateTime.Parse(dtpFim.Value.ToShortDateString());
        }

        private void bindRotas()
        {
            gridRotas.DataSource = new VendedorBO(((Vendedor)cmbVendedores.SelectedItem)).pegarInformacoesRotasFechadasPeriodo(dtpInicio.Value, dtpFim.Value);
            gbRotas.Visible = true;
        }

        private void Reset()
        {
            gridRotas.DataSource = null;
            gbRotas.Visible = false;
        }

        #endregion

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbVendedores.SelectedIndex != -1)
            {
                if (validarIntervaloDatas())
                {
                    bindRotas();
                }
                else
                {
                    MessageBox.Show("Intervalo de datas incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Vendedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void gridRotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridRotas.CurrentCell.Value == "Selecione")
            {
                new FConsultaRota2(int.Parse(gridRotas.CurrentRow.Cells["COD_ROTA"].Value.ToString())).ShowDialog();
            }
        }
    }
}
