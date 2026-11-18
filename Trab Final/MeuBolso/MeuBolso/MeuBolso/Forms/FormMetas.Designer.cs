namespace MeuBolso.Forms
{
    partial class FormMetas
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
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblAlvo = new System.Windows.Forms.Label();
            this.nudAlvo = new System.Windows.Forms.NumericUpDown();
            this.lblAtual = new System.Windows.Forms.Label();
            this.nudAtual = new System.Windows.Forms.NumericUpDown();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.pbProgresso = new System.Windows.Forms.ProgressBar();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtual)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            //
            // dgv
            //
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDescricao,
            this.colAlvo,
            this.colAtual,
            this.colPrazo,
            this.colProgresso});
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
            // colDescricao
            //
            this.colDescricao.FillWeight = 34F;
            this.colDescricao.HeaderText = "Meta";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            //
            // colAlvo
            //
            this.colAlvo.FillWeight = 18F;
            this.colAlvo.HeaderText = "Valor alvo";
            this.colAlvo.Name = "colAlvo";
            this.colAlvo.ReadOnly = true;
            //
            // colAtual
            //
            this.colAtual.FillWeight = 18F;
            this.colAtual.HeaderText = "Guardado";
            this.colAtual.Name = "colAtual";
            this.colAtual.ReadOnly = true;
            //
            // colPrazo
            //
            this.colPrazo.FillWeight = 14F;
            this.colPrazo.HeaderText = "Prazo";
            this.colPrazo.Name = "colPrazo";
            this.colPrazo.ReadOnly = true;
            //
            // colProgresso
            //
            this.colProgresso.FillWeight = 14F;
            this.colProgresso.HeaderText = "Progresso";
            this.colProgresso.Name = "colProgresso";
            this.colProgresso.ReadOnly = true;
            //
            // pnlForm
            //
            this.pnlForm.Controls.Add(this.lblModo);
            this.pnlForm.Controls.Add(this.lblDescricao);
            this.pnlForm.Controls.Add(this.txtDescricao);
            this.pnlForm.Controls.Add(this.lblAlvo);
            this.pnlForm.Controls.Add(this.nudAlvo);
            this.pnlForm.Controls.Add(this.lblAtual);
            this.pnlForm.Controls.Add(this.nudAtual);
            this.pnlForm.Controls.Add(this.lblPrazo);
            this.pnlForm.Controls.Add(this.dtpPrazo);
            this.pnlForm.Controls.Add(this.lblProgresso);
            this.pnlForm.Controls.Add(this.pbProgresso);
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
            // lblDescricao
            //
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(16, 56);
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Name = "lblDescricao";
            //
            // txtDescricao
            //
            this.txtDescricao.Location = new System.Drawing.Point(16, 80);
            this.txtDescricao.Size = new System.Drawing.Size(300, 27);
            this.txtDescricao.TabIndex = 10;
            this.txtDescricao.Name = "txtDescricao";
            //
            // lblAlvo
            //
            this.lblAlvo.AutoSize = true;
            this.lblAlvo.Location = new System.Drawing.Point(16, 116);
            this.lblAlvo.Text = "Valor alvo (R$)";
            this.lblAlvo.Name = "lblAlvo";
            //
            // nudAlvo
            //
            this.nudAlvo.Location = new System.Drawing.Point(16, 140);
            this.nudAlvo.Size = new System.Drawing.Size(300, 27);
            this.nudAlvo.TabIndex = 11;
            this.nudAlvo.DecimalPlaces = 2;
            this.nudAlvo.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudAlvo.ThousandsSeparator = true;
            this.nudAlvo.Name = "nudAlvo";
            //
            // lblAtual
            //
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(16, 176);
            this.lblAtual.Text = "Valor já guardado (R$)";
            this.lblAtual.Name = "lblAtual";
            //
            // nudAtual
            //
            this.nudAtual.Location = new System.Drawing.Point(16, 200);
            this.nudAtual.Size = new System.Drawing.Size(300, 27);
            this.nudAtual.TabIndex = 12;
            this.nudAtual.DecimalPlaces = 2;
            this.nudAtual.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudAtual.ThousandsSeparator = true;
            this.nudAtual.Name = "nudAtual";
            //
            // lblPrazo
            //
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Location = new System.Drawing.Point(16, 236);
            this.lblPrazo.Text = "Prazo";
            this.lblPrazo.Name = "lblPrazo";
            //
            // dtpPrazo
            //
            this.dtpPrazo.Location = new System.Drawing.Point(16, 260);
            this.dtpPrazo.Size = new System.Drawing.Size(300, 27);
            this.dtpPrazo.TabIndex = 13;
            this.dtpPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrazo.Name = "dtpPrazo";
            //
            // lblProgresso
            //
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(16, 300);
            this.lblProgresso.Text = "Progresso: 0%";
            this.lblProgresso.Name = "lblProgresso";
            //
            // pbProgresso
            //
            this.pbProgresso.Location = new System.Drawing.Point(16, 324);
            this.pbProgresso.Size = new System.Drawing.Size(300, 22);
            this.pbProgresso.Name = "pbProgresso";
            //
            // btnNovo
            //
            this.btnNovo.Location = new System.Drawing.Point(16, 370);
            this.btnNovo.Size = new System.Drawing.Size(96, 36);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            //
            // btnSalvar
            //
            this.btnSalvar.Location = new System.Drawing.Point(118, 370);
            this.btnSalvar.Size = new System.Drawing.Size(96, 36);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // btnExcluir
            //
            this.btnExcluir.Location = new System.Drawing.Point(220, 370);
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
            this.lblTitulo.Text = "Metas de economia";
            this.lblTitulo.Name = "lblTitulo";
            //
            // FormMetas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormMetas";
            this.Text = "Metas";
            this.Load += new System.EventHandler(this.FormMetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtual)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgresso;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblAlvo;
        private System.Windows.Forms.NumericUpDown nudAlvo;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.NumericUpDown nudAtual;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.ProgressBar pbProgresso;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
