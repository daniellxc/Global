namespace CONCEPTI_FACTORING.VIEW.Cenarios.Rotas
{
    partial class FCadastroRota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadastroRota));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.gbFundo = new System.Windows.Forms.GroupBox();
            this.btConfirmarValor = new System.Windows.Forms.Button();
            this.txtFundo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDadosRota = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirmarRota = new System.Windows.Forms.Button();
            this.lblValorSaida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbFundo.SuspendLayout();
            this.pnDadosRota.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbVendedor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Vendedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendedores Disponíveis:";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DisplayMember = "NOME";
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(159, 40);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(389, 21);
            this.cmbVendedor.TabIndex = 0;
            this.cmbVendedor.ValueMember = "COD_VENDEDOR";
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            // 
            // gbFundo
            // 
            this.gbFundo.Controls.Add(this.btConfirmarValor);
            this.gbFundo.Controls.Add(this.txtFundo);
            this.gbFundo.Controls.Add(this.label2);
            this.gbFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFundo.Location = new System.Drawing.Point(12, 114);
            this.gbFundo.Name = "gbFundo";
            this.gbFundo.Size = new System.Drawing.Size(309, 100);
            this.gbFundo.TabIndex = 1;
            this.gbFundo.TabStop = false;
            this.gbFundo.Text = "Valor de Saída:";
            this.gbFundo.Visible = false;
            // 
            // btConfirmarValor
            // 
            this.btConfirmarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarValor.Location = new System.Drawing.Point(237, 44);
            this.btConfirmarValor.Name = "btConfirmarValor";
            this.btConfirmarValor.Size = new System.Drawing.Size(32, 23);
            this.btConfirmarValor.TabIndex = 2;
            this.btConfirmarValor.Text = "OK";
            this.btConfirmarValor.UseVisualStyleBackColor = true;
            this.btConfirmarValor.Click += new System.EventHandler(this.btConfirmarValor_Click);
            // 
            // txtFundo
            // 
            this.txtFundo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFundo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFundo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtFundo.Location = new System.Drawing.Point(59, 44);
            this.txtFundo.Name = "txtFundo";
            this.txtFundo.Size = new System.Drawing.Size(135, 27);
            this.txtFundo.TabIndex = 1;
            this.txtFundo.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "R$:";
            // 
            // pnDadosRota
            // 
            this.pnDadosRota.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnDadosRota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDadosRota.Controls.Add(this.label6);
            this.pnDadosRota.Controls.Add(this.btCancelar);
            this.pnDadosRota.Controls.Add(this.btConfirmarRota);
            this.pnDadosRota.Controls.Add(this.lblValorSaida);
            this.pnDadosRota.Controls.Add(this.label5);
            this.pnDadosRota.Controls.Add(this.lblDataInicio);
            this.pnDadosRota.Controls.Add(this.label4);
            this.pnDadosRota.Controls.Add(this.lblNomeVendedor);
            this.pnDadosRota.Controls.Add(this.label3);
            this.pnDadosRota.Location = new System.Drawing.Point(12, 220);
            this.pnDadosRota.Name = "pnDadosRota";
            this.pnDadosRota.Size = new System.Drawing.Size(548, 190);
            this.pnDadosRota.TabIndex = 3;
            this.pnDadosRota.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dados da Rota:";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(346, 160);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 23);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirmarRota
            // 
            this.btConfirmarRota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarRota.Location = new System.Drawing.Point(451, 160);
            this.btConfirmarRota.Name = "btConfirmarRota";
            this.btConfirmarRota.Size = new System.Drawing.Size(90, 23);
            this.btConfirmarRota.TabIndex = 11;
            this.btConfirmarRota.Text = "Confirmar";
            this.btConfirmarRota.UseVisualStyleBackColor = true;
            this.btConfirmarRota.Click += new System.EventHandler(this.btConfirmarRota_Click);
            // 
            // lblValorSaida
            // 
            this.lblValorSaida.AutoSize = true;
            this.lblValorSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaida.Location = new System.Drawing.Point(123, 110);
            this.lblValorSaida.Name = "lblValorSaida";
            this.lblValorSaida.Size = new System.Drawing.Size(75, 13);
            this.lblValorSaida.TabIndex = 13;
            this.lblValorSaida.Text = "valor de saída";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor de Saída:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(123, 73);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(72, 13);
            this.lblDataInicio.TabIndex = 10;
            this.lblDataInicio.Text = "data de início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de Início:";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVendedor.Location = new System.Drawing.Point(123, 40);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(96, 13);
            this.lblNomeVendedor.TabIndex = 8;
            this.lblNomeVendedor.Text = "nome do vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendedor:";
            // 
            // FCadastroRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.pnDadosRota);
            this.Controls.Add(this.gbFundo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCadastroRota";
            this.Text = "Cadastro de Rotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFundo.ResumeLayout(false);
            this.gbFundo.PerformLayout();
            this.pnDadosRota.ResumeLayout(false);
            this.pnDadosRota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.GroupBox gbFundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirmarValor;
        private System.Windows.Forms.TextBox txtFundo;
        private System.Windows.Forms.Panel pnDadosRota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirmarRota;
        private System.Windows.Forms.Label lblValorSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.Label label3;
    }
}