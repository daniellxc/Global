using Concepti.Factoring.Business.Classes;
using Concepti.Factoring.Data.DAO_Classes;
using Concepti.Factoring.Data.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    public partial class FConsultaRota2 : Form
    {
        public FConsultaRota2()
        {
            InitializeComponent();
        }

       Rota _Rota;
       RotaBO rotaBO;
       
        public FConsultaRota2(int cod_rota)
        {
            InitializeComponent();
            _Rota = new RotaDAO().Find(r => r.COD_ROTA == cod_rota).First<Rota>();
          rotaBO = new RotaBO(_Rota);
          bindIformacoesRota();
        }

        #region Métodos

        private void bindIformacoesRota()
        {
          

            lblVendedor.Text = _Rota.VENDEDOR_FK.NOME;
            lblDataInicio.Text = _Rota.DATA_INICIO.ToString();
            lblDataFim.Text = _Rota.DATA_FIM.ToString();
            lblFundo.Text = rotaBO.pegarSaidaRota().ToString();
            lblSaldoFinal.Text = rotaBO.pegarRetornoRota().ToString();
            lblRecebidoClientes.Text = rotaBO.pegarTotalBoletosBaixados().ToString();
            bindContratos();
            bindDespesas();
        }

        private void bindContratos()
        {
            decimal totalContratos = 0;
            gridContratos.DataSource = rotaBO.buscarDadosDosContratosFirmados();

            for (int i = 0; i < gridContratos.Rows.Count; i++)
            {
                totalContratos += decimal.Parse(gridContratos["VALOR", i].Value.ToString());
            }

            lblContratos.Text = totalContratos.ToString();
        }

        private void bindDespesas()
        {
            decimal totalDespesas = 0;
            gridDespesas.DataSource = rotaBO.buscarDespesas();
            for (int i = 0; i < gridDespesas.Rows.Count; i++)
            {
                totalDespesas += decimal.Parse(gridDespesas["custo", i].Value.ToString());
            }
            lblDespesas.Text = totalDespesas.ToString();
        }
        #endregion
    }
}
