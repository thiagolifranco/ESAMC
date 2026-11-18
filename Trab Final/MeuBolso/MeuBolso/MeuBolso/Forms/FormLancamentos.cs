using MeuBolso.Data;
using MeuBolso.Models;
using MeuBolso.Services;

namespace MeuBolso.Forms
{
    /// <summary>CRUD de lançamentos (receitas e despesas), com filtro por mês e categoria.</summary>
    public partial class FormLancamentos : Form, IAtualizavel
    {
        private int _idSelecionado = 0;
        private bool _carregando = false; // evita disparar filtros enquanto preenche combos

        public FormLancamentos()
        {
            InitializeComponent();
        }

        private void FormLancamentos_Load(object sender, EventArgs e)
        {
            Estilo.ConfigurarGrid(dgv);
            Estilo.AlinharDireita(colValor);
            Estilo.BotaoNeutro(btnNovo);
            Estilo.BotaoPrimario(btnSalvar);
            Estilo.BotaoPerigo(btnExcluir);

            dtpMes.Value = DateTime.Today;
            CarregarCombos();
            LimparCampos();
            CarregarGrid();
        }

        // Categorias e contas podem ter sido alteradas em outra tela: recarrega ao voltar.
        public void AtualizarDados()
        {
            CarregarCombos();
            CarregarGrid();
        }

        private void CarregarCombos()
        {
            _carregando = true;

            object filtroAtual = cboFiltroCategoria.SelectedItem;
            var filtros = new List<object> { "(todas)" };
            filtros.AddRange(Contexto.Categorias.Listar().OrderBy(c => c.Nome));
            cboFiltroCategoria.DataSource = filtros;
            if (filtroAtual is Categoria cat)
                cboFiltroCategoria.SelectedItem = filtros.OfType<Categoria>().FirstOrDefault(c => c.Id == cat.Id) ?? filtros[0];

            int contaAtual = (cboConta.SelectedItem as Conta)?.Id ?? 0;
            List<Conta> contas = Contexto.Contas.Listar().OrderBy(c => c.Nome).ToList();
            cboConta.DataSource = contas;
            Conta contaSel = contas.FirstOrDefault(c => c.Id == contaAtual);
            if (contaSel != null) cboConta.SelectedItem = contaSel;

            CarregarCategoriasDoTipo();
            _carregando = false;
        }

        private TipoLancamento TipoSelecionado =>
            rdoReceita.Checked ? TipoLancamento.Receita : TipoLancamento.Despesa;

        /// <summary>Mostra no combo apenas categorias do tipo escolhido (receita ou despesa).</summary>
        private void CarregarCategoriasDoTipo()
        {
            int atual = (cboCategoria.SelectedItem as Categoria)?.Id ?? 0;
            List<Categoria> lista = Contexto.Categorias.Listar()
                .Where(c => c.Tipo == TipoSelecionado)
                .OrderBy(c => c.Nome)
                .ToList();
            cboCategoria.DataSource = lista;
            Categoria sel = lista.FirstOrDefault(c => c.Id == atual);
            if (sel != null) cboCategoria.SelectedItem = sel;
        }

        private void rdoTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) CarregarCategoriasDoTipo();
        }

        private void filtros_Changed(object sender, EventArgs e)
        {
            if (!_carregando) CarregarGrid();
        }

        // READ
        private void CarregarGrid()
        {
            int ano = dtpMes.Value.Year, mes = dtpMes.Value.Month;
            List<Lancamento> lista = FinanceiroService.LancamentosDoMes(ano, mes);

            if (cboFiltroCategoria.SelectedItem is Categoria filtro)
                lista = lista.Where(l => l.CategoriaId == filtro.Id).ToList();

            dgv.Rows.Clear();
            foreach (Lancamento l in lista)
            {
                string valor = (l.Tipo == TipoLancamento.Receita ? "+ " : "- ") + Estilo.Moeda(l.Valor);
                int linha = dgv.Rows.Add(l.Id, l.Data.ToString("dd/MM/yyyy"), l.Descricao,
                    FinanceiroService.NomeCategoria(l.CategoriaId), FinanceiroService.NomeConta(l.ContaId),
                    l.Tipo.ToString(), valor);
                dgv.Rows[linha].Cells[colValor.Index].Style.ForeColor =
                    l.Tipo == TipoLancamento.Receita ? Estilo.Verde : Estilo.Vermelho;
            }
            dgv.ClearSelection();

            decimal receitas = lista.OfType<Receita>().Sum(l => l.Valor);
            decimal despesas = lista.OfType<Despesa>().Sum(l => l.Valor);
            lblTotais.Text = $"Receitas: {Estilo.Moeda(receitas)}    Despesas: {Estilo.Moeda(despesas)}    " +
                             $"Saldo: {Estilo.Moeda(receitas - despesas)}";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = (int)dgv.Rows[e.RowIndex].Cells[colId.Index].Value;
            Lancamento l = Contexto.Lancamentos.ObterPorId(id);
            if (l == null) return;

            _idSelecionado = l.Id;
            if (l.Tipo == TipoLancamento.Receita) rdoReceita.Checked = true; else rdoDespesa.Checked = true;
            CarregarCategoriasDoTipo();
            txtDescricao.Text = l.Descricao;
            nudValor.Value = l.Valor;
            dtpData.Value = l.Data;
            cboCategoria.SelectedItem = ((List<Categoria>)cboCategoria.DataSource).FirstOrDefault(c => c.Id == l.CategoriaId);
            cboConta.SelectedItem = ((List<Conta>)cboConta.DataSource).FirstOrDefault(c => c.Id == l.ContaId);
            lblModo.Text = "Editando lançamento";
        }

        private void LimparCampos()
        {
            _idSelecionado = 0;
            rdoDespesa.Checked = true;
            txtDescricao.Clear();
            nudValor.Value = 0;
            dtpData.Value = DateTime.Today;
            lblModo.Text = "Novo lançamento";
            dgv.ClearSelection();
            txtDescricao.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e) => LimparCampos();

        // CREATE / UPDATE
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedItem is not Categoria categoria)
            {
                Estilo.Erro("Cadastre ou selecione uma categoria do tipo " + TipoSelecionado + ".");
                return;
            }
            if (cboConta.SelectedItem is not Conta conta)
            {
                Estilo.Erro("Cadastre ou selecione uma conta.");
                return;
            }

            try
            {
                // Polimorfismo: a fábrica devolve Receita ou Despesa conforme o tipo marcado.
                Lancamento l = Lancamento.Criar(TipoSelecionado);
                l.Id = _idSelecionado;
                l.Descricao = txtDescricao.Text;
                l.Valor = nudValor.Value;
                l.Data = dtpData.Value.Date;
                l.CategoriaId = categoria.Id;
                l.ContaId = conta.Id;

                if (_idSelecionado == 0)
                    Contexto.Lancamentos.Inserir(l);
                else
                    Contexto.Lancamentos.Atualizar(l);

                // Mostra o mês do lançamento salvo
                dtpMes.Value = l.Data;
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
                Estilo.Erro("Selecione um lançamento na lista para excluir.");
                return;
            }
            if (!Estilo.Confirmar($"Excluir o lançamento \"{txtDescricao.Text}\"?")) return;

            Contexto.Lancamentos.Excluir(_idSelecionado);
            CarregarGrid();
            LimparCampos();
        }
    }
}
