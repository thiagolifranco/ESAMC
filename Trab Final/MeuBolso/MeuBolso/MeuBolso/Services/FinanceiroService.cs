using MeuBolso.Data;
using MeuBolso.Models;

namespace MeuBolso.Services
{
    /// <summary>
    /// Regras de negócio e cálculos (saldos, totais, validações de exclusão).
    /// </summary>
    public static class FinanceiroService
    {
        public static List<Lancamento> LancamentosDoMes(int ano, int mes)
        {
            return Contexto.Lancamentos.Listar()
                .Where(l => l.Data.Year == ano && l.Data.Month == mes)
                .OrderBy(l => l.Data)
                .ToList();
        }

        public static decimal TotalReceitas(int ano, int mes) =>
            LancamentosDoMes(ano, mes).OfType<Receita>().Sum(l => l.Valor);

        public static decimal TotalDespesas(int ano, int mes) =>
            LancamentosDoMes(ano, mes).OfType<Despesa>().Sum(l => l.Valor);

        /// <summary>Saldo atual de uma conta = saldo inicial + todos os lançamentos dela.</summary>
        public static decimal SaldoDaConta(Conta conta)
        {
            decimal movimento = Contexto.Lancamentos.Listar()
                .Where(l => l.ContaId == conta.Id)
                .Sum(l => l.ValorComSinal()); // polimorfismo: cada tipo define o sinal
            return conta.SaldoInicial + movimento;
        }

        public static decimal SaldoGeral() =>
            Contexto.Contas.Listar().Sum(SaldoDaConta);

        /// <summary>Total de despesas do mês agrupado por categoria (para o gráfico).</summary>
        public static List<KeyValuePair<string, decimal>> DespesasPorCategoria(int ano, int mes)
        {
            return LancamentosDoMes(ano, mes)
                .OfType<Despesa>()
                .GroupBy(l => NomeCategoria(l.CategoriaId))
                .Select(g => new KeyValuePair<string, decimal>(g.Key, g.Sum(l => l.Valor)))
                .OrderByDescending(kv => kv.Value)
                .ToList();
        }

        public static string NomeCategoria(int id) =>
            Contexto.Categorias.ObterPorId(id)?.Nome ?? "(sem categoria)";

        public static string NomeConta(int id) =>
            Contexto.Contas.ObterPorId(id)?.Nome ?? "(sem conta)";

        public static bool CategoriaEmUso(int categoriaId) =>
            Contexto.Lancamentos.Listar().Any(l => l.CategoriaId == categoriaId);

        public static bool ContaEmUso(int contaId) =>
            Contexto.Lancamentos.Listar().Any(l => l.ContaId == contaId);
    }
}
