namespace CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao
{
    partial class FControles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabFeriados = new System.Windows.Forms.TabPage();
            this.gridFeriados = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtFeriado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFeriado = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCidades = new System.Windows.Forms.TabPage();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCidades = new System.Windows.Forms.DataGridView();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPeriodicidade = new System.Windows.Forms.TabPage();
            this.gridPeriodicidade = new System.Windows.Forms.DataGridView();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIVODataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.periodicidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIVODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabFeriados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeriados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabCidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPeriodicidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriodicidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFeriados
            // 
            this.tabFeriados.Controls.Add(this.gridFeriados);
            this.tabFeriados.Controls.Add(this.groupBox1);
            this.tabFeriados.Location = new System.Drawing.Point(4, 22);
            this.tabFeriados.Name = "tabFeriados";
            this.tabFeriados.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeriados.Size = new System.Drawing.Size(832, 440);
            this.tabFeriados.TabIndex = 1;
            this.tabFeriados.Text = "Feriados";
            this.tabFeriados.UseVisualStyleBackColor = true;
            // 
            // gridFeriados
            // 
            this.gridFeriados.AllowUserToAddRows = false;
            this.gridFeriados.AllowUserToDeleteRows = false;
            this.gridFeriados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFeriados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFeriados.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridFeriados.Location = new System.Drawing.Point(124, 145);
            this.gridFeriados.Name = "gridFeriados";
            this.gridFeriados.ReadOnly = true;
            this.gridFeriados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFeriados.Size = new System.Drawing.Size(585, 297);
            this.gridFeriados.TabIndex = 3;
            this.gridFeriados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFeriados_CellClick);
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Editar";
            this.edit.UseColumnTextForLinkValue = true;
            this.edit.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Controls.Add(this.txtFeriado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFeriado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(124, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Feriado:";
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExcluir.Location = new System.Drawing.Point(367, 63);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Visible = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(287, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "*";
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(457, 63);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtFeriado
            // 
            this.txtFeriado.Location = new System.Drawing.Point(308, 37);
            this.txtFeriado.Name = "txtFeriado";
            this.txtFeriado.Size = new System.Drawing.Size(224, 20);
            this.txtFeriado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feriado:";
            // 
            // dtFeriado
            // 
            this.dtFeriado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFeriado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFeriado.Location = new System.Drawing.Point(118, 37);
            this.dtFeriado.Name = "dtFeriado";
            this.dtFeriado.Size = new System.Drawing.Size(102, 20);
            this.dtFeriado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecione uma Data:";
            // 
            // tabCidades
            // 
            this.tabCidades.Controls.Add(this.cmbEstado);
            this.tabCidades.Controls.Add(this.label1);
            this.tabCidades.Controls.Add(this.gridCidades);
            this.tabCidades.Location = new System.Drawing.Point(4, 22);
            this.tabCidades.Name = "tabCidades";
            this.tabCidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabCidades.Size = new System.Drawing.Size(832, 440);
            this.tabCidades.TabIndex = 0;
            this.tabCidades.Text = "Cidades";
            this.tabCidades.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DisplayMember = "ESTADO";
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(112, 17);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 2;
            this.cmbEstado.ValueMember = "ESTADO";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cidades do Estado:";
            // 
            // gridCidades
            // 
            this.gridCidades.AllowUserToAddRows = false;
            this.gridCidades.AllowUserToDeleteRows = false;
            this.gridCidades.AutoGenerateColumns = false;
            this.gridCidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.ESTADO,
            this.aTIVODataGridViewCheckBoxColumn});
            this.gridCidades.DataSource = this.cidadeBindingSource;
            this.gridCidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCidades.Location = new System.Drawing.Point(3, 71);
            this.gridCidades.Name = "gridCidades";
            this.gridCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridCidades.Size = new System.Drawing.Size(820, 338);
            this.gridCidades.TabIndex = 0;
            this.gridCidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCidades_CellClick);
            this.gridCidades.SelectionChanged += new System.EventHandler(this.gridCidades_SelectionChanged);
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Cidade);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCidades);
            this.tabControl.Controls.Add(this.tabFeriados);
            this.tabControl.Controls.Add(this.tabPeriodicidade);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(840, 466);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPeriodicidade
            // 
            this.tabPeriodicidade.Controls.Add(this.gridPeriodicidade);
            this.tabPeriodicidade.Location = new System.Drawing.Point(4, 22);
            this.tabPeriodicidade.Name = "tabPeriodicidade";
            this.tabPeriodicidade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeriodicidade.Size = new System.Drawing.Size(832, 440);
            this.tabPeriodicidade.TabIndex = 2;
            this.tabPeriodicidade.Text = "Periodicidade";
            this.tabPeriodicidade.UseVisualStyleBackColor = true;
            // 
            // gridPeriodicidade
            // 
            this.gridPeriodicidade.AllowUserToAddRows = false;
            this.gridPeriodicidade.AllowUserToDeleteRows = false;
            this.gridPeriodicidade.AutoGenerateColumns = false;
            this.gridPeriodicidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPeriodicidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeriodicidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESCRICAODataGridViewTextBoxColumn,
            this.aTIVODataGridViewCheckBoxColumn1});
            this.gridPeriodicidade.DataSource = this.periodicidadeBindingSource;
            this.gridPeriodicidade.Location = new System.Drawing.Point(7, 33);
            this.gridPeriodicidade.Name = "gridPeriodicidade";
            this.gridPeriodicidade.Size = new System.Drawing.Size(345, 168);
            this.gridPeriodicidade.TabIndex = 0;
            this.gridPeriodicidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPeriodicidade_CellContentClick);
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            // 
            // aTIVODataGridViewCheckBoxColumn1
            // 
            this.aTIVODataGridViewCheckBoxColumn1.DataPropertyName = "ATIVO";
            this.aTIVODataGridViewCheckBoxColumn1.HeaderText = "ATIVO";
            this.aTIVODataGridViewCheckBoxColumn1.Name = "aTIVODataGridViewCheckBoxColumn1";
            // 
            // periodicidadeBindingSource
            // 
            this.periodicidadeBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Periodicidade);
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Cidade";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // aTIVODataGridViewCheckBoxColumn
            // 
            this.aTIVODataGridViewCheckBoxColumn.DataPropertyName = "ATIVO";
            this.aTIVODataGridViewCheckBoxColumn.HeaderText = "ATIVO";
            this.aTIVODataGridViewCheckBoxColumn.Name = "aTIVODataGridViewCheckBoxColumn";
            this.aTIVODataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.tabControl);
            this.Name = "FControles";
            this.Text = "Configurações";
            this.tabFeriados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFeriados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCidades.ResumeLayout(false);
            this.tabCidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPeriodicidade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriodicidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private System.Windows.Forms.TabPage tabFeriados;
        private System.Windows.Forms.TabPage tabCidades;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCidades;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView gridFeriados;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtFeriado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFeriado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPeriodicidade;
        private System.Windows.Forms.DataGridView gridPeriodicidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aTIVODataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource periodicidadeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aTIVODataGridViewCheckBoxColumn;
    }
}