namespace MeuBolso.Models
{
    /// <summary>
    /// Classe base de todas as entidades do sistema.
    /// Toda entidade tem um Id único (usado pelo repositório e, depois, pelo banco).
    /// </summary>
    public abstract class Entidade
    {
        public int Id { get; set; }
    }
}
