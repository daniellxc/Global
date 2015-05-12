namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    partial class FConsultaContrato
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
            this.components = new System.ComponentModel.Container();
            this.gbNomeContratante = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeContratante = new System.Windows.Forms.TextBox();
            this.gbContratante = new System.Windows.Forms.GroupBox();
            this.gridContratante = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbContratos = new System.Windows.Forms.GroupBox();
            this.gridContratos = new System.Windows.Forms.DataGridView();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.COD_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAABERTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbNomeContratante.SuspendLayout();
            this.gbContratante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratante)).BeginInit();
            this.gbContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).BeginInit();
            this.gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNomeContratante
            // 
            this.gbNomeContratante.Controls.Add(this.btnPesquisar);
            this.gbNomeContratante.Controls.Add(this.txtNomeContratante);
            this.gbNomeContratante.Location = new System.Drawing.Point(12, 12);
            this.gbNomeContratante.Name = "gbNomeContratante";
            this.gbNomeContratante.Size = new System.Drawing.Size(760, 74);
            this.gbNomeContratante.TabIndex = 0;
            this.gbNomeContratante.TabStop = false;
            this.gbNomeContratante.Text = "Nome do Contratante";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(570, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeContratante
            // 
            this.txtNomeContratante.Location = new System.Drawing.Point(29, 31);
            this.txtNomeContratante.Name = "txtNomeContratante";
            this.txtNomeContratante.Size = new System.Drawing.Size(534, 20);
            this.txtNomeContratante.TabIndex = 0;
            // 
            // gbContratante
            // 
            this.gbContratante.Controls.Add(this.gridContratante);
            this.gbContratante.Location = new System.Drawing.Point(12, 111);
            this.gbContratante.Name = "gbContratante";
            this.gbContratante.Size = new System.Drawing.Size(760, 143);
            this.gbContratante.TabIndex = 1;
            this.gbContratante.TabStop = false;
            this.gbContratante.Text = "Contratantes Localizados";
            this.gbContratante.Visible = false;
            // 
            // gridContratante
            // 
            this.gridContratante.AllowUserToAddRows = false;
            this.gridContratante.AllowUserToDeleteRows = false;
            this.gridContratante.AutoGenerateColumns = false;
            this.gridContratante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridContratante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContratante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMEDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.Column1});
            this.gridContratante.DataSource = this.contratanteBindingSource;
            this.gridContratante.Location = new System.Drawing.Point(6, 19);
            this.gridContratante.Name = "gridContratante";
            this.gridContratante.ReadOnly = true;
            this.gridContratante.Size = new System.Drawing.Size(748, 118);
            this.gridContratante.TabIndex = 0;
            this.gridContratante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContratante_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "selecionar";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // gbContratos
            // 
            this.gbContratos.Controls.Add(this.gridContratos);
            this.gbContratos.Location = new System.Drawing.Point(12, 260);
            this.gbContratos.Name = "gbContratos";
            this.gbContratos.Size = new System.Drawing.Size(760, 172);
            this.gbContratos.TabIndex = 2;
            this.gbContratos.TabStop = false;
            this.gbContratos.Text = "Contratos";
            this.gbContratos.Visible = false;
            // 
            // gridContratos
            // 
            this.gridContratos.AllowUserToAddRows = false;
            this.gridContratos.AllowUserToDeleteRows = false;
            this.gridContratos.AutoGenerateColumns = false;
            this.gridContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CONTRATO,
            this.dATAABERTURADataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.ATIVO,
            this.dataGridViewLinkColumn1});
            this.gridContratos.DataSource = this.contratoBindingSource;
            this.gridContratos.Location = new System.Drawing.Point(6, 19);
            this.gridContratos.Name = "gridContratos";
            this.gridContratos.ReadOnly = true;
            this.gridContratos.Size = new System.Drawing.Size(748, 147);
            this.gridContratos.TabIndex = 0;
            this.gridContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContratos_CellContentClick);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.btnCancelar);
            this.gbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(412, 432);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(354, 56);
            this.gbOpcoes.TabIndex = 3;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            this.gbOpcoes.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(16, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar Contrato";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Contrato);
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contratanteBindingSource
            // 
            this.contratanteBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Contratante);
            // 
            // COD_CONTRATO
            // 
            this.COD_CONTRATO.DataPropertyName = "COD_CONTRATO";
            this.COD_CONTRATO.HeaderText = "CONTRATO";
            this.COD_CONTRATO.Name = "COD_CONTRATO";
            this.COD_CONTRATO.ReadOnly = true;
            // 
            // dATAABERTURADataGridViewTextBoxColumn
            // 
            this.dATAABERTURADataGridViewTextBoxColumn.DataPropertyName = "DATA_ABERTURA";
            this.dATAABERTURADataGridViewTextBoxColumn.HeaderText = "DATA_ABERTURA";
            this.dATAABERTURADataGridViewTextBoxColumn.Name = "dATAABERTURADataGridViewTextBoxColumn";
            this.dATAABERTURADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ATIVO
            // 
            this.ATIVO.DataPropertyName = "ATIVO";
            this.ATIVO.HeaderText = "ATIVO";
            this.ATIVO.Name = "ATIVO";
            this.ATIVO.ReadOnly = true;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Text = "selecionar";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            // 
            // FConsultaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 497);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.gbContratos);
            this.Controls.Add(this.gbContratante);
            this.Controls.Add(this.gbNomeContratante);
            this.Name = "FConsultaContrato";
            this.Text = "Consulta Contratos";
            this.gbNomeContratante.ResumeLayout(false);
            this.gbNomeContratante.PerformLayout();
            this.gbContratante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContratante)).EndInit();
            this.gbContratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).EndInit();
            this.gbOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNomeContratante;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeContratante;
        private System.Windows.Forms.GroupBox gbContratante;
        private System.Windows.Forms.DataGridView gridContratante;
        private System.Windows.Forms.BindingSource contratanteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREAFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.GroupBox gbContratos;
        private System.Windows.Forms.DataGridView gridContratos;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERIODICIDADEFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAABERTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ATIVO;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
    }
}