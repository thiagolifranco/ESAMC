namespace MeuBolso.Models
{
    /// <summary>
    /// Classe ABSTRATA que representa uma movimentação financeira.
    /// Não pode ser instanciada diretamente: use Receita ou Despesa.
    /// </summary>
    public abstract class Lancamento : Entidade
    {
        private string _descricao = string.Empty;
        private decimal _valor;

        public string Descricao
        {
            get => _descricao;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A descrição é obrigatória.");
                _descricao = value.Trim();
            }
        }

        /// <summary>Valor sempre positivo. O sinal é definido pelo tipo (polimorfismo).</summary>
        public decimal Valor
        {
            get => _valor;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O valor deve ser maior que zero.");
                _valor = value;
            }
        }

        public DateTime Data { get; set; } = DateTime.Today;
        public int CategoriaId { get; set; }
        public int ContaId { get; set; }

        /// <summary>Cada classe filha define se é receita ou despesa.</summary>
        public abstract TipoLancamento Tipo { get; }

        /// <summary>Valor com sinal: positivo para receita, negativo para despesa.</summary>
        public abstract decimal ValorComSinal();

        /// <summary>
        /// Fábrica: cria a classe filha correta a partir do tipo.
        /// </summary>
        public static Lancamento Criar(TipoLancamento tipo)
        {
            return tipo == TipoLancamento.Receita ? new Receita() : new Despesa();
        }
    }
}
