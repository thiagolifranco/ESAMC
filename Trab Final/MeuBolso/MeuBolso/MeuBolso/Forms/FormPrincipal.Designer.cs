namespace MeuBolso.Forms
{
    partial class FormPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuResumo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMetas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip
            //
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuResumo,
            this.menuLancamentos,
            this.menuCategorias,
            this.menuContas,
            this.menuMetas,
            this.menuSair});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1100, 31);
            this.menuStrip.TabIndex = 0;
            //
            // menuResumo
            //
            this.menuResumo.Name = "menuResumo";
            this.menuResumo.Size = new System.Drawing.Size(80, 23);
            this.menuResumo.Text = "&Resumo";
            this.menuResumo.Click += new System.EventHandler(this.menuResumo_Click);
            //
            // menuLancamentos
            //
            this.menuLancamentos.Name = "menuLancamentos";
            this.menuLancamentos.Size = new System.Drawing.Size(110, 23);
            this.menuLancamentos.Text = "&Lançamentos";
            this.menuLancamentos.Click += new System.EventHandler(this.menuLancamentos_Click);
            //
            // menuCategorias
            //
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(95, 23);
            this.menuCategorias.Text = "&Categorias";
            this.menuCategorias.Click += new System.EventHandler(this.menuCategorias_Click);
            //
            // menuContas
            //
            this.menuContas.Name = "menuContas";
            this.menuContas.Size = new System.Drawing.Size(70, 23);
            this.menuContas.Text = "C&ontas";
            this.menuContas.Click += new System.EventHandler(this.menuContas_Click);
            //
            // menuMetas
            //
            this.menuMetas.Name = "menuMetas";
            this.menuMetas.Size = new System.Drawing.Size(65, 23);
            this.menuMetas.Text = "&Metas";
            this.menuMetas.Click += new System.EventHandler(this.menuMetas_Click);
            //
            // menuSair
            //
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(45, 23);
            this.menuSair.Text = "&Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            //
            // statusStrip
            //
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 678);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip.TabIndex = 1;
            //
            // lblStatus
            //
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 17);
            this.lblStatus.Text = "Pronto";
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeuBolso — Controle Financeiro Pessoal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuResumo;
        private System.Windows.Forms.ToolStripMenuItem menuLancamentos;
        private System.Windows.Forms.ToolStripMenuItem menuCategorias;
        private System.Windows.Forms.ToolStripMenuItem menuContas;
        private System.Windows.Forms.ToolStripMenuItem menuMetas;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
