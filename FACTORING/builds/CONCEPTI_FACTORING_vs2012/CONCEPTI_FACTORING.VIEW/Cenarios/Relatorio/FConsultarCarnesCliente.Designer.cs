using Concepti.Factoring.Data.Entidades;
namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    partial class FConsultarCarnesCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultarCarnesCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPesquisarCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.gbContratantes = new System.Windows.Forms.GroupBox();
            this.gbContratos = new System.Windows.Forms.GroupBox();
            this.gridContratos = new System.Windows.Forms.DataGridView();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.contratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODCONTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAABERTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jUROSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.gbContratantes.SuspendLayout();
            this.gbContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPesquisarCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o nome do Cliente:";
            // 
            // btPesquisarCliente
            // 
            this.btPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarCliente.Location = new System.Drawing.Point(646, 36);
            this.btPesquisarCliente.Name = "btPesquisarCliente";
            this.btPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.btPesquisarCliente.TabIndex = 1;
            this.btPesquisarCliente.Text = "Pesquisar";
            this.btPesquisarCliente.UseVisualStyleBackColor = true;
            this.btPesquisarCliente.Click += new System.EventHandler(this.btPesquisarCliente_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeCliente.Location = new System.Drawing.Point(57, 39);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(583, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // gbContratantes
            // 
            this.gbContratantes.Controls.Add(this.gridClientes);
            this.gbContratantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContratantes.Location = new System.Drawing.Point(2, 124);
            this.gbContratantes.Name = "gbContratantes";
            this.gbContratantes.Size = new System.Drawing.Size(800, 185);
            this.gbContratantes.TabIndex = 3;
            this.gbContratantes.TabStop = false;
            this.gbContratantes.Text = "Selecione um Cliente:";
            this.gbContratantes.Visible = false;
            // 
            // gbContratos
            // 
            this.gbContratos.Controls.Add(this.gridContratos);
            this.gbContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContratos.Location = new System.Drawing.Point(9, 330);
            this.gbContratos.Name = "gbContratos";
            this.gbContratos.Size = new System.Drawing.Size(793, 220);
            this.gbContratos.TabIndex = 4;
            this.gbContratos.TabStop = false;
            this.gbContratos.Text = "Selecione um contrato:";
            this.gbContratos.Visible = false;
            // 
            // gridContratos
            // 
            this.gridContratos.AllowUserToAddRows = false;
            this.gridContratos.AllowUserToDeleteRows = false;
            this.gridContratos.AutoGenerateColumns = false;
            this.gridContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCONTRATODataGridViewTextBoxColumn,
            this.dATAABERTURADataGridViewTextBoxColumn,
            this.jUROSDataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.Column2});
            this.gridContratos.DataSource = this.contratoBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridContratos.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridContratos.Location = new System.Drawing.Point(6, 29);
            this.gridContratos.Name = "gridContratos";
            this.gridContratos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContratos.Size = new System.Drawing.Size(781, 185);
            this.gridContratos.TabIndex = 0;
            this.gridContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContratos_CellContentClick_1);
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AutoGenerateColumns = false;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            this.gridClientes.DataSource = this.contratanteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridClientes.Location = new System.Drawing.Point(13, 19);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(781, 150);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            // 
            // contratanteBindingSource
            // 
            this.contratanteBindingSource.DataSource = typeof(Contratante);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "COD_CONTRATANTE";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NOME";
            this.Column3.HeaderText = "NOME";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "Selecionar";
            this.Column4.UseColumnTextForLinkValue = true;
            this.Column4.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(Contrato);
            // 
            // cODCONTRATODataGridViewTextBoxColumn
            // 
            this.cODCONTRATODataGridViewTextBoxColumn.DataPropertyName = "COD_CONTRATO";
            this.cODCONTRATODataGridViewTextBoxColumn.HeaderText = "COD_CONTRATO";
            this.cODCONTRATODataGridViewTextBoxColumn.Name = "cODCONTRATODataGridViewTextBoxColumn";
            this.cODCONTRATODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAABERTURADataGridViewTextBoxColumn
            // 
            this.dATAABERTURADataGridViewTextBoxColumn.DataPropertyName = "DATA_ABERTURA";
            this.dATAABERTURADataGridViewTextBoxColumn.HeaderText = "DATA_ABERTURA";
            this.dATAABERTURADataGridViewTextBoxColumn.Name = "dATAABERTURADataGridViewTextBoxColumn";
            this.dATAABERTURADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jUROSDataGridViewTextBoxColumn
            // 
            this.jUROSDataGridViewTextBoxColumn.DataPropertyName = "JUROS";
            this.jUROSDataGridViewTextBoxColumn.HeaderText = "JUROS";
            this.jUROSDataGridViewTextBoxColumn.Name = "jUROSDataGridViewTextBoxColumn";
            this.jUROSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Selecionar";
            this.Column2.ToolTipText = "Selecionar";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // FConsultarCarnesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 600);
            this.Controls.Add(this.gbContratos);
            this.Controls.Add(this.gbContratantes);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FConsultarCarnesCliente";
            this.Text = "Consultar Carnês do Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbContratantes.ResumeLayout(false);
            this.gbContratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPesquisarCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox gbContratantes;
        private System.Windows.Forms.GroupBox gbContratos;
        private System.Windows.Forms.DataGridView gridContratos;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.BindingSource contratanteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAABERTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jUROSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.BindingSource contratoBindingSource;
    }
}