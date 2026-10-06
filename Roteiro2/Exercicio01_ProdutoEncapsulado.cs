// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 02 | Exercício 1 — Produto encapsulado
// ============================================================
//
// ENUNCIADO
// Classe Produto com nome e preco privados.
// 1) Construtor recebe nome e preço.
// 2) Preço não pode ser negativo.
// 3) ExibirDetalhes() imprime nome e preço.
// 4) AlterarPreco(decimal novoPreco) altera se válido, ou mostra erro se negativo.
// Teste: criar "Celular" a 1500, tentar alterar para -200, depois para 1200.
//
// RESPOSTA / OBSERVAÇÕES
// this.nome = nome;: o parâmetro tem o mesmo nome do campo, então this diz "o campo
// deste objeto". O return dentro do if sai do método sem alterar nada.
//
// SAÍDA ESPERADA
//   Produto: Celular | Preço: R$ 1.500,00
//   Erro: o preço não pode ser negativo.
//   Produto: Celular | Preço: R$ 1.200,00
// ============================================================

using System;

class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;

        if (preco >= 0)
        {
            this.preco = preco;
        }
        else
        {
            Console.WriteLine("Preço inicial inválido. Definido como 0.");
            this.preco = 0;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {nome} | Preço: {preco:C}");
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
        {
            Console.WriteLine("Erro: o preço não pode ser negativo.");
            return;
        }
        preco = novoPreco;
    }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();

        p.AlterarPreco(-200);   // mensagem de erro
        p.AlterarPreco(1200);
        p.ExibirDetalhes();

        // p.preco = -200;      ERRO de compilação: preco é private
    }
}
