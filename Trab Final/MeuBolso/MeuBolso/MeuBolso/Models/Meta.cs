namespace MeuBolso.Models
{
    /// <summary>
    /// Meta de economia (ex.: "Viagem de férias", R$ 5.000 até dezembro).
    /// </summary>
    public class Meta : Entidade
    {
        private string _descricao = string.Empty;
        private decimal _valorAlvo;
        private decimal _valorAtual;

        public string Descricao
        {
            get => _descricao;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A descrição da meta é obrigatória.");
                _descricao = value.Trim();
            }
        }

        public decimal ValorAlvo
        {
            get => _valorAlvo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O valor da meta deve ser maior que zero.");
                _valorAlvo = value;
            }
        }

        public decimal ValorAtual
        {
            get => _valorAtual;
            set
            {
                if (value < 0)
                    throw new ArgumentException("O valor guardado não pode ser negativo.");
                _valorAtual = value;
            }
        }

        public DateTime Prazo { get; set; } = DateTime.Today.AddMonths(6);

        /// <summary>Percentual concluído (0 a 100).</summary>
        public int Percentual =>
            ValorAlvo == 0 ? 0 : (int)Math.Min(100, Math.Round(ValorAtual / ValorAlvo * 100));

        public bool Concluida => ValorAtual >= ValorAlvo;
    }
}
