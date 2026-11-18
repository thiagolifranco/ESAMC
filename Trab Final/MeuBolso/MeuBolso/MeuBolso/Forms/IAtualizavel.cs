namespace MeuBolso.Forms
{
    /// <summary>
    /// Telas que mostram dados calculados a partir de outras telas
    /// (ex.: o Resumo depende dos Lançamentos) implementam esta interface.
    /// A janela principal chama AtualizarDados() sempre que a tela volta a ficar ativa.
    /// </summary>
    public interface IAtualizavel
    {
        void AtualizarDados();
    }
}
