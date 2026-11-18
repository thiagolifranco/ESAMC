using System.Globalization;
using Microsoft.Data.Sqlite;
using MeuBolso.Models;

namespace MeuBolso.Data
{
    /// <summary>
    /// Repositório GENÉRICO para SQLite. Ele já sabe fazer o CRUD de qualquer tabela.
    /// Cada classe filha só informa: o nome da tabela, como transformar uma linha
    /// do banco em objeto (Mapear) e como transformar o objeto em colunas (ParaColunas).
    /// Isso é o padrão "Template Method": a base define o algoritmo, as filhas completam os detalhes.
    /// </summary>
    public abstract class RepositorioSqlite<T> : IRepositorio<T> where T : Entidade
    {
        protected abstract string Tabela { get; }

        /// <summary>Converte a linha atual do leitor em um objeto.</summary>
        protected abstract T Mapear(SqliteDataReader leitor);

        /// <summary>Converte o objeto em pares coluna → valor (sem o id).</summary>
        protected abstract Dictionary<string, object> ParaColunas(T entidade);

        // ---------- READ ----------
        public List<T> Listar()
        {
            var lista = new List<T>();
            using var conexao = Database.AbrirConexao();
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {Tabela} ORDER BY id;";
            using var leitor = cmd.ExecuteReader();
            while (leitor.Read())
                lista.Add(Mapear(leitor));
            return lista;
        }

        public T ObterPorId(int id)
        {
            using var conexao = Database.AbrirConexao();
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {Tabela} WHERE id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            using var leitor = cmd.ExecuteReader();
            return leitor.Read() ? Mapear(leitor) : null;
        }

        // ---------- CREATE ----------
        public void Inserir(T entidade)
        {
            Dictionary<string, object> colunas = ParaColunas(entidade);
            string nomes = string.Join(", ", colunas.Keys);
            string parametros = string.Join(", ", colunas.Keys.Select(c => "@" + c));

            using var conexao = Database.AbrirConexao();
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = $"INSERT INTO {Tabela} ({nomes}) VALUES ({parametros}); SELECT last_insert_rowid();";
            AdicionarParametros(cmd, colunas);

            entidade.Id = Convert.ToInt32(cmd.ExecuteScalar()); // devolve o id gerado pelo banco
        }

        // ---------- UPDATE ----------
        public void Atualizar(T entidade)
        {
            Dictionary<string, object> colunas = ParaColunas(entidade);
            string sets = string.Join(", ", colunas.Keys.Select(c => $"{c} = @{c}"));

            using var conexao = Database.AbrirConexao();
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = $"UPDATE {Tabela} SET {sets} WHERE id = @id;";
            AdicionarParametros(cmd, colunas);
            cmd.Parameters.AddWithValue("@id", entidade.Id);

            if (cmd.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("Registro não encontrado.");
        }

        // ---------- DELETE ----------
        public void Excluir(int id)
        {
            using var conexao = Database.AbrirConexao();
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = $"DELETE FROM {Tabela} WHERE id = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            if (cmd.ExecuteNonQuery() == 0)
                throw new InvalidOperationException("Registro não encontrado.");
        }

        // Parâmetros (@nome) evitam SQL Injection: o valor nunca é colado direto no texto do SQL.
        private static void AdicionarParametros(SqliteCommand cmd, Dictionary<string, object> colunas)
        {
            foreach (var par in colunas)
                cmd.Parameters.AddWithValue("@" + par.Key, par.Value ?? DBNull.Value);
        }

        // ---------- utilitários para as classes filhas ----------
        protected const string FormatoData = "yyyy-MM-dd";

        protected static string DataParaTexto(DateTime data) =>
            data.ToString(FormatoData, CultureInfo.InvariantCulture);

        protected static DateTime TextoParaData(string texto) =>
            DateTime.ParseExact(texto, FormatoData, CultureInfo.InvariantCulture);

        protected static decimal LerDecimal(SqliteDataReader leitor, string coluna) =>
            Math.Round(Convert.ToDecimal(leitor.GetDouble(leitor.GetOrdinal(coluna))), 2);

        protected static int LerInt(SqliteDataReader leitor, string coluna) =>
            leitor.GetInt32(leitor.GetOrdinal(coluna));

        protected static string LerTexto(SqliteDataReader leitor, string coluna) =>
            leitor.GetString(leitor.GetOrdinal(coluna));
    }
}
