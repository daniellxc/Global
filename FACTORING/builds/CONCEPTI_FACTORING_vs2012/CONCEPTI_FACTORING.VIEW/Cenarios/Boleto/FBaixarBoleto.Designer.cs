using Concepti.Factoring.Data.Entidades;
namespace CONCEPTI_FACTORING.VIEW.Cenarios.Boletos
{
    partial class FBaixarBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBaixarBoleto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.gbChave = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.gridBoletos = new System.Windows.Forms.DataGridView();
            this.boletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBaixar = new System.Windows.Forms.Button();
            this.cODBOLETODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARCELADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVENCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbChave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoletos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCliente);
            this.groupBox1.Controls.Add(this.rdbCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a forma de consulta:";
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCliente.Location = new System.Drawing.Point(6, 74);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(162, 21);
            this.rdbCliente.TabIndex = 1;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Pelo nome do cliente.";
            this.rdbCliente.UseVisualStyleBackColor = true;
            this.rdbCliente.CheckedChanged += new System.EventHandler(this.rdbCliente_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCodigo.Location = new System.Drawing.Point(6, 33);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(167, 21);
            this.rdbCodigo.TabIndex = 0;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Pelo código do boleto.";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // gbChave
            // 
            this.gbChave.Controls.Add(this.btConsultar);
            this.gbChave.Controls.Add(this.txtParam);
            this.gbChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChave.Location = new System.Drawing.Point(307, 12);
            this.gbChave.Name = "gbChave";
            this.gbChave.Size = new System.Drawing.Size(433, 120);
            this.gbChave.TabIndex = 1;
            this.gbChave.TabStop = false;
            this.gbChave.Text = "Consultar:";
            this.gbChave.Visible = false;
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(264, 44);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(100, 23);
            this.btConsultar.TabIndex = 1;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtParam
            // 
            this.txtParam.BackColor = System.Drawing.SystemColors.Info;
            this.txtParam.Location = new System.Drawing.Point(6, 46);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(232, 20);
            this.txtParam.TabIndex = 0;
            // 
            // gridBoletos
            // 
            this.gridBoletos.AllowUserToAddRows = false;
            this.gridBoletos.AllowUserToDeleteRows = false;
            this.gridBoletos.AutoGenerateColumns = false;
            this.gridBoletos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBoletos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBoletos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBoletos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODBOLETODataGridViewTextBoxColumn,
            this.pARCELADataGridViewTextBoxColumn,
            this.dATAVENCIMENTODataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.Column2});
            this.gridBoletos.DataSource = this.boletoBindingSource;
            this.gridBoletos.Location = new System.Drawing.Point(68, 173);
            this.gridBoletos.Name = "gridBoletos";
            this.gridBoletos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.gridBoletos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridBoletos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBoletos.Size = new System.Drawing.Size(672, 324);
            this.gridBoletos.TabIndex = 2;
            this.gridBoletos.Visible = false;
            this.gridBoletos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBoletos_CellContentClick);
            // 
            // boletoBindingSource
            // 
            this.boletoBindingSource.DataSource = typeof(Concepti.Factoring.Data.Entidades.Boleto);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "situacao_boleto";
            this.dataGridViewTextBoxColumn1.HeaderText = "SITUAÇÃO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 629;
            // 
            // btBaixar
            // 
            this.btBaixar.Location = new System.Drawing.Point(589, 503);
            this.btBaixar.Name = "btBaixar";
            this.btBaixar.Size = new System.Drawing.Size(151, 23);
            this.btBaixar.TabIndex = 3;
            this.btBaixar.Text = "Baixar Selecionados";
            this.btBaixar.UseVisualStyleBackColor = true;
            this.btBaixar.Visible = false;
            this.btBaixar.Click += new System.EventHandler(this.btBaixar_Click);
            // 
            // cODBOLETODataGridViewTextBoxColumn
            // 
            this.cODBOLETODataGridViewTextBoxColumn.DataPropertyName = "COD_BOLETO";
            this.cODBOLETODataGridViewTextBoxColumn.HeaderText = "COD. BOLETO";
            this.cODBOLETODataGridViewTextBoxColumn.Name = "cODBOLETODataGridViewTextBoxColumn";
            // 
            // pARCELADataGridViewTextBoxColumn
            // 
            this.pARCELADataGridViewTextBoxColumn.DataPropertyName = "PARCELA";
            this.pARCELADataGridViewTextBoxColumn.HeaderText = "PARCELA";
            this.pARCELADataGridViewTextBoxColumn.Name = "pARCELADataGridViewTextBoxColumn";
            // 
            // dATAVENCIMENTODataGridViewTextBoxColumn
            // 
            this.dATAVENCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DATA_VENCIMENTO";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.HeaderText = "VENCIMENTO";
            this.dATAVENCIMENTODataGridViewTextBoxColumn.Name = "dATAVENCIMENTODataGridViewTextBoxColumn";
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // FBaixarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.btBaixar);
            this.Controls.Add(this.gridBoletos);
            this.Controls.Add(this.gbChave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FBaixarBoleto";
            this.Text = "Baixar Boletos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbChave.ResumeLayout(false);
            this.gbChave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoletos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.GroupBox gbChave;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.DataGridView gridBoletos;
        private System.Windows.Forms.BindingSource boletoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btBaixar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBOLETODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARCELADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVENCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}