namespace MeuBolso.Forms
{
    partial class FormContas
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.nudSaldoInicial = new System.Windows.Forms.NumericUpDown();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldoInicial)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            //
            // dgv
            //
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colSaldoInicial,
            this.colSaldoAtual});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.TabIndex = 1;
            this.dgv.Name = "dgv";
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            //
            // colId
            //
            this.colId.FillWeight = 10F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            //
            // colNome
            //
            this.colNome.FillWeight = 50F;
            this.colNome.HeaderText = "Conta";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            //
            // colSaldoInicial
            //
            this.colSaldoInicial.FillWeight = 25F;
            this.colSaldoInicial.HeaderText = "Saldo inicial";
            this.colSaldoInicial.Name = "colSaldoInicial";
            this.colSaldoInicial.ReadOnly = true;
            //
            // colSaldoAtual
            //
            this.colSaldoAtual.FillWeight = 25F;
            this.colSaldoAtual.HeaderText = "Saldo atual";
            this.colSaldoAtual.Name = "colSaldoAtual";
            this.colSaldoAtual.ReadOnly = true;
            //
            // pnlForm
            //
            this.pnlForm.Controls.Add(this.lblModo);
            this.pnlForm.Controls.Add(this.lblNome);
            this.pnlForm.Controls.Add(this.txtNome);
            this.pnlForm.Controls.Add(this.lblSaldoInicial);
            this.pnlForm.Controls.Add(this.nudSaldoInicial);
            this.pnlForm.Controls.Add(this.btnNovo);
            this.pnlForm.Controls.Add(this.btnSalvar);
            this.pnlForm.Controls.Add(this.btnExcluir);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.Size = new System.Drawing.Size(340, 500);
            this.pnlForm.Padding = new System.Windows.Forms.Padding(16);
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlForm.TabIndex = 2;
            this.pnlForm.Name = "pnlForm";
            //
            // lblModo
            //
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblModo.Location = new System.Drawing.Point(16, 16);
            this.lblModo.Text = "Novo registro";
            this.lblModo.Name = "lblModo";
            //
            // lblNome
            //
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 56);
            this.lblNome.Text = "Nome da conta";
            this.lblNome.Name = "lblNome";
            //
            // txtNome
            //
            this.txtNome.Location = new System.Drawing.Point(16, 80);
            this.txtNome.Size = new System.Drawing.Size(300, 27);
            this.txtNome.TabIndex = 10;
            this.txtNome.Name = "txtNome";
            //
            // lblSaldoInicial
            //
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(16, 116);
            this.lblSaldoInicial.Text = "Saldo inicial (R$)";
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            //
            // nudSaldoInicial
            //
            this.nudSaldoInicial.Location = new System.Drawing.Point(16, 140);
            this.nudSaldoInicial.Size = new System.Drawing.Size(300, 27);
            this.nudSaldoInicial.TabIndex = 11;
            this.nudSaldoInicial.DecimalPlaces = 2;
            this.nudSaldoInicial.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudSaldoInicial.ThousandsSeparator = true;
            this.nudSaldoInicial.Minimum = new decimal(new int[] { 100000000, 0, 0, -2147483648 });
            this.nudSaldoInicial.Name = "nudSaldoInicial";
            //
            // btnNovo
            //
            this.btnNovo.Location = new System.Drawing.Point(16, 190);
            this.btnNovo.Size = new System.Drawing.Size(96, 36);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            //
            // btnSalvar
            //
            this.btnSalvar.Location = new System.Drawing.Point(118, 190);
            this.btnSalvar.Size = new System.Drawing.Size(96, 36);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // btnExcluir
            //
            this.btnExcluir.Location = new System.Drawing.Point(220, 190);
            this.btnExcluir.Size = new System.Drawing.Size(96, 36);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            //
            // pnlTopo
            //
            this.pnlTopo.Controls.Add(this.lblTitulo);
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
            this.lblTitulo.Text = "Contas e carteiras";
            this.lblTitulo.Name = "lblTitulo";
            //
            // FormContas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormContas";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.FormContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldoInicial)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoAtual;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.NumericUpDown nudSaldoInicial;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
