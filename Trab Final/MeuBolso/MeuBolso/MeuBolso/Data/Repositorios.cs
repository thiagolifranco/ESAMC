using Microsoft.Data.Sqlite;
using MeuBolso.Models;

namespace MeuBolso.Data
{
    // Repositórios concretos: cada um só diz como a sua tabela vira objeto e vice-versa.

    public class RepositorioCategorias : RepositorioSqlite<Categoria>
    {
        protected override string Tabela => "categorias";

        protected override Categoria Mapear(SqliteDataReader l) => new Categoria
        {
            Id = LerInt(l, "id"),
            Nome = LerTexto(l, "nome"),
            Tipo = (TipoLancamento)LerInt(l, "tipo")
        };

        protected override Dictionary<string, object> ParaColunas(Categoria c) => new()
        {
            ["nome"] = c.Nome,
            ["tipo"] = (int)c.Tipo
        };
    }

    public class RepositorioContas : RepositorioSqlite<Conta>
    {
        protected override string Tabela => "contas";

        protected override Conta Mapear(SqliteDataReader l) => new Conta
        {
            Id = LerInt(l, "id"),
            Nome = LerTexto(l, "nome"),
            SaldoInicial = LerDecimal(l, "saldo_inicial")
        };

        protected override Dictionary<string, object> ParaColunas(Conta c) => new()
        {
            ["nome"] = c.Nome,
            ["saldo_inicial"] = (double)c.SaldoInicial
        };
    }

    public class RepositorioLancamentos : RepositorioSqlite<Lancamento>
    {
        protected override string Tabela => "lancamentos";

        protected override Lancamento Mapear(SqliteDataReader l)
        {
            // A coluna "tipo" decide qual classe filha criar: Receita ou Despesa.
            Lancamento lanc = Lancamento.Criar((TipoLancamento)LerInt(l, "tipo"));
            lanc.Id = LerInt(l, "id");
            lanc.Descricao = LerTexto(l, "descricao");
            lanc.Valor = LerDecimal(l, "valor");
            lanc.Data = TextoParaData(LerTexto(l, "data"));
            lanc.CategoriaId = LerInt(l, "categoria_id");
            lanc.ContaId = LerInt(l, "conta_id");
            return lanc;
        }

        protected override Dictionary<string, object> ParaColunas(Lancamento x) => new()
        {
            ["tipo"] = (int)x.Tipo,
            ["descricao"] = x.Descricao,
            ["valor"] = (double)x.Valor,
            ["data"] = DataParaTexto(x.Data),
            ["categoria_id"] = x.CategoriaId,
            ["conta_id"] = x.ContaId
        };
    }

    public class RepositorioMetas : RepositorioSqlite<Meta>
    {
        protected override string Tabela => "metas";

        protected override Meta Mapear(SqliteDataReader l) => new Meta
        {
            Id = LerInt(l, "id"),
            Descricao = LerTexto(l, "descricao"),
            ValorAlvo = LerDecimal(l, "valor_alvo"),
            ValorAtual = LerDecimal(l, "valor_atual"),
            Prazo = TextoParaData(LerTexto(l, "prazo"))
        };

        protected override Dictionary<string, object> ParaColunas(Meta m) => new()
        {
            ["descricao"] = m.Descricao,
            ["valor_alvo"] = (double)m.ValorAlvo,
            ["valor_atual"] = (double)m.ValorAtual,
            ["prazo"] = DataParaTexto(m.Prazo)
        };
    }
}
