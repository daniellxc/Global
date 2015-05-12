using System.Windows.Forms;
namespace CONCEPTI_FACTORING.VIEW.Cenarios
{
    partial class FPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestaçãoDeContasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarBoletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirBoletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarFeriadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDespesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carnêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCarnêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCarnêsDoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.individuaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emMassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.boletosToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.empréstimoToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.rotaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // empréstimoToolStripMenuItem
            // 
            this.empréstimoToolStripMenuItem.Name = "empréstimoToolStripMenuItem";
            this.empréstimoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.empréstimoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.empréstimoToolStripMenuItem.Text = "Empréstimo";
            this.empréstimoToolStripMenuItem.Click += new System.EventHandler(this.empréstimoToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.areaToolStripMenuItem.Text = "Área";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // rotaToolStripMenuItem
            // 
            this.rotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaRotaToolStripMenuItem,
            this.prestaçãoDeContasToolStripMenuItem1});
            this.rotaToolStripMenuItem.Name = "rotaToolStripMenuItem";
            this.rotaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.rotaToolStripMenuItem.Text = "Rota";
            // 
            // novaRotaToolStripMenuItem
            // 
            this.novaRotaToolStripMenuItem.Name = "novaRotaToolStripMenuItem";
            this.novaRotaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.novaRotaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.novaRotaToolStripMenuItem.Text = "Nova Rota";
            this.novaRotaToolStripMenuItem.Click += new System.EventHandler(this.novaRotaToolStripMenuItem_Click);
            // 
            // prestaçãoDeContasToolStripMenuItem1
            // 
            this.prestaçãoDeContasToolStripMenuItem1.Name = "prestaçãoDeContasToolStripMenuItem1";
            this.prestaçãoDeContasToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.prestaçãoDeContasToolStripMenuItem1.Text = "Prestação de Contas";
            this.prestaçãoDeContasToolStripMenuItem1.Click += new System.EventHandler(this.prestaçãoDeContasToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.contratosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.contratosToolStripMenuItem.Text = "Contratos";
            this.contratosToolStripMenuItem.Click += new System.EventHandler(this.contratosToolStripMenuItem_Click);
            // 
            // boletosToolStripMenuItem
            // 
            this.boletosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baixarBoletosToolStripMenuItem,
            this.imprimirBoletosToolStripMenuItem});
            this.boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            this.boletosToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.boletosToolStripMenuItem.Text = "Boletos";
            // 
            // baixarBoletosToolStripMenuItem
            // 
            this.baixarBoletosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individuaisToolStripMenuItem,
            this.emMassaToolStripMenuItem});
            this.baixarBoletosToolStripMenuItem.Name = "baixarBoletosToolStripMenuItem";
            this.baixarBoletosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.baixarBoletosToolStripMenuItem.Text = "Baixar Boletos";
            this.baixarBoletosToolStripMenuItem.Click += new System.EventHandler(this.baixarBoletosToolStripMenuItem_Click);
            // 
            // imprimirBoletosToolStripMenuItem
            // 
            this.imprimirBoletosToolStripMenuItem.Name = "imprimirBoletosToolStripMenuItem";
            this.imprimirBoletosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.imprimirBoletosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.imprimirBoletosToolStripMenuItem.Text = "Imprimir Boletos";
            this.imprimirBoletosToolStripMenuItem.Click += new System.EventHandler(this.imprimirBoletosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlarFeriadosToolStripMenuItem,
            this.tiposDeDespesaToolStripMenuItem,
            this.backupDoSistemaToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 19);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // controlarFeriadosToolStripMenuItem
            // 
            this.controlarFeriadosToolStripMenuItem.Name = "controlarFeriadosToolStripMenuItem";
            this.controlarFeriadosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.controlarFeriadosToolStripMenuItem.Text = "Controlar Feriados";
            this.controlarFeriadosToolStripMenuItem.Click += new System.EventHandler(this.controlarFeriadosToolStripMenuItem_Click);
            // 
            // tiposDeDespesaToolStripMenuItem
            // 
            this.tiposDeDespesaToolStripMenuItem.Name = "tiposDeDespesaToolStripMenuItem";
            this.tiposDeDespesaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tiposDeDespesaToolStripMenuItem.Text = "Tipos de Despesa";
            this.tiposDeDespesaToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDespesaToolStripMenuItem_Click);
            // 
            // backupDoSistemaToolStripMenuItem
            // 
            this.backupDoSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarBackupToolStripMenuItem});
            this.backupDoSistemaToolStripMenuItem.Name = "backupDoSistemaToolStripMenuItem";
            this.backupDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.backupDoSistemaToolStripMenuItem.Text = "Backup do Sistema";
            // 
            // gerarBackupToolStripMenuItem
            // 
            this.gerarBackupToolStripMenuItem.Name = "gerarBackupToolStripMenuItem";
            this.gerarBackupToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gerarBackupToolStripMenuItem.Text = "Gerar Backup";
            this.gerarBackupToolStripMenuItem.Click += new System.EventHandler(this.gerarBackupToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carnêsToolStripMenuItem,
            this.rotasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // carnêsToolStripMenuItem
            // 
            this.carnêsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCarnêsToolStripMenuItem,
            this.consultarCarnêsDoClienteToolStripMenuItem});
            this.carnêsToolStripMenuItem.Name = "carnêsToolStripMenuItem";
            this.carnêsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.carnêsToolStripMenuItem.Text = "Carnês";
            // 
            // consultarCarnêsToolStripMenuItem
            // 
            this.consultarCarnêsToolStripMenuItem.Name = "consultarCarnêsToolStripMenuItem";
            this.consultarCarnêsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.consultarCarnêsToolStripMenuItem.Text = "Consultar Carnês";
            this.consultarCarnêsToolStripMenuItem.Click += new System.EventHandler(this.consultarCarnêsToolStripMenuItem_Click);
            // 
            // consultarCarnêsDoClienteToolStripMenuItem
            // 
            this.consultarCarnêsDoClienteToolStripMenuItem.Name = "consultarCarnêsDoClienteToolStripMenuItem";
            this.consultarCarnêsDoClienteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.consultarCarnêsDoClienteToolStripMenuItem.Text = "Consultar Carnês do Cliente";
            this.consultarCarnêsDoClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarCarnêsDoClienteToolStripMenuItem_Click);
            // 
            // rotasToolStripMenuItem
            // 
            this.rotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarRotasToolStripMenuItem});
            this.rotasToolStripMenuItem.Name = "rotasToolStripMenuItem";
            this.rotasToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.rotasToolStripMenuItem.Text = "Rotas";
            // 
            // consultarRotasToolStripMenuItem
            // 
            this.consultarRotasToolStripMenuItem.Name = "consultarRotasToolStripMenuItem";
            this.consultarRotasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.consultarRotasToolStripMenuItem.Text = "Consultar Rotas";
            this.consultarRotasToolStripMenuItem.Click += new System.EventHandler(this.consultarRotasToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 721);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 686);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 35);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(564, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright: Concepti, 2011. Todos os Direitos Reservados";
            // 
            // individuaisToolStripMenuItem
            // 
            this.individuaisToolStripMenuItem.Name = "individuaisToolStripMenuItem";
            this.individuaisToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.individuaisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.individuaisToolStripMenuItem.Text = "Individuais";
            this.individuaisToolStripMenuItem.Click += new System.EventHandler(this.individuaisToolStripMenuItem_Click);
            // 
            // emMassaToolStripMenuItem
            // 
            this.emMassaToolStripMenuItem.Name = "emMassaToolStripMenuItem";
            this.emMassaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.emMassaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emMassaToolStripMenuItem.Text = "Em massa";
            this.emMassaToolStripMenuItem.Click += new System.EventHandler(this.emMassaToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "FPrincipal";
            this.Text = "JC Express";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixarBoletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirBoletosToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem areaToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem controlarFeriadosToolStripMenuItem;
        private ToolStripMenuItem rotaToolStripMenuItem;
        private ToolStripMenuItem novaRotaToolStripMenuItem;
        private ToolStripMenuItem prestaçãoDeContasToolStripMenuItem1;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem carnêsToolStripMenuItem;
        private ToolStripMenuItem consultarCarnêsToolStripMenuItem;
        private ToolStripMenuItem rotasToolStripMenuItem;
        private ToolStripMenuItem consultarRotasToolStripMenuItem;
        private ToolStripMenuItem tiposDeDespesaToolStripMenuItem;
        private ToolStripMenuItem consultarCarnêsDoClienteToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem backupDoSistemaToolStripMenuItem;
        private ToolStripMenuItem gerarBackupToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem contratosToolStripMenuItem;
        private ToolStripMenuItem individuaisToolStripMenuItem;
        private ToolStripMenuItem emMassaToolStripMenuItem;

    }
}