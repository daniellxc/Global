namespace CONCEPTI_FACTORING.VIEW.Cenarios.Rotas
{
    partial class FPrestacaoConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrestacaoConta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrestacao = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridDespesas = new System.Windows.Forms.DataGridView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remover = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbDespesa = new System.Windows.Forms.GroupBox();
            this.btAdicionarDespesa = new System.Windows.Forms.Button();
            this.cmbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRecebido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalContratos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorSaida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridContratos = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnPrestacao.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesas)).BeginInit();
            this.gbDespesa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVendedores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Vendedor";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DisplayMember = "NOME";
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(173, 32);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(410, 21);
            this.cmbVendedores.TabIndex = 1;
            this.cmbVendedores.ValueMember = "COD_VENDEDOR";
            this.cmbVendedores.SelectedIndexChanged += new System.EventHandler(this.cmbVendedores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedores com rota em aberto:";
            // 
            // pnPrestacao
            // 
            this.pnPrestacao.BackColor = System.Drawing.SystemColors.Control;
            this.pnPrestacao.Controls.Add(this.button1);
            this.pnPrestacao.Controls.Add(this.btCancelar);
            this.pnPrestacao.Controls.Add(this.groupBox5);
            this.pnPrestacao.Controls.Add(this.gbDespesa);
            this.pnPrestacao.Controls.Add(this.groupBox3);
            this.pnPrestacao.Controls.Add(this.groupBox2);
            this.pnPrestacao.Location = new System.Drawing.Point(12, 99);
            this.pnPrestacao.Name = "pnPrestacao";
            this.pnPrestacao.Size = new System.Drawing.Size(800, 499);
            this.pnPrestacao.TabIndex = 1;
            this.pnPrestacao.Visible = false;
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(709, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Concluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.CausesValidation = false;
            this.btCancelar.Location = new System.Drawing.Point(605, 462);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridDespesas);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 305);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(393, 177);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Despesas Adicionadas";
            // 
            // gridDespesas
            // 
            this.gridDespesas.AllowUserToAddRows = false;
            this.gridDespesas.AllowUserToDeleteRows = false;
            this.gridDespesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.cod_despesa,
            this.custo,
            this.Remover});
            this.gridDespesas.Location = new System.Drawing.Point(6, 21);
            this.gridDespesas.Name = "gridDespesas";
            this.gridDespesas.ReadOnly = true;
            this.gridDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDespesas.Size = new System.Drawing.Size(381, 150);
            this.gridDespesas.TabIndex = 1;
            this.gridDespesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDespesas_CellContentClick);
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // cod_despesa
            // 
            this.cod_despesa.HeaderText = "";
            this.cod_despesa.Name = "cod_despesa";
            this.cod_despesa.ReadOnly = true;
            this.cod_despesa.Visible = false;
            // 
            // custo
            // 
            this.custo.HeaderText = "R$";
            this.custo.Name = "custo";
            this.custo.ReadOnly = true;
            // 
            // Remover
            // 
            this.Remover.HeaderText = "Remover";
            this.Remover.Image = ((System.Drawing.Image)(resources.GetObject("Remover.Image")));
            this.Remover.Name = "Remover";
            this.Remover.ReadOnly = true;
            // 
            // gbDespesa
            // 
            this.gbDespesa.Controls.Add(this.btAdicionarDespesa);
            this.gbDespesa.Controls.Add(this.cmbTipoDespesa);
            this.gbDespesa.Controls.Add(this.label7);
            this.gbDespesa.Controls.Add(this.txtValorDespesa);
            this.gbDespesa.Controls.Add(this.label6);
            this.gbDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDespesa.Location = new System.Drawing.Point(415, 113);
            this.gbDespesa.Name = "gbDespesa";
            this.gbDespesa.Size = new System.Drawing.Size(382, 181);
            this.gbDespesa.TabIndex = 2;
            this.gbDespesa.TabStop = false;
            this.gbDespesa.Text = "Despesas";
            // 
            // btAdicionarDespesa
            // 
            this.btAdicionarDespesa.Location = new System.Drawing.Point(226, 101);
            this.btAdicionarDespesa.Name = "btAdicionarDespesa";
            this.btAdicionarDespesa.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarDespesa.TabIndex = 12;
            this.btAdicionarDespesa.Text = "Adicionar";
            this.btAdicionarDespesa.UseVisualStyleBackColor = true;
            this.btAdicionarDespesa.Click += new System.EventHandler(this.btAdicionarDespesa_Click);
            // 
            // cmbTipoDespesa
            // 
            this.cmbTipoDespesa.DisplayMember = "DESCRICAO_DESPESA";
            this.cmbTipoDespesa.FormattingEnabled = true;
            this.cmbTipoDespesa.Location = new System.Drawing.Point(80, 51);
            this.cmbTipoDespesa.Name = "cmbTipoDespesa";
            this.cmbTipoDespesa.Size = new System.Drawing.Size(221, 21);
            this.cmbTipoDespesa.TabIndex = 11;
            this.cmbTipoDespesa.ValueMember = "COD_TIPO_DESPESA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Despesa:";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDespesa.Location = new System.Drawing.Point(80, 101);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(100, 23);
            this.txtValorDespesa.TabIndex = 9;
            this.txtValorDespesa.Validating += new System.ComponentModel.CancelEventHandler(this.txtValorDespesa_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor R$:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblComplemento);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblRecebido);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblTotalContratos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblSaldo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblValorSaida);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblVendedor);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 104);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecebido.Location = new System.Drawing.Point(438, 51);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(63, 17);
            this.lblRecebido.TabIndex = 12;
            this.lblRecebido.Text = "recebido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Recebido de Clientes:";
            // 
            // lblTotalContratos
            // 
            this.lblTotalContratos.AutoSize = true;
            this.lblTotalContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContratos.Location = new System.Drawing.Point(692, 16);
            this.lblTotalContratos.Name = "lblTotalContratos";
            this.lblTotalContratos.Size = new System.Drawing.Size(39, 17);
            this.lblTotalContratos.TabIndex = 10;
            this.lblTotalContratos.Text = "total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total em Contratos:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(652, 51);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(94, 17);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "Saldo Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saldo Final:";
            // 
            // lblValorSaida
            // 
            this.lblValorSaida.AutoSize = true;
            this.lblValorSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaida.Location = new System.Drawing.Point(438, 16);
            this.lblValorSaida.Name = "lblValorSaida";
            this.lblValorSaida.Size = new System.Drawing.Size(101, 17);
            this.lblValorSaida.TabIndex = 6;
            this.lblValorSaida.Text = "Valor de Saída";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor de Saída:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(86, 51);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(70, 17);
            this.lblVendedor.TabIndex = 1;
            this.lblVendedor.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vendedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridContratos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contratos Realizados";
            // 
            // gridContratos
            // 
            this.gridContratos.AllowUserToAddRows = false;
            this.gridContratos.AllowUserToDeleteRows = false;
            this.gridContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.DATA,
            this.VALOR});
            this.gridContratos.Location = new System.Drawing.Point(6, 19);
            this.gridContratos.Name = "gridContratos";
            this.gridContratos.ReadOnly = true;
            this.gridContratos.Size = new System.Drawing.Size(378, 150);
            this.gridContratos.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NOME";
            this.Cliente.HeaderText = "CLIENTE";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA_ABERTURA";
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Pegou com a Empresa:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(438, 84);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(92, 17);
            this.lblComplemento.TabIndex = 14;
            this.lblComplemento.Text = "complemento";
            // 
            // FPrestacaoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.pnPrestacao);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FPrestacaoConta";
            this.Text = "Prestação de Contas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnPrestacao.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDespesas)).EndInit();
            this.gbDespesa.ResumeLayout(false);
            this.gbDespesa.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPrestacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView gridDespesas;
        private System.Windows.Forms.GroupBox gbDespesa;
        private System.Windows.Forms.Button btAdicionarDespesa;
        private System.Windows.Forms.ComboBox cmbTipoDespesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridContratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Label lblTotalContratos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.DataGridViewImageColumn Remover;
        private System.Windows.Forms.Label lblRecebido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label label10;
    }
}