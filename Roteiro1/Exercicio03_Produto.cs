// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 01 | Exercício 03 — Classe Produto
// ============================================================
//
// ENUNCIADO
// Classe Produto com nome, preco e quantidade. Métodos ExibirDados() e
// CalcularValorTotal() (retorna preço × quantidade). Crie 3 produtos, exiba os dados e o
// valor total de cada um.
//
// RESPOSTA / OBSERVAÇÕES
// O m em 2.50m indica que o número é decimal (o tipo certo para dinheiro).
// CalcularValorTotal() retorna o valor em vez de imprimir, por isso o Main decide como
// exibir.
//
// SAÍDA ESPERADA
//   Produto: Caneta | Preço: R$ 2,50 | Quantidade: 10
//   Valor total: R$ 25,00
//   Produto: Caderno | Preço: R$ 25,00 | Quantidade: 3
//   Valor total: R$ 75,00
//   Produto: Mochila | Preço: R$ 120,00 | Quantidade: 1
//   Valor total: R$ 120,00
// ============================================================

using System;

public class Produto
{
    public string Nome;
    public decimal Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome} | Preço: {Preco:C} | Quantidade: {Quantidade}");
    }

    public decimal CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.Nome = "Caneta";
        p1.Preco = 2.50m;
        p1.Quantidade = 10;

        Produto p2 = new Produto();
        p2.Nome = "Caderno";
        p2.Preco = 25m;
        p2.Quantidade = 3;

        Produto p3 = new Produto();
        p3.Nome = "Mochila";
        p3.Preco = 120m;
        p3.Quantidade = 1;

        p1.ExibirDados();
        Console.WriteLine($"Valor total: {p1.CalcularValorTotal():C}");
        p2.ExibirDados();
        Console.WriteLine($"Valor total: {p2.CalcularValorTotal():C}");
        p3.ExibirDados();
        Console.WriteLine($"Valor total: {p3.CalcularValorTotal():C}");
    }
}
