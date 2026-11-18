using MeuBolso.Data;

namespace MeuBolso.Forms
{
    /// <summary>
    /// Janela principal (MDI). O menu abre cada tela do sistema.
    /// </summary>
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Database.Inicializar(); // cria o banco e as tabelas na primeira execução
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o banco de dados:\n\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            lblStatus.Text = "Banco de dados: " + Database.CaminhoArquivo;
            AbrirTela<FormResumo>();
        }

        /// <summary>
        /// Abre a tela dentro da janela principal. Se ela já estiver aberta, apenas traz para frente.
        /// Método genérico: funciona para qualquer tipo de Form.
        /// </summary>
        private void AbrirTela<T>() where T : Form, new()
        {
            Form existente = MdiChildren.FirstOrDefault(f => f is T);
            if (existente != null)
            {
                existente.Activate();
                if (existente is IAtualizavel atualizavel)
                    atualizavel.AtualizarDados(); // recalcula com os dados mais recentes do banco
                return;
            }

            T tela = new T();
            tela.MdiParent = this;
            tela.WindowState = FormWindowState.Maximized;
            tela.Show();
        }

        private void menuResumo_Click(object sender, EventArgs e) => AbrirTela<FormResumo>();
        private void menuLancamentos_Click(object sender, EventArgs e) => AbrirTela<FormLancamentos>();
        private void menuCategorias_Click(object sender, EventArgs e) => AbrirTela<FormCategorias>();
        private void menuContas_Click(object sender, EventArgs e) => AbrirTela<FormContas>();
        private void menuMetas_Click(object sender, EventArgs e) => AbrirTela<FormMetas>();

        private void menuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sair",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
