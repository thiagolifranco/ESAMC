namespace MeuBolso.Models
{
    /// <summary>
    /// Categoria de um lançamento (ex.: Alimentação, Salário, Transporte).
    /// </summary>
    public class Categoria : Entidade
    {
        private string _nome = string.Empty;

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome da categoria é obrigatório.");
                _nome = value.Trim();
            }
        }

        public TipoLancamento Tipo { get; set; }

        public override string ToString() => Nome;
    }
}
