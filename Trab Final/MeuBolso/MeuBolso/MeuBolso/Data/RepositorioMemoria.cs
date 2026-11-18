using MeuBolso.Models;

namespace MeuBolso.Data
{
    /// <summary>
    /// Implementação TEMPORÁRIA do repositório, guardando os dados em uma lista.
    /// Os dados somem ao fechar o programa. Na próxima etapa será criada
    /// uma implementação com banco de dados (RepositorioSqlite).
    /// </summary>
    public class RepositorioMemoria<T> : IRepositorio<T> where T : Entidade
    {
        private readonly List<T> _itens = new List<T>();
        private int _proximoId = 1;

        public List<T> Listar()
        {
            return _itens.ToList();
        }

        public T ObterPorId(int id)
        {
            return _itens.FirstOrDefault(i => i.Id == id);
        }

        public void Inserir(T entidade)
        {
            entidade.Id = _proximoId++;
            _itens.Add(entidade);
        }

        public void Atualizar(T entidade)
        {
            int indice = _itens.FindIndex(i => i.Id == entidade.Id);
            if (indice < 0)
                throw new InvalidOperationException("Registro não encontrado.");
            _itens[indice] = entidade;
        }

        public void Excluir(int id)
        {
            int removidos = _itens.RemoveAll(i => i.Id == id);
            if (removidos == 0)
                throw new InvalidOperationException("Registro não encontrado.");
        }
    }
}
