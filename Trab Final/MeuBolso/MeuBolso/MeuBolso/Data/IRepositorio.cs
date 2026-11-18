using MeuBolso.Models;

namespace MeuBolso.Data
{
    /// <summary>
    /// Contrato do CRUD. As telas só conhecem esta interface,
    /// então trocar a memória pelo banco de dados não muda nada nas telas.
    /// </summary>
    public interface IRepositorio<T> where T : Entidade
    {
        List<T> Listar();                 // Read (todos)
        T ObterPorId(int id);             // Read (um)
        void Inserir(T entidade);         // Create
        void Atualizar(T entidade);       // Update
        void Excluir(int id);             // Delete
    }
}
