using Concepti.Factoring.Data.Entidades;
using System.Windows.Forms;
namespace CONCEPTI_FACTORING.VIEW.Cenarios.Boletos
{
    partial class FImprimirBoletos : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FImprimirBoletos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPesquisarCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.gbContratos = new System.Windows.Forms.GroupBox();
            this.gridContratos = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbContratantes = new System.Windows.Forms.GroupBox();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.COD_CONTRATANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbAbertos = new System.Windows.Forms.RadioButton();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODCONTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAABERTURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.gbContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).BeginInit();
            this.gbContratantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAbertos);
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Controls.Add(this.btPesquisarCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o nome do Cliente:";
            // 
            // btPesquisarCliente
            // 
            this.btPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarCliente.Location = new System.Drawing.Point(565, 65);
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
            // gbContratos
            // 
            this.gbContratos.Controls.Add(this.gridContratos);
            this.gbContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContratos.Location = new System.Drawing.Point(12, 305);
            this.gbContratos.Name = "gbContratos";
            this.gbContratos.Size = new System.Drawing.Size(800, 220);
            this.gbContratos.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCONTRATODataGridViewTextBoxColumn,
            this.dATAABERTURADataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.Column2});
            this.gridContratos.DataSource = this.contratoBindingSource;
            this.gridContratos.Location = new System.Drawing.Point(6, 29);
            this.gridContratos.Name = "gridContratos";
            this.gridContratos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContratos.Size = new System.Drawing.Size(787, 185);
            this.gridContratos.TabIndex = 0;
            this.gridContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContratos_CellContentClick);
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
            // gbContratantes
            // 
            this.gbContratantes.Controls.Add(this.gridClientes);
            this.gbContratantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContratantes.Location = new System.Drawing.Point(12, 114);
            this.gbContratantes.Name = "gbContratantes";
            this.gbContratantes.Size = new System.Drawing.Size(800, 185);
            this.gbContratantes.TabIndex = 2;
            this.gbContratantes.TabStop = false;
            this.gbContratantes.Text = "Selecione um Cliente:";
            this.gbContratantes.Visible = false;
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AutoGenerateColumns = false;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CONTRATANTE,
            this.nOMEDataGridViewTextBoxColumn,
            this.Column1});
            this.gridClientes.DataSource = this.contratanteBindingSource;
            this.gridClientes.Location = new System.Drawing.Point(7, 29);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(787, 150);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            // 
            // COD_CONTRATANTE
            // 
            this.COD_CONTRATANTE.DataPropertyName = "COD_CONTRATANTE";
            this.COD_CONTRATANTE.HeaderText = "COD_CONTRATANTE";
            this.COD_CONTRATANTE.Name = "COD_CONTRATANTE";
            this.COD_CONTRATANTE.ReadOnly = true;
            this.COD_CONTRATANTE.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Selecionar";
            this.Column1.ToolTipText = "Selecionar este cliente";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(663, 39);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(106, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos os boletos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbAbertos
            // 
            this.rdbAbertos.AutoSize = true;
            this.rdbAbertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAbertos.Location = new System.Drawing.Point(663, 71);
            this.rdbAbertos.Name = "rdbAbertos";
            this.rdbAbertos.Size = new System.Drawing.Size(111, 17);
            this.rdbAbertos.TabIndex = 2;
            this.rdbAbertos.Text = "Apenas em aberto";
            this.rdbAbertos.UseVisualStyleBackColor = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contratanteBindingSource
            // 
            this.contratanteBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Contratante);
            // 
            // cODCONTRATODataGridViewTextBoxColumn
            // 
            this.cODCONTRATODataGridViewTextBoxColumn.DataPropertyName = "COD_CONTRATO";
            this.cODCONTRATODataGridViewTextBoxColumn.HeaderText = "COD. CONTRATO";
            this.cODCONTRATODataGridViewTextBoxColumn.Name = "cODCONTRATODataGridViewTextBoxColumn";
            this.cODCONTRATODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAABERTURADataGridViewTextBoxColumn
            // 
            this.dATAABERTURADataGridViewTextBoxColumn.DataPropertyName = "DATA_ABERTURA";
            this.dATAABERTURADataGridViewTextBoxColumn.HeaderText = "DATA DE ABERTURA";
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
            // contratoBindingSource
            // 
            this.contratoBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Contrato);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(CONCEPTI_FACTORING.VIEW.Program);
            // 
            // FImprimirBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.gbContratantes);
            this.Controls.Add(this.gbContratos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FImprimirBoletos";
            this.Text = "Impressão de Boletos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbContratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).EndInit();
            this.gbContratantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPesquisarCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox gbContratos;
        private System.Windows.Forms.GroupBox gbContratantes;
        private System.Windows.Forms.BindingSource contratanteBindingSource;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.DataGridView gridContratos;
        private System.Windows.Forms.BindingSource contratoBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCONTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAABERTURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONTRATANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private RadioButton rdbAbertos;
        private RadioButton rdbTodos;
    }
}