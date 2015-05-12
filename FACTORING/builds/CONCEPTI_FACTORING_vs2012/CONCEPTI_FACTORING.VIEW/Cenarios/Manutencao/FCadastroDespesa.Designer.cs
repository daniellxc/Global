namespace CONCEPTI_FACTORING.VIEW.Cenarios.Manutencao
{
    partial class FCadastroDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadastroDespesa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNovaDespesa = new System.Windows.Forms.Button();
            this.cmbDespesas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecricao = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNovaDespesa);
            this.groupBox1.Controls.Add(this.cmbDespesas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione para Editar";
            // 
            // btNovaDespesa
            // 
            this.btNovaDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaDespesa.Location = new System.Drawing.Point(293, 29);
            this.btNovaDespesa.Name = "btNovaDespesa";
            this.btNovaDespesa.Size = new System.Drawing.Size(75, 23);
            this.btNovaDespesa.TabIndex = 1;
            this.btNovaDespesa.Text = "Novo Tipo";
            this.btNovaDespesa.UseVisualStyleBackColor = true;
            this.btNovaDespesa.Click += new System.EventHandler(this.btNovaDespesa_Click);
            // 
            // cmbDespesas
            // 
            this.cmbDespesas.DisplayMember = "DESCRICAO_DESPESA";
            this.cmbDespesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDespesas.FormattingEnabled = true;
            this.cmbDespesas.Location = new System.Drawing.Point(6, 31);
            this.cmbDespesas.Name = "cmbDespesas";
            this.cmbDespesas.Size = new System.Drawing.Size(262, 21);
            this.cmbDespesas.TabIndex = 0;
            this.cmbDespesas.ValueMember = "COD_TIPO_DESPESA";
            this.cmbDespesas.SelectedIndexChanged += new System.EventHandler(this.cmbDespesas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // txtDecricao
            // 
            this.txtDecricao.BackColor = System.Drawing.SystemColors.Info;
            this.txtDecricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecricao.Location = new System.Drawing.Point(120, 33);
            this.txtDecricao.Name = "txtDecricao";
            this.txtDecricao.Size = new System.Drawing.Size(290, 23);
            this.txtDecricao.TabIndex = 2;
            this.txtDecricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDecricao_Validating);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(335, 81);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Salvar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.button1);
            this.pnInfo.Controls.Add(this.btCadastrar);
            this.pnInfo.Controls.Add(this.txtDecricao);
            this.pnInfo.Controls.Add(this.label1);
            this.pnInfo.Location = new System.Drawing.Point(4, 119);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(490, 116);
            this.pnInfo.TabIndex = 3;
            this.pnInfo.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(235, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FCadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 314);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FCadastroDespesa";
            this.Text = "Cadastro de Tipos de Despesa";
            this.groupBox1.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btNovaDespesa;
        private System.Windows.Forms.ComboBox cmbDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecricao;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}