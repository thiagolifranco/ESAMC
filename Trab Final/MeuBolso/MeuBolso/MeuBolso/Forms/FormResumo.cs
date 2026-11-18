using System.Drawing.Drawing2D;
using MeuBolso.Data;
using MeuBolso.Models;
using MeuBolso.Services;

namespace MeuBolso.Forms
{
    /// <summary>
    /// Painel de resumo: cards de totais do mês, saldo por conta e gráfico de despesas por categoria.
    /// O gráfico é desenhado à mão com GDI+ (não precisa de biblioteca externa).
    /// </summary>
    public partial class FormResumo : Form, IAtualizavel
    {
        private List<KeyValuePair<string, decimal>> _despesasPorCategoria = new();

        public FormResumo()
        {
            InitializeComponent();
        }

        private void FormResumo_Load(object sender, EventArgs e)
        {
            Estilo.ConfigurarGrid(dgvContas);
            Estilo.AlinharDireita(colSaldo);
            dtpMes.Value = DateTime.Today;
            Atualizar();
        }

        // Chamado pela janela principal sempre que o usuário volta para esta tela.
        public void AtualizarDados() => Atualizar();

        private void dtpMes_ValueChanged(object sender, EventArgs e) => Atualizar();

        private void Atualizar()
        {
            int ano = dtpMes.Value.Year, mes = dtpMes.Value.Month;

            decimal receitas = FinanceiroService.TotalReceitas(ano, mes);
            decimal despesas = FinanceiroService.TotalDespesas(ano, mes);
            decimal resultado = receitas - despesas;
            decimal saldoGeral = FinanceiroService.SaldoGeral();

            lblReceitasValor.Text = Estilo.Moeda(receitas);
            lblReceitasValor.ForeColor = Estilo.Verde;
            lblDespesasValor.Text = Estilo.Moeda(despesas);
            lblDespesasValor.ForeColor = Estilo.Vermelho;
            lblSaldoMesValor.Text = Estilo.Moeda(resultado);
            lblSaldoMesValor.ForeColor = resultado >= 0 ? Estilo.Verde : Estilo.Vermelho;
            lblSaldoGeralValor.Text = Estilo.Moeda(saldoGeral);

            dgvContas.Rows.Clear();
            foreach (Conta c in Contexto.Contas.Listar().OrderBy(c => c.Nome))
            {
                decimal saldo = FinanceiroService.SaldoDaConta(c);
                int linha = dgvContas.Rows.Add(c.Nome, Estilo.Moeda(saldo));
                dgvContas.Rows[linha].Cells[colSaldo.Index].Style.ForeColor = saldo >= 0 ? Estilo.Verde : Estilo.Vermelho;
            }
            dgvContas.ClearSelection();

            _despesasPorCategoria = FinanceiroService.DespesasPorCategoria(ano, mes);
            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Resize(object sender, EventArgs e) => pnlGrafico.Invalidate();

        /// <summary>Desenha um gráfico de barras horizontais com as despesas por categoria.</summary>
        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            using var fonteTitulo = new Font("Segoe UI", 11F, FontStyle.Bold);
            using var fonte = new Font("Segoe UI", 9.5F);
            using var pincelTexto = new SolidBrush(Color.FromArgb(60, 60, 60));
            using var pincelFundo = new SolidBrush(Color.FromArgb(240, 242, 245));
            using var pincelBarra = new SolidBrush(Estilo.Vermelho);

            g.DrawString("Despesas por categoria", fonteTitulo, pincelTexto, 16, 8);

            if (_despesasPorCategoria.Count == 0)
            {
                g.DrawString("Nenhuma despesa neste mês.", fonte, Brushes.Gray, 16, 44);
                return;
            }

            decimal maior = _despesasPorCategoria.Max(kv => kv.Value);
            decimal total = _despesasPorCategoria.Sum(kv => kv.Value);

            const int margemEsq = 16, larguraRotulo = 130, larguraValor = 150, alturaBarra = 22, espaco = 14;
            int larguraMax = Math.Max(40, pnlGrafico.Width - margemEsq - larguraRotulo - larguraValor - 24);
            int y = 44;

            foreach (var kv in _despesasPorCategoria)
            {
                g.DrawString(kv.Key, fonte, pincelTexto, margemEsq, y + 2);

                int x = margemEsq + larguraRotulo;
                g.FillRectangle(pincelFundo, x, y, larguraMax, alturaBarra);
                int largura = (int)(larguraMax * (kv.Value / maior));
                g.FillRectangle(pincelBarra, x, y, Math.Max(2, largura), alturaBarra);

                int pct = (int)Math.Round(kv.Value / total * 100);
                g.DrawString($"{Estilo.Moeda(kv.Value)} ({pct}%)", fonte, pincelTexto, x + larguraMax + 8, y + 2);

                y += alturaBarra + espaco;
            }
        }
    }
}
