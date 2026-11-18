using MeuBolso.Data;
using MeuBolso.Models;
using MeuBolso.Services;

namespace MeuBolso.Forms
{
    /// <summary>CRUD de contas/carteiras.</summary>
    public partial class FormContas : Form, IAtualizavel
    {
        private int _idSelecionado = 0;

        public FormContas()
        {
            InitializeComponent();
        }

        private void FormContas_Load(object sender, EventArgs e)
        {
            Estilo.ConfigurarGrid(dgv);
            Estilo.AlinharDireita(colSaldoInicial);
            Estilo.AlinharDireita(colSaldoAtual);
            Estilo.BotaoNeutro(btnNovo);
            Estilo.BotaoPrimario(btnSalvar);
            Estilo.BotaoPerigo(btnExcluir);

            CarregarGrid();
            LimparCampos();
        }

        // Ao voltar para esta tela, o saldo atual pode ter mudado por causa de novos lançamentos.
        public void AtualizarDados() => CarregarGrid();

        private void CarregarGrid()
        {
            dgv.Rows.Clear();
            foreach (Conta c in Contexto.Contas.Listar().OrderBy(c => c.Nome))
            {
                decimal saldo = FinanceiroService.SaldoDaConta(c);
                int linha = dgv.Rows.Add(c.Id, c.Nome, Estilo.Moeda(c.SaldoInicial), Estilo.Moeda(saldo));
                dgv.Rows[linha].Cells[colSaldoAtual.Index].Style.ForeColor =
                    saldo >= 0 ? Estilo.Verde : Estilo.Vermelho;
            }
            dgv.ClearSelection();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = (int)dgv.Rows[e.RowIndex].Cells[colId.Index].Value;
            Conta c = Contexto.Contas.ObterPorId(id);
            if (c == null) return;

            _idSelecionado = c.Id;
            txtNome.Text = c.Nome;
            nudSaldoInicial.Value = c.SaldoInicial;
            lblModo.Text = "Editando conta";
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            txtNome.Clear();
            nudSaldoInicial.Value = 0;
            lblModo.Text = "Nova conta";
            dgv.ClearSelection();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e) => LimparCampos();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conta c = new Conta
                {
                    Id = _idSelecionado,
                    Nome = txtNome.Text,
                    SaldoInicial = nudSaldoInicial.Value
                };

                if (_idSelecionado == 0)
                    Contexto.Contas.Inserir(c);
                else
                    Contexto.Contas.Atualizar(c);

                CarregarGrid();
                LimparCampos();
            }
            catch (ArgumentException ex)
            {
                Estilo.Erro(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idSelecionado == 0)
            {
                Estilo.Erro("Selecione uma conta na lista para excluir.");
                return;
            }
            if (FinanceiroService.ContaEmUso(_idSelecionado))
            {
                Estilo.Erro("Esta conta possui lançamentos e não pode ser excluída.");
                return;
            }
            if (!Estilo.Confirmar($"Excluir a conta \"{txtNome.Text}\"?")) return;

            Contexto.Contas.Excluir(_idSelecionado);
            CarregarGrid();
            LimparCampos();
        }
    }
}
