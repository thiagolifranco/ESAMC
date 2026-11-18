namespace MeuBolso.Forms
{
    partial class FormResumo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.pnlContas = new System.Windows.Forms.Panel();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.colConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContas = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlReceitas = new System.Windows.Forms.Panel();
            this.lblReceitasTitulo = new System.Windows.Forms.Label();
            this.lblReceitasValor = new System.Windows.Forms.Label();
            this.pnlDespesas = new System.Windows.Forms.Panel();
            this.lblDespesasTitulo = new System.Windows.Forms.Label();
            this.lblDespesasValor = new System.Windows.Forms.Label();
            this.pnlSaldoMes = new System.Windows.Forms.Panel();
            this.lblSaldoMesTitulo = new System.Windows.Forms.Label();
            this.lblSaldoMesValor = new System.Windows.Forms.Label();
            this.pnlSaldoGeral = new System.Windows.Forms.Panel();
            this.lblSaldoGeralTitulo = new System.Windows.Forms.Label();
            this.lblSaldoGeralValor = new System.Windows.Forms.Label();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.pnlGrafico.SuspendLayout();
            this.pnlContas.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlReceitas.SuspendLayout();
            this.pnlDespesas.SuspendLayout();
            this.pnlSaldoMes.SuspendLayout();
            this.pnlSaldoGeral.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlGrafico
            //
            this.pnlGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrafico.TabIndex = 3;
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            this.pnlGrafico.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            //
            // pnlContas
            //
            this.pnlContas.Controls.Add(this.dgvContas);
            this.pnlContas.Controls.Add(this.lblContas);
            this.pnlContas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContas.Size = new System.Drawing.Size(380, 400);
            this.pnlContas.Padding = new System.Windows.Forms.Padding(16, 8, 8, 16);
            this.pnlContas.TabIndex = 2;
            this.pnlContas.Name = "pnlContas";
            //
            // dgvContas
            //
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConta,
            this.colSaldo});
            this.dgvContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContas.TabIndex = 0;
            this.dgvContas.Name = "dgvContas";
            //
            // colConta
            //
            this.colConta.FillWeight = 60F;
            this.colConta.HeaderText = "Conta";
            this.colConta.Name = "colConta";
            this.colConta.ReadOnly = true;
            //
            // colSaldo
            //
            this.colSaldo.FillWeight = 40F;
            this.colSaldo.HeaderText = "Saldo atual";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            //
            // lblContas
            //
            this.lblContas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContas.Size = new System.Drawing.Size(356, 28);
            this.lblContas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblContas.Text = "Saldo por conta";
            this.lblContas.Name = "lblContas";
            //
            // pnlCards
            //
            this.pnlCards.Controls.Add(this.pnlReceitas);
            this.pnlCards.Controls.Add(this.pnlDespesas);
            this.pnlCards.Controls.Add(this.pnlSaldoMes);
            this.pnlCards.Controls.Add(this.pnlSaldoGeral);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Size = new System.Drawing.Size(1000, 108);
            this.pnlCards.TabIndex = 1;
            this.pnlCards.Name = "pnlCards";
            //
            // pnlReceitas
            //
            this.pnlReceitas.Controls.Add(this.lblReceitasTitulo);
            this.pnlReceitas.Controls.Add(this.lblReceitasValor);
            this.pnlReceitas.Location = new System.Drawing.Point(16, 12);
            this.pnlReceitas.Size = new System.Drawing.Size(220, 84);
            this.pnlReceitas.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlReceitas.Name = "pnlReceitas";
            //
            // lblReceitasTitulo
            //
            this.lblReceitasTitulo.AutoSize = true;
            this.lblReceitasTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblReceitasTitulo.Text = "Receitas do mês";
            this.lblReceitasTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblReceitasTitulo.Name = "lblReceitasTitulo";
            //
            // lblReceitasValor
            //
            this.lblReceitasValor.AutoSize = true;
            this.lblReceitasValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblReceitasValor.Location = new System.Drawing.Point(12, 36);
            this.lblReceitasValor.Text = "R$ 0,00";
            this.lblReceitasValor.Name = "lblReceitasValor";
            //
            // pnlDespesas
            //
            this.pnlDespesas.Controls.Add(this.lblDespesasTitulo);
            this.pnlDespesas.Controls.Add(this.lblDespesasValor);
            this.pnlDespesas.Location = new System.Drawing.Point(248, 12);
            this.pnlDespesas.Size = new System.Drawing.Size(220, 84);
            this.pnlDespesas.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlDespesas.Name = "pnlDespesas";
            //
            // lblDespesasTitulo
            //
            this.lblDespesasTitulo.AutoSize = true;
            this.lblDespesasTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblDespesasTitulo.Text = "Despesas do mês";
            this.lblDespesasTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblDespesasTitulo.Name = "lblDespesasTitulo";
            //
            // lblDespesasValor
            //
            this.lblDespesasValor.AutoSize = true;
            this.lblDespesasValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDespesasValor.Location = new System.Drawing.Point(12, 36);
            this.lblDespesasValor.Text = "R$ 0,00";
            this.lblDespesasValor.Name = "lblDespesasValor";
            //
            // pnlSaldoMes
            //
            this.pnlSaldoMes.Controls.Add(this.lblSaldoMesTitulo);
            this.pnlSaldoMes.Controls.Add(this.lblSaldoMesValor);
            this.pnlSaldoMes.Location = new System.Drawing.Point(480, 12);
            this.pnlSaldoMes.Size = new System.Drawing.Size(220, 84);
            this.pnlSaldoMes.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlSaldoMes.Name = "pnlSaldoMes";
            //
            // lblSaldoMesTitulo
            //
            this.lblSaldoMesTitulo.AutoSize = true;
            this.lblSaldoMesTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblSaldoMesTitulo.Text = "Resultado do mês";
            this.lblSaldoMesTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSaldoMesTitulo.Name = "lblSaldoMesTitulo";
            //
            // lblSaldoMesValor
            //
            this.lblSaldoMesValor.AutoSize = true;
            this.lblSaldoMesValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSaldoMesValor.Location = new System.Drawing.Point(12, 36);
            this.lblSaldoMesValor.Text = "R$ 0,00";
            this.lblSaldoMesValor.Name = "lblSaldoMesValor";
            //
            // pnlSaldoGeral
            //
            this.pnlSaldoGeral.Controls.Add(this.lblSaldoGeralTitulo);
            this.pnlSaldoGeral.Controls.Add(this.lblSaldoGeralValor);
            this.pnlSaldoGeral.Location = new System.Drawing.Point(712, 12);
            this.pnlSaldoGeral.Size = new System.Drawing.Size(220, 84);
            this.pnlSaldoGeral.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlSaldoGeral.Name = "pnlSaldoGeral";
            //
            // lblSaldoGeralTitulo
            //
            this.lblSaldoGeralTitulo.AutoSize = true;
            this.lblSaldoGeralTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblSaldoGeralTitulo.Text = "Saldo total (todas as contas)";
            this.lblSaldoGeralTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSaldoGeralTitulo.Name = "lblSaldoGeralTitulo";
            //
            // lblSaldoGeralValor
            //
            this.lblSaldoGeralValor.AutoSize = true;
            this.lblSaldoGeralValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSaldoGeralValor.Location = new System.Drawing.Point(12, 36);
            this.lblSaldoGeralValor.Text = "R$ 0,00";
            this.lblSaldoGeralValor.Name = "lblSaldoGeralValor";
            //
            // pnlTopo
            //
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblMes);
            this.pnlTopo.Controls.Add(this.dtpMes);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Size = new System.Drawing.Size(900, 56);
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlTopo.TabIndex = 0;
            this.pnlTopo.Name = "pnlTopo";
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Text = "Resumo do mês";
            this.lblTitulo.Name = "lblTitulo";
            //
            // lblMes
            //
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(240, 19);
            this.lblMes.Text = "Mês";
            this.lblMes.Name = "lblMes";
            //
            // dtpMes
            //
            this.dtpMes.Location = new System.Drawing.Point(280, 15);
            this.dtpMes.Size = new System.Drawing.Size(110, 27);
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.CustomFormat = "MM/yyyy";
            this.dtpMes.ShowUpDown = true;
            this.dtpMes.TabIndex = 1;
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.ValueChanged += new System.EventHandler(this.dtpMes_ValueChanged);
            //
            // FormResumo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.pnlContas);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormResumo";
            this.Text = "Resumo";
            this.Load += new System.EventHandler(this.FormResumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.pnlGrafico.ResumeLayout(false);
            this.pnlGrafico.PerformLayout();
            this.pnlContas.ResumeLayout(false);
            this.pnlContas.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCards.PerformLayout();
            this.pnlReceitas.ResumeLayout(false);
            this.pnlReceitas.PerformLayout();
            this.pnlDespesas.ResumeLayout(false);
            this.pnlDespesas.PerformLayout();
            this.pnlSaldoMes.ResumeLayout(false);
            this.pnlSaldoMes.PerformLayout();
            this.pnlSaldoGeral.ResumeLayout(false);
            this.pnlSaldoGeral.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Panel pnlContas;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.Label lblContas;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlReceitas;
        private System.Windows.Forms.Label lblReceitasTitulo;
        private System.Windows.Forms.Label lblReceitasValor;
        private System.Windows.Forms.Panel pnlDespesas;
        private System.Windows.Forms.Label lblDespesasTitulo;
        private System.Windows.Forms.Label lblDespesasValor;
        private System.Windows.Forms.Panel pnlSaldoMes;
        private System.Windows.Forms.Label lblSaldoMesTitulo;
        private System.Windows.Forms.Label lblSaldoMesValor;
        private System.Windows.Forms.Panel pnlSaldoGeral;
        private System.Windows.Forms.Label lblSaldoGeralTitulo;
        private System.Windows.Forms.Label lblSaldoGeralValor;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DateTimePicker dtpMes;
    }
}
