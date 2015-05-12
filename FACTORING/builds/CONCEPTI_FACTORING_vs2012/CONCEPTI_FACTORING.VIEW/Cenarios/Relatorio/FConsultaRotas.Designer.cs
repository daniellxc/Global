using Concepti.Factoring.Data.Entidades;
namespace CONCEPTI_FACTORING.VIEW.Cenarios.Relatorio
{
    partial class FConsultaRotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultaRotas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.gbRotas = new System.Windows.Forms.GroupBox();
            this.gridRotas = new System.Windows.Forms.DataGridView();
            this.rotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.COD_ROTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAFIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.gbRotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.cmbVendedores);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Vendedor:";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(544, 83);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(83, 25);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "Consultar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Fim:";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(377, 88);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(112, 20);
            this.dtpFim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Início:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendedores:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(173, 89);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(112, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DisplayMember = "nome";
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(177, 36);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(450, 21);
            this.cmbVendedores.TabIndex = 0;
            this.cmbVendedores.ValueMember = "cod_vendedor";
            this.cmbVendedores.SelectedIndexChanged += new System.EventHandler(this.cmbVendedores_SelectedIndexChanged);
            // 
            // gbRotas
            // 
            this.gbRotas.Controls.Add(this.gridRotas);
            this.gbRotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRotas.Location = new System.Drawing.Point(12, 175);
            this.gbRotas.Name = "gbRotas";
            this.gbRotas.Size = new System.Drawing.Size(800, 372);
            this.gbRotas.TabIndex = 1;
            this.gbRotas.TabStop = false;
            this.gbRotas.Text = "Selecione uma Rota:";
            this.gbRotas.Visible = false;
            // 
            // gridRotas
            // 
            this.gridRotas.AllowUserToAddRows = false;
            this.gridRotas.AllowUserToDeleteRows = false;
            this.gridRotas.AutoGenerateColumns = false;
            this.gridRotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_ROTA,
            this.dATAINICIODataGridViewTextBoxColumn,
            this.dATAFIMDataGridViewTextBoxColumn,
            this.FUNDO,
            this.Column1});
            this.gridRotas.DataSource = this.rotaBindingSource;
            this.gridRotas.Location = new System.Drawing.Point(6, 28);
            this.gridRotas.MultiSelect = false;
            this.gridRotas.Name = "gridRotas";
            this.gridRotas.ReadOnly = true;
            this.gridRotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridRotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRotas.Size = new System.Drawing.Size(788, 329);
            this.gridRotas.TabIndex = 0;
            this.gridRotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRotas_CellContentClick);
            // 
            // rotaBindingSource
            // 
            this.rotaBindingSource.DataSource = typeof(Rota);
            // 
            // COD_ROTA
            // 
            this.COD_ROTA.DataPropertyName = "COD_ROTA";
            this.COD_ROTA.HeaderText = "COD";
            this.COD_ROTA.Name = "COD_ROTA";
            this.COD_ROTA.ReadOnly = true;
            this.COD_ROTA.Visible = false;
            // 
            // dATAINICIODataGridViewTextBoxColumn
            // 
            this.dATAINICIODataGridViewTextBoxColumn.DataPropertyName = "DATA_INICIO";
            this.dATAINICIODataGridViewTextBoxColumn.HeaderText = "Data de Abertura";
            this.dATAINICIODataGridViewTextBoxColumn.Name = "dATAINICIODataGridViewTextBoxColumn";
            this.dATAINICIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAFIMDataGridViewTextBoxColumn
            // 
            this.dATAFIMDataGridViewTextBoxColumn.DataPropertyName = "DATA_FIM";
            this.dATAFIMDataGridViewTextBoxColumn.HeaderText = "Data de Fechamento";
            this.dATAFIMDataGridViewTextBoxColumn.Name = "dATAFIMDataGridViewTextBoxColumn";
            this.dATAFIMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FUNDO
            // 
            this.FUNDO.DataPropertyName = "VALOR";
            this.FUNDO.HeaderText = "Saída R$";
            this.FUNDO.Name = "FUNDO";
            this.FUNDO.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Selecione";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // FConsultaRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.gbRotas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FConsultaRotas";
            this.Text = "Consulta Rotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.GroupBox gbRotas;
        private System.Windows.Forms.DataGridView gridRotas;
        private System.Windows.Forms.BindingSource rotaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_ROTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAFIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNDO;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
    }
}