using Concepti.Factoring.Data.Entidades;
namespace CONCEPTI_FACTORING.VIEW.Cenarios.Emprestimo
{
    partial class FContratacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FContratacao));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.COD_CONTRATANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODAREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIMITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbContratacao = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btContratar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPeriodicidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).BeginInit();
            this.gbContratacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Cliente:";
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(676, 31);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Localizar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(101, 33);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(559, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientes.AutoGenerateColumns = false;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CONTRATANTE,
            this.cODAREADataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.tELRESDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.lIMITEDataGridViewTextBoxColumn,
            this.Column1});
            this.gridClientes.DataSource = this.contratanteBindingSource;
            this.gridClientes.Location = new System.Drawing.Point(12, 87);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(800, 157);
            this.gridClientes.TabIndex = 2;
            this.gridClientes.Visible = false;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            this.gridClientes.DoubleClick += new System.EventHandler(this.gridClientes_DoubleClick);
            // 
            // COD_CONTRATANTE
            // 
            this.COD_CONTRATANTE.DataPropertyName = "COD_CONTRATANTE";
            this.COD_CONTRATANTE.HeaderText = "COD_CONTRATANTE";
            this.COD_CONTRATANTE.Name = "COD_CONTRATANTE";
            this.COD_CONTRATANTE.ReadOnly = true;
            this.COD_CONTRATANTE.Visible = false;
            // 
            // cODAREADataGridViewTextBoxColumn
            // 
            this.cODAREADataGridViewTextBoxColumn.DataPropertyName = "COD_AREA";
            this.cODAREADataGridViewTextBoxColumn.HeaderText = "COD_AREA";
            this.cODAREADataGridViewTextBoxColumn.Name = "cODAREADataGridViewTextBoxColumn";
            this.cODAREADataGridViewTextBoxColumn.ReadOnly = true;
            this.cODAREADataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELRESDataGridViewTextBoxColumn
            // 
            this.tELRESDataGridViewTextBoxColumn.DataPropertyName = "TEL_RES";
            this.tELRESDataGridViewTextBoxColumn.HeaderText = "TEL_RES";
            this.tELRESDataGridViewTextBoxColumn.Name = "tELRESDataGridViewTextBoxColumn";
            this.tELRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lIMITEDataGridViewTextBoxColumn
            // 
            this.lIMITEDataGridViewTextBoxColumn.DataPropertyName = "LIMITE";
            this.lIMITEDataGridViewTextBoxColumn.HeaderText = "LIMITE";
            this.lIMITEDataGridViewTextBoxColumn.Name = "lIMITEDataGridViewTextBoxColumn";
            this.lIMITEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // contratanteBindingSource
            // 
            this.contratanteBindingSource.DataSource = typeof(Contratante);
            // 
            // gbContratacao
            // 
            this.gbContratacao.Controls.Add(this.lblArea);
            this.gbContratacao.Controls.Add(this.label13);
            this.gbContratacao.Controls.Add(this.lblCliente);
            this.gbContratacao.Controls.Add(this.label12);
            this.gbContratacao.Controls.Add(this.cmbVendedores);
            this.gbContratacao.Controls.Add(this.label11);
            this.gbContratacao.Controls.Add(this.label10);
            this.gbContratacao.Controls.Add(this.label9);
            this.gbContratacao.Controls.Add(this.label8);
            this.gbContratacao.Controls.Add(this.label7);
            this.gbContratacao.Controls.Add(this.btContratar);
            this.gbContratacao.Controls.Add(this.btCancelar);
            this.gbContratacao.Controls.Add(this.label6);
            this.gbContratacao.Controls.Add(this.txtJuros);
            this.gbContratacao.Controls.Add(this.label5);
            this.gbContratacao.Controls.Add(this.txtValor);
            this.gbContratacao.Controls.Add(this.label4);
            this.gbContratacao.Controls.Add(this.txtPeriodo);
            this.gbContratacao.Controls.Add(this.label3);
            this.gbContratacao.Controls.Add(this.cmbPeriodicidade);
            this.gbContratacao.Controls.Add(this.label2);
            this.gbContratacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContratacao.Location = new System.Drawing.Point(12, 250);
            this.gbContratacao.Name = "gbContratacao";
            this.gbContratacao.Size = new System.Drawing.Size(800, 319);
            this.gbContratacao.TabIndex = 3;
            this.gbContratacao.TabStop = false;
            this.gbContratacao.Text = "Dados da Contratação:";
            this.gbContratacao.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(98, 73);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 18;
            this.lblArea.Text = "área";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Área:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(98, 41);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Cliente:";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DisplayMember = "NOME";
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(101, 106);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(303, 21);
            this.cmbVendedores.TabIndex = 1;
            this.cmbVendedores.ValueMember = "COD_VENDEDOR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Vendedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(79, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(39, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(401, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "*";
            // 
            // btContratar
            // 
            this.btContratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContratar.Location = new System.Drawing.Point(707, 256);
            this.btContratar.Name = "btContratar";
            this.btContratar.Size = new System.Drawing.Size(87, 27);
            this.btContratar.TabIndex = 4;
            this.btContratar.Text = "Finalizar";
            this.btContratar.UseVisualStyleBackColor = true;
            this.btContratar.Click += new System.EventHandler(this.btContratar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.CausesValidation = false;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(614, 256);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(87, 27);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "%";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(101, 248);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(76, 20);
            this.txtJuros.TabIndex = 7;
            this.txtJuros.Validating += new System.ComponentModel.CancelEventHandler(this.txtJuros_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Taxa de Juros:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(101, 201);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 20);
            this.txtValor.TabIndex = 6;
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor: ";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(422, 150);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(76, 20);
            this.txtPeriodo.TabIndex = 2;
            this.txtPeriodo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPeriodo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prazo de Pagamento:";
            // 
            // cmbPeriodicidade
            // 
            this.cmbPeriodicidade.DisplayMember = "DESCRICAO";
            this.cmbPeriodicidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodicidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriodicidade.FormattingEnabled = true;
            this.cmbPeriodicidade.Location = new System.Drawing.Point(101, 150);
            this.cmbPeriodicidade.Name = "cmbPeriodicidade";
            this.cmbPeriodicidade.Size = new System.Drawing.Size(131, 21);
            this.cmbPeriodicidade.TabIndex = 5;
            this.cmbPeriodicidade.ValueMember = "COD_PERIODICIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Periodicidade:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FContratacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.gbContratacao);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FContratacao";
            this.Text = "Contratação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratanteBindingSource)).EndInit();
            this.gbContratacao.ResumeLayout(false);
            this.gbContratacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.BindingSource contratanteBindingSource;
        private System.Windows.Forms.GroupBox gbContratacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPeriodicidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btContratar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONTRATANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODAREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIMITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
    }
}