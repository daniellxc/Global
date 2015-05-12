using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CONCEPTI_FACTORING.VIEW.Cenarios
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
            Rectangle bounds = new Microsoft.VisualBasic.Devices.Computer().Screen.Bounds;
            this.Size = new Size(bounds.Width, bounds.Height);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro.FCadastroCliente fc = new Cadastro.FCadastroCliente();
            fc.ShowDialog();
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Emprestimo.FContratacao fc = new Emprestimo.FContratacao();
            fc.ShowDialog();
        }

        private void baixarBoletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void sobreJCEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Ajuda.FAjuda fa = new Ajuda.FAjuda();
            fa.ShowDialog();

        }

        private void imprimirBoletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Boletos.FImprimirBoletos fi = new Boletos.FImprimirBoletos();
            fi.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FClientes fc = new Relatorio.FClientes();
            fc.ShowDialog();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro.FCadastroArea fa = new Cadastro.FCadastroArea();
            fa.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Cadastro.FCadastroVendedor fv = new Cadastro.FCadastroVendedor();
            fv.ShowDialog();
        }

        private void controlarFeriadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao.FCadastroFeriado fc = new Manutencao.FCadastroFeriado();
            fc.ShowDialog();
        }

 
        private void novaRotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Rotas.FCadastroRota fr = new Rotas.FCadastroRota();
            fr.ShowDialog();
        }

        private void prestaçãoDeContasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Rotas.FPrestacaoConta fp = new Rotas.FPrestacaoConta();
            fp.ShowDialog();
        }

        private void consultarCarnêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FConsultaCarnes fc = new Relatorio.FConsultaCarnes();
            fc.ShowDialog();
        }

        private void consultarRotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FConsultaRotas fc = new Relatorio.FConsultaRotas();
            fc.ShowDialog();

        }

        private void tiposDeDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao.FCadastroDespesa fc = new Manutencao.FCadastroDespesa();
            fc.ShowDialog();
        }

        private void consultarCarnêsDoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FConsultarCarnesCliente fc = new Relatorio.FConsultarCarnesCliente();
            fc.ShowDialog();
        }

        private void gerarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao.FBackup fb = new Manutencao.FBackup();
            fb.ShowDialog();

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao.FControles fc = new Manutencao.FControles();
            fc.ShowDialog();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio.FConsultaContrato fcc = new Relatorio.FConsultaContrato();
            fcc.ShowDialog();
        }

        private void individuaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Boletos.FBaixarBoleto fb = new Boletos.FBaixarBoleto();
            fb.ShowDialog();
        }

        private void emMassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONCEPTI_FACTORING.VIEW.Cenarios.Boletos.FBaixarBoletosContrato fbc = new Boletos.FBaixarBoletosContrato();
            fbc.ShowDialog();
        }

        //private void restaurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        System.Diagnostics.Process.Start("C:/Program Files/MySQL/MySQL Server 5.5/bin/mysql.exe", "-u root --password=root -h localhost factoring < C:/JCExpress/backup.sql").WaitForExit();
        //        //MessageBox.Show("As informações do sistema foram restauradas com sucesso!");
        //    }
        //    catch(Exception ex) {

        //        MessageBox.Show("Não foi possível restaurar as informações do sistema.");
        //    }
        //}

      
    }
}
