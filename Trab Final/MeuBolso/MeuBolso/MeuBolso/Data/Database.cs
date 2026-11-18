using Microsoft.Data.Sqlite;

namespace MeuBolso.Data
{
    /// <summary>
    /// Cuida do arquivo do banco SQLite: onde ele fica, como abrir conexão
    /// e a criação das tabelas na primeira execução.
    /// </summary>
    public static class Database
    {
        /// <summary>O banco é um arquivo ao lado do .exe (pasta bin\Debug\...).</summary>
        public static string CaminhoArquivo { get; } =
            Path.Combine(AppContext.BaseDirectory, "meubolso.db");

        private static string ConnectionString => $"Data Source={CaminhoArquivo}";

        /// <summary>Abre uma conexão nova (sempre usar com "using").</summary>
        public static SqliteConnection AbrirConexao()
        {
            var conexao = new SqliteConnection(ConnectionString);
            conexao.Open();

            // No SQLite as chaves estrangeiras precisam ser ligadas em cada conexão.
            using var cmd = conexao.CreateCommand();
            cmd.CommandText = "PRAGMA foreign_keys = ON;";
            cmd.ExecuteNonQuery();

            return conexao;
        }

        /// <summary>
        /// Se o banco ainda não tem as tabelas, executa o script database/meubolso.sql
        /// (cria as tabelas e insere os dados de exemplo).
        /// </summary>
        public static void Inicializar()
        {
            using var conexao = AbrirConexao();

            using var verificar = conexao.CreateCommand();
            verificar.CommandText =
                "SELECT COUNT(*) FROM sqlite_master WHERE type = 'table' AND name = 'categorias';";
            bool jaExiste = Convert.ToInt32(verificar.ExecuteScalar()) > 0;
            if (jaExiste) return;

            string script = Path.Combine(AppContext.BaseDirectory, "meubolso.sql");
            if (!File.Exists(script))
                throw new FileNotFoundException("Script do banco não encontrado.", script);

            using var criar = conexao.CreateCommand();
            criar.CommandText = File.ReadAllText(script);
            criar.ExecuteNonQuery();
        }
    }
}
