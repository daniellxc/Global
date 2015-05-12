using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao
{
    public partial class FBackup : Form
    {
        public FBackup()
        {
            InitializeComponent();
            
        }



        private void btGerarBackup_Click(object sender, EventArgs e)
        {
           
            try
            {
                GerarBackup();
                MessageBox.Show("Backup realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void GerarBackup()
        {
            string backupPath = txtCaminho.Text != null && txtCaminho.Text!= "" ? txtCaminho.Text+"\\" : "C:\\JCExpress\\";   
            string fileName = "backup_sistema_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".sql";
            string path = System.Environment.GetEnvironmentVariable("mysqlpath") + "/mysqldump.exe";
            string MySQLPath = path.Replace("\\", "/");
            try
            {
                System.Diagnostics.Process.Start(MySQLPath, "-u root --password=root -B factoring > -r " + backupPath+fileName).WaitForExit(50000);
               
            }
            catch(Exception ex)
            {
                throw new Exception("O Backup não pode ser realizado. Verifique o caminho informado para o Dump e tente novamente");
            }

        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            
            ChooseFolder();
        }


        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;
            }
        }

      

   

      
    }
}
