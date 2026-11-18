namespace MeuBolso.Models
{
    /// <summary>
    /// Conta ou carteira onde o dinheiro está (ex.: Nubank, Dinheiro, Poupança).
    /// </summary>
    public class Conta : Entidade
    {
        private string _nome = string.Empty;

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome da conta é obrigatório.");
                _nome = value.Trim();
            }
        }

        public decimal SaldoInicial { get; set; }

        public override string ToString() => Nome;
    }
}
