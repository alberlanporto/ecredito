namespace Alberlan.eCredito.UI.WF.CalculoFinancimanto
{
    partial class frmCalculoFinanciamento
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
            this.cbTipoFinanciamento = new System.Windows.Forms.ComboBox();
            this.lblTipoFinanciamento = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.qtdParcelas = new System.Windows.Forms.NumericUpDown();
            this.lblQtdParcela = new System.Windows.Forms.Label();
            this.vlrTotal = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.dtaVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.gvParcelas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValidacoes = new System.Windows.Forms.RichTextBox();
            this.lblValidacoes = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTotalFinanciamento = new System.Windows.Forms.Label();
            this.lblTotalJuros = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtdParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlrTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoFinanciamento
            // 
            this.cbTipoFinanciamento.FormattingEnabled = true;
            this.cbTipoFinanciamento.Location = new System.Drawing.Point(290, 35);
            this.cbTipoFinanciamento.Name = "cbTipoFinanciamento";
            this.cbTipoFinanciamento.Size = new System.Drawing.Size(133, 21);
            this.cbTipoFinanciamento.TabIndex = 0;
            // 
            // lblTipoFinanciamento
            // 
            this.lblTipoFinanciamento.AutoSize = true;
            this.lblTipoFinanciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFinanciamento.Location = new System.Drawing.Point(287, 16);
            this.lblTipoFinanciamento.Name = "lblTipoFinanciamento";
            this.lblTipoFinanciamento.Size = new System.Drawing.Size(136, 13);
            this.lblTipoFinanciamento.TabIndex = 1;
            this.lblTipoFinanciamento.Text = "Tipo de Financiamento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(9, 16);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(12, 35);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(272, 21);
            this.cbCliente.TabIndex = 2;
            // 
            // qtdParcelas
            // 
            this.qtdParcelas.Location = new System.Drawing.Point(164, 82);
            this.qtdParcelas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.qtdParcelas.Name = "qtdParcelas";
            this.qtdParcelas.Size = new System.Drawing.Size(120, 20);
            this.qtdParcelas.TabIndex = 4;
            // 
            // lblQtdParcela
            // 
            this.lblQtdParcela.AutoSize = true;
            this.lblQtdParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdParcela.Location = new System.Drawing.Point(161, 66);
            this.lblQtdParcela.Name = "lblQtdParcela";
            this.lblQtdParcela.Size = new System.Drawing.Size(87, 13);
            this.lblQtdParcela.TabIndex = 5;
            this.lblQtdParcela.Text = "Qtde Parcelas";
            // 
            // vlrTotal
            // 
            this.vlrTotal.DecimalPlaces = 2;
            this.vlrTotal.Location = new System.Drawing.Point(12, 82);
            this.vlrTotal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.vlrTotal.Name = "vlrTotal";
            this.vlrTotal.Size = new System.Drawing.Size(146, 20);
            this.vlrTotal.TabIndex = 6;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(9, 66);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            // 
            // dtaVencimento
            // 
            this.dtaVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtaVencimento.Location = new System.Drawing.Point(290, 82);
            this.dtaVencimento.Name = "dtaVencimento";
            this.dtaVencimento.Size = new System.Drawing.Size(133, 20);
            this.dtaVencimento.TabIndex = 8;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimento.Location = new System.Drawing.Point(287, 66);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(89, 13);
            this.lblVencimento.TabIndex = 9;
            this.lblVencimento.Text = "1º Vencimento";
            // 
            // gvParcelas
            // 
            this.gvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvParcelas.Location = new System.Drawing.Point(12, 167);
            this.gvParcelas.Name = "gvParcelas";
            this.gvParcelas.Size = new System.Drawing.Size(796, 291);
            this.gvParcelas.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parcelas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(290, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValidacoes
            // 
            this.txtValidacoes.BackColor = System.Drawing.SystemColors.Info;
            this.txtValidacoes.Location = new System.Drawing.Point(439, 35);
            this.txtValidacoes.Name = "txtValidacoes";
            this.txtValidacoes.ReadOnly = true;
            this.txtValidacoes.Size = new System.Drawing.Size(369, 126);
            this.txtValidacoes.TabIndex = 13;
            this.txtValidacoes.Text = "";
            // 
            // lblValidacoes
            // 
            this.lblValidacoes.AutoSize = true;
            this.lblValidacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacoes.Location = new System.Drawing.Point(436, 19);
            this.lblValidacoes.Name = "lblValidacoes";
            this.lblValidacoes.Size = new System.Drawing.Size(69, 13);
            this.lblValidacoes.TabIndex = 14;
            this.lblValidacoes.Text = "Validações";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(650, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // lblTotalFinanciamento
            // 
            this.lblTotalFinanciamento.AutoSize = true;
            this.lblTotalFinanciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinanciamento.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalFinanciamento.Location = new System.Drawing.Point(12, 461);
            this.lblTotalFinanciamento.Name = "lblTotalFinanciamento";
            this.lblTotalFinanciamento.Size = new System.Drawing.Size(142, 15);
            this.lblTotalFinanciamento.TabIndex = 16;
            this.lblTotalFinanciamento.Text = "Total Financiamento:";
            // 
            // lblTotalJuros
            // 
            this.lblTotalJuros.AutoSize = true;
            this.lblTotalJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalJuros.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalJuros.Location = new System.Drawing.Point(12, 481);
            this.lblTotalJuros.Name = "lblTotalJuros";
            this.lblTotalJuros.Size = new System.Drawing.Size(82, 15);
            this.lblTotalJuros.TabIndex = 17;
            this.lblTotalJuros.Text = "Total Juros:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(599, 464);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(209, 32);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar Financiamento";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmCalculoFinanciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 504);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTotalJuros);
            this.Controls.Add(this.lblTotalFinanciamento);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblValidacoes);
            this.Controls.Add(this.txtValidacoes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvParcelas);
            this.Controls.Add(this.lblVencimento);
            this.Controls.Add(this.dtaVencimento);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.vlrTotal);
            this.Controls.Add(this.lblQtdParcela);
            this.Controls.Add(this.qtdParcelas);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblTipoFinanciamento);
            this.Controls.Add(this.cbTipoFinanciamento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculoFinanciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo para Financiamento de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.qtdParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlrTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoFinanciamento;
        private System.Windows.Forms.Label lblTipoFinanciamento;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.NumericUpDown qtdParcelas;
        private System.Windows.Forms.Label lblQtdParcela;
        private System.Windows.Forms.NumericUpDown vlrTotal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DateTimePicker dtaVencimento;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.DataGridView gvParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox txtValidacoes;
        private System.Windows.Forms.Label lblValidacoes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTotalFinanciamento;
        private System.Windows.Forms.Label lblTotalJuros;
        private System.Windows.Forms.Button btnConfirmar;
    }
}