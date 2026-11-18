namespace MeuBolso.Models
{
    /// <summary>Saída de dinheiro. Herda de Lancamento.</summary>
    public class Despesa : Lancamento
    {
        public override TipoLancamento Tipo => TipoLancamento.Despesa;

        public override decimal ValorComSinal() => -Valor;
    }
}
