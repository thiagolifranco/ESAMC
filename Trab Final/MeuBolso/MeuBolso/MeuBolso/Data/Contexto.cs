using MeuBolso.Models;

namespace MeuBolso.Data
{
    /// <summary>
    /// Ponto único de acesso aos repositórios.
    /// As telas usam só a interface IRepositorio, então não sabem (nem precisam saber)
    /// se os dados estão no SQLite ou em memória.
    /// </summary>
    public static class Contexto
    {
        // Banco de dados SQLite (os dados ficam salvos no arquivo meubolso.db)
        public static IRepositorio<Categoria> Categorias { get; } = new RepositorioCategorias();
        public static IRepositorio<Conta> Contas { get; } = new RepositorioContas();
        public static IRepositorio<Lancamento> Lancamentos { get; } = new RepositorioLancamentos();
        public static IRepositorio<Meta> Metas { get; } = new RepositorioMetas();

        // Para testar sem banco, basta trocar as linhas acima por:
        // public static IRepositorio<Categoria> Categorias { get; } = new RepositorioMemoria<Categoria>();
        // (e o mesmo para as outras)
    }
}
