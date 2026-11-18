using MeuBolso.Data;
using MeuBolso.Models;

namespace MeuBolso.Forms
{
    /// <summary>CRUD de metas de economia, com barra de progresso.</summary>
    public partial class FormMetas : Form
    {
        private int _idSelecionado = 0;

        public FormMetas()
        {
            InitializeComponent();
        }

        private void FormMetas_Load(object sender, EventArgs e)
        {
            Estilo.ConfigurarGrid(dgv);
            Estilo.AlinharDireita(colAlvo);
            Estilo.AlinharDireita(colAtual);
            Estilo.AlinharDireita(colProgresso);
            Estilo.BotaoNeutro(btnNovo);
            Estilo.BotaoPrimario(btnSalvar);
            Estilo.BotaoPerigo(btnExcluir);

            nudAlvo.ValueChanged += (s, ev) => AtualizarProgresso();
            nudAtual.ValueChanged += (s, ev) => AtualizarProgresso();

            CarregarGrid();
            LimparCampos();
        }

        private void CarregarGrid()
        {
            dgv.Rows.Clear();
            foreach (Meta m in Contexto.Metas.Listar().OrderBy(m => m.Prazo))
            {
                int linha = dgv.Rows.Add(m.Id, m.Descricao, Estilo.Moeda(m.ValorAlvo), Estilo.Moeda(m.ValorAtual),
                    m.Prazo.ToString("dd/MM/yyyy"), m.Percentual + "%");
                if (m.Concluida)
                    dgv.Rows[linha].Cells[colProgresso.Index].Style.ForeColor = Estilo.Verde;
                else if (m.Prazo < DateTime.Today)
                    dgv.Rows[linha].Cells[colPrazo.Index].Style.ForeColor = Estilo.Vermelho;
            }
            dgv.ClearSelection();
        }

        private void AtualizarProgresso()
        {
            int pct = nudAlvo.Value == 0 ? 0 : (int)Math.Min(100, Math.Round(nudAtual.Value / nudAlvo.Value * 100));
            pbProgresso.Value = pct;
            decimal falta = Math.Max(0, nudAlvo.Value - nudAtual.Value);
            lblProgresso.Text = pct >= 100
                ? "Progresso: 100% — meta concluída!"
                : $"Progresso: {pct}% — faltam {Estilo.Moeda(falta)}";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = (int)dgv.Rows[e.RowIndex].Cells[colId.Index].Value;
            Meta m = Contexto.Metas.ObterPorId(id);
            if (m == null) return;

            _idSelecionado = m.Id;
            txtDescricao.Text = m.Descricao;
            nudAlvo.Value = m.ValorAlvo;
            nudAtual.Value = m.ValorAtual;
            dtpPrazo.Value = m.Prazo;
            lblModo.Text = "Editando meta";
            AtualizarProgresso();
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            txtDescricao.Clear();
            nudAlvo.Value = 0;
            nudAtual.Value = 0;
            dtpPrazo.Value = DateTime.Today.AddMonths(6);
            lblModo.Text = "Nova meta";
            dgv.ClearSelection();
            AtualizarProgresso();
            txtDescricao.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e) => LimparCampos();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Meta m = new Meta
                {
                    Id = _idSelecionado,
                    Descricao = txtDescricao.Text,
                    ValorAlvo = nudAlvo.Value,
                    ValorAtual = nudAtual.Value,
                    Prazo = dtpPrazo.Value.Date
                };

                if (_idSelecionado == 0)
                    Contexto.Metas.Inserir(m);
                else
                    Contexto.Metas.Atualizar(m);

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
                Estilo.Erro("Selecione uma meta na lista para excluir.");
                return;
            }
            if (!Estilo.Confirmar($"Excluir a meta \"{txtDescricao.Text}\"?")) return;

            Contexto.Metas.Excluir(_idSelecionado);
            CarregarGrid();
            LimparCampos();
        }
    }
}
