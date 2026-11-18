namespace MeuBolso.Models
{
    /// <summary>Entrada de dinheiro. Herda de Lancamento.</summary>
    public class Receita : Lancamento
    {
        public override TipoLancamento Tipo => TipoLancamento.Receita;

        public override decimal ValorComSinal() => Valor;
    }
}
