using MeuBolso.Data;
using MeuBolso.Models;
using MeuBolso.Services;

namespace MeuBolso.Forms
{
    /// <summary>CRUD de categorias.</summary>
    public partial class FormCategorias : Form
    {
        private int _idSelecionado = 0; // 0 = novo registro

        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            Estilo.ConfigurarGrid(dgv);
            Estilo.BotaoNeutro(btnNovo);
            Estilo.BotaoPrimario(btnSalvar);
            Estilo.BotaoPerigo(btnExcluir);

            cboTipo.DataSource = Enum.GetValues(typeof(TipoLancamento));
            CarregarGrid();
            LimparCampos();
        }

        // READ
        private void CarregarGrid()
        {
            dgv.Rows.Clear();
            foreach (Categoria c in Contexto.Categorias.Listar().OrderBy(c => c.Tipo).ThenBy(c => c.Nome))
            {
                int linha = dgv.Rows.Add(c.Id, c.Nome, c.Tipo.ToString());
                dgv.Rows[linha].Cells[colTipo.Index].Style.ForeColor =
                    c.Tipo == TipoLancamento.Receita ? Estilo.Verde : Estilo.Vermelho;
            }
            dgv.ClearSelection();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = (int)dgv.Rows[e.RowIndex].Cells[colId.Index].Value;
            Categoria c = Contexto.Categorias.ObterPorId(id);
            if (c == null) return;

            _idSelecionado = c.Id;
            txtNome.Text = c.Nome;
            cboTipo.SelectedItem = c.Tipo;
            lblModo.Text = "Editando categoria";
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            txtNome.Clear();
            cboTipo.SelectedItem = TipoLancamento.Despesa;
            lblModo.Text = "Nova categoria";
            dgv.ClearSelection();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e) => LimparCampos();

        // CREATE / UPDATE
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria c = new Categoria
                {
                    Id = _idSelecionado,
                    Nome = txtNome.Text,
                    Tipo = (TipoLancamento)cboTipo.SelectedItem
                };

                bool duplicada = Contexto.Categorias.Listar().Any(x =>
                    x.Id != c.Id && x.Nome.Equals(c.Nome, StringComparison.OrdinalIgnoreCase));
                if (duplicada)
                {
                    Estilo.Erro("Já existe uma categoria com esse nome.");
                    return;
                }

                if (_idSelecionado == 0)
                    Contexto.Categorias.Inserir(c);
                else
                    Contexto.Categorias.Atualizar(c);

                CarregarGrid();
                LimparCampos();
            }
            catch (ArgumentException ex)
            {
                Estilo.Erro(ex.Message);
            }
        }

        // DELETE
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idSelecionado == 0)
            {
                Estilo.Erro("Selecione uma categoria na lista para excluir.");
                return;
            }
            if (FinanceiroService.CategoriaEmUso(_idSelecionado))
            {
                Estilo.Erro("Esta categoria possui lançamentos e não pode ser excluída.");
                return;
            }
            if (!Estilo.Confirmar($"Excluir a categoria \"{txtNome.Text}\"?")) return;

            Contexto.Categorias.Excluir(_idSelecionado);
            CarregarGrid();
            LimparCampos();
        }
    }
}
