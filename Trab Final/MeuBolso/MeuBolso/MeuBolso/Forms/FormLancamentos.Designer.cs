namespace MeuBolso.Forms
{
    partial class FormLancamentos
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
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblModo = new System.Windows.Forms.Label();
            this.rdoReceita = new System.Windows.Forms.RadioButton();
            this.rdoDespesa = new System.Windows.Forms.RadioButton();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.cboConta = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cboFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblTotais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            //
            // dgv
            //
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colData,
            this.colDescricao,
            this.colCategoria,
            this.colConta,
            this.colTipo,
            this.colValor});
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
            // colData
            //
            this.colData.FillWeight = 14F;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            //
            // colDescricao
            //
            this.colDescricao.FillWeight = 30F;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            //
            // colCategoria
            //
            this.colCategoria.FillWeight = 20F;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            //
            // colConta
            //
            this.colConta.FillWeight = 16F;
            this.colConta.HeaderText = "Conta";
            this.colConta.Name = "colConta";
            this.colConta.ReadOnly = true;
            //
            // colTipo
            //
            this.colTipo.FillWeight = 12F;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            //
            // colValor
            //
            this.colValor.FillWeight = 16F;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            //
            // pnlForm
            //
            this.pnlForm.Controls.Add(this.lblModo);
            this.pnlForm.Controls.Add(this.rdoReceita);
            this.pnlForm.Controls.Add(this.rdoDespesa);
            this.pnlForm.Controls.Add(this.lblDescricao);
            this.pnlForm.Controls.Add(this.txtDescricao);
            this.pnlForm.Controls.Add(this.lblValor);
            this.pnlForm.Controls.Add(this.nudValor);
            this.pnlForm.Controls.Add(this.lblData);
            this.pnlForm.Controls.Add(this.dtpData);
            this.pnlForm.Controls.Add(this.lblCategoria);
            this.pnlForm.Controls.Add(this.cboCategoria);
            this.pnlForm.Controls.Add(this.lblConta);
            this.pnlForm.Controls.Add(this.cboConta);
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
            // rdoReceita
            //
            this.rdoReceita.AutoSize = true;
            this.rdoReceita.Location = new System.Drawing.Point(16, 52);
            this.rdoReceita.Text = "Receita";
            this.rdoReceita.TabIndex = 9;
            this.rdoReceita.Name = "rdoReceita";
            this.rdoReceita.CheckedChanged += new System.EventHandler(this.rdoTipo_CheckedChanged);
            //
            // rdoDespesa
            //
            this.rdoDespesa.AutoSize = true;
            this.rdoDespesa.Location = new System.Drawing.Point(130, 52);
            this.rdoDespesa.Text = "Despesa";
            this.rdoDespesa.TabIndex = 10;
            this.rdoDespesa.Checked = true;
            this.rdoDespesa.Name = "rdoDespesa";
            this.rdoDespesa.CheckedChanged += new System.EventHandler(this.rdoTipo_CheckedChanged);
            //
            // lblDescricao
            //
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(16, 86);
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Name = "lblDescricao";
            //
            // txtDescricao
            //
            this.txtDescricao.Location = new System.Drawing.Point(16, 110);
            this.txtDescricao.Size = new System.Drawing.Size(300, 27);
            this.txtDescricao.TabIndex = 11;
            this.txtDescricao.Name = "txtDescricao";
            //
            // lblValor
            //
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(16, 146);
            this.lblValor.Text = "Valor (R$)";
            this.lblValor.Name = "lblValor";
            //
            // nudValor
            //
            this.nudValor.Location = new System.Drawing.Point(16, 170);
            this.nudValor.Size = new System.Drawing.Size(300, 27);
            this.nudValor.TabIndex = 12;
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudValor.ThousandsSeparator = true;
            this.nudValor.Name = "nudValor";
            //
            // lblData
            //
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 206);
            this.lblData.Text = "Data";
            this.lblData.Name = "lblData";
            //
            // dtpData
            //
            this.dtpData.Location = new System.Drawing.Point(16, 230);
            this.dtpData.Size = new System.Drawing.Size(300, 27);
            this.dtpData.TabIndex = 13;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Name = "dtpData";
            //
            // lblCategoria
            //
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(16, 266);
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Name = "lblCategoria";
            //
            // cboCategoria
            //
            this.cboCategoria.Location = new System.Drawing.Point(16, 290);
            this.cboCategoria.Size = new System.Drawing.Size(300, 27);
            this.cboCategoria.TabIndex = 14;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Name = "cboCategoria";
            //
            // lblConta
            //
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(16, 326);
            this.lblConta.Text = "Conta";
            this.lblConta.Name = "lblConta";
            //
            // cboConta
            //
            this.cboConta.Location = new System.Drawing.Point(16, 350);
            this.cboConta.Size = new System.Drawing.Size(300, 27);
            this.cboConta.TabIndex = 15;
            this.cboConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConta.Name = "cboConta";
            //
            // btnNovo
            //
            this.btnNovo.Location = new System.Drawing.Point(16, 400);
            this.btnNovo.Size = new System.Drawing.Size(96, 36);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            //
            // btnSalvar
            //
            this.btnSalvar.Location = new System.Drawing.Point(118, 400);
            this.btnSalvar.Size = new System.Drawing.Size(96, 36);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // btnExcluir
            //
            this.btnExcluir.Location = new System.Drawing.Point(220, 400);
            this.btnExcluir.Size = new System.Drawing.Size(96, 36);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            //
            // pnlTopo
            //
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblMes);
            this.pnlTopo.Controls.Add(this.dtpMes);
            this.pnlTopo.Controls.Add(this.lblFiltroCategoria);
            this.pnlTopo.Controls.Add(this.cboFiltroCategoria);
            this.pnlTopo.Controls.Add(this.lblTotais);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Size = new System.Drawing.Size(900, 100);
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlTopo.TabIndex = 0;
            this.pnlTopo.Name = "pnlTopo";
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Text = "Lançamentos";
            this.lblTitulo.Name = "lblTitulo";
            //
            // lblMes
            //
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(16, 62);
            this.lblMes.Text = "Mês";
            this.lblMes.Name = "lblMes";
            //
            // dtpMes
            //
            this.dtpMes.Location = new System.Drawing.Point(56, 58);
            this.dtpMes.Size = new System.Drawing.Size(110, 27);
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.CustomFormat = "MM/yyyy";
            this.dtpMes.ShowUpDown = true;
            this.dtpMes.TabIndex = 1;
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.ValueChanged += new System.EventHandler(this.filtros_Changed);
            //
            // lblFiltroCategoria
            //
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(186, 62);
            this.lblFiltroCategoria.Text = "Categoria";
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            //
            // cboFiltroCategoria
            //
            this.cboFiltroCategoria.Location = new System.Drawing.Point(266, 58);
            this.cboFiltroCategoria.Size = new System.Drawing.Size(200, 27);
            this.cboFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCategoria.TabIndex = 2;
            this.cboFiltroCategoria.Name = "cboFiltroCategoria";
            this.cboFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.filtros_Changed);
            //
            // lblTotais
            //
            this.lblTotais.AutoSize = true;
            this.lblTotais.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotais.Location = new System.Drawing.Point(490, 62);
            this.lblTotais.Text = "";
            this.lblTotais.Name = "lblTotais";
            //
            // FormLancamentos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormLancamentos";
            this.Text = "Lançamentos";
            this.Load += new System.EventHandler(this.FormLancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.RadioButton rdoReceita;
        private System.Windows.Forms.RadioButton rdoDespesa;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.ComboBox cboConta;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.ComboBox cboFiltroCategoria;
        private System.Windows.Forms.Label lblTotais;
    }
}
