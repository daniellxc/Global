namespace CONCEPTI_FACTORING.VIEW.Cenarios.Boletos
{
    partial class FBaixarBoletosContrato
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
            this.gbBuscaContratante = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.cODCONTRATANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridContratos = new System.Windows.Forms.DataGridView();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbAcao = new System.Windows.Forms.GroupBox();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.COD_CONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ABERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbBuscaContratante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            this.gbAcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuscaContratante
            // 
            this.gbBuscaContratante.Controls.Add(this.btnBuscar);
            this.gbBuscaContratante.Controls.Add(this.txtNomeCliente);
            this.gbBuscaContratante.Location = new System.Drawing.Point(12, 3);
            this.gbBuscaContratante.Name = "gbBuscaContratante";
            this.gbBuscaContratante.Size = new System.Drawing.Size(760, 84);
            this.gbBuscaContratante.TabIndex = 0;
            this.gbBuscaContratante.TabStop = false;
            this.gbBuscaContratante.Text = "Nome do Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(529, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Pesquisar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(53, 34);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(470, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AutoGenerateColumns = false;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCONTRATANTEDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.Column1});
            this.gridClientes.DataSource = this.contratanteBindingSource;
            this.gridClientes.Location = new System.Drawing.Point(12, 115);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(760, 150);
            this.gridClientes.TabIndex = 1;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            // 
            // cODCONTRATANTEDataGridViewTextBoxColumn
            // 
            this.cODCONTRATANTEDataGridViewTextBoxColumn.DataPropertyName = "COD_CONTRATANTE";
            this.cODCONTRATANTEDataGridViewTextBoxColumn.HeaderText = "COD_CONTRATANTE";
            this.cODCONTRATANTEDataGridViewTextBoxColumn.Name = "cODCONTRATANTEDataGridViewTextBoxColumn";
            this.cODCONTRATANTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "selecione";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "selecione";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // contratanteBindingSource
            // 
            this.contratanteBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Contratante);
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
            this.VALOR,
            this.DATA_ABERTURA,
            this.dataGridViewCheckBoxColumn1});
            this.gridContratos.DataSource = this.contratoBindingSource;
            this.gridContratos.Location = new System.Drawing.Point(12, 290);
            this.gridContratos.Name = "gridContratos";
            this.gridContratos.ReadOnly = true;
            this.gridContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContratos.Size = new System.Drawing.Size(760, 150);
            this.gridContratos.TabIndex = 2;
            this.gridContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContratos_CellContentClick);
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Contrato);
            // 
            // gbAcao
            // 
            this.gbAcao.Controls.Add(this.btnNao);
            this.gbAcao.Controls.Add(this.btnSim);
            this.gbAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbAcao.Location = new System.Drawing.Point(409, 468);
            this.gbAcao.Name = "gbAcao";
            this.gbAcao.Size = new System.Drawing.Size(363, 71);
            this.gbAcao.TabIndex = 3;
            this.gbAcao.TabStop = false;
            this.gbAcao.Text = "Baixar todos boletos do contrato selecionado?";
            // 
            // btnNao
            // 
            this.btnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNao.Location = new System.Drawing.Point(282, 30);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 3;
            this.btnNao.Text = "Cancelar";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSim.Location = new System.Drawing.Point(201, 30);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 2;
            this.btnSim.Text = "Confirmar";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // COD_CONTRATO
            // 
            this.COD_CONTRATO.DataPropertyName = "COD_CONTRATO";
            this.COD_CONTRATO.HeaderText = "CONTRATO";
            this.COD_CONTRATO.Name = "COD_CONTRATO";
            this.COD_CONTRATO.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // DATA_ABERTURA
            // 
            this.DATA_ABERTURA.DataPropertyName = "DATA_ABERTURA";
            this.DATA_ABERTURA.HeaderText = "DATA_ABERTURA";
            this.DATA_ABERTURA.Name = "DATA_ABERTURA";
            this.DATA_ABERTURA.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "selecione";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.Text = "selecione";
            this.dataGridViewCheckBoxColumn1.UseColumnTextForLinkValue = true;
            this.dataGridViewCheckBoxColumn1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // FBaixarBoletosContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gbAcao);
            this.Controls.Add(this.gridContratos);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.gbBuscaContratante);
            this.Name = "FBaixarBoletosContrato";
            this.Text = "Baixar Boletos por Contrato";
            this.gbBuscaContratante.ResumeLayout(false);
            this.gbBuscaContratante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            this.gbAcao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscaContratante;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.BindingSource contratanteBindingSource;
        private System.Windows.Forms.DataGridView gridContratos;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private System.Windows.Forms.GroupBox gbAcao;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONTRATANTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ABERTURA;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewCheckBoxColumn1;
    }
}