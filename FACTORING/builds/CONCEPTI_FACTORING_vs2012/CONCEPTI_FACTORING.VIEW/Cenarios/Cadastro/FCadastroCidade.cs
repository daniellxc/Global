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

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro
{
    public partial class FCadastroCidade : Form
    {
        public FCadastroCidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade();
            CidadeDAO cidadeDAO = new CidadeDAO();

            cidade.ESTADO = txtEstado.Text;
            cidade.NOME = txtNomeCidade.Text;

            cidadeDAO.Add(cidade);
            cidadeDAO.SaveChanges();

            Util.LimparForm(this);

        }
    }
}
