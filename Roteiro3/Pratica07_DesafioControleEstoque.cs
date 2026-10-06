// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Desafio — Controle de estoque
// ============================================================
//
// ENUNCIADO
// Classe Produto com Nome, Codigo, Preco, QuantidadeEstoque e EstoqueBaixo. Nome e
// código obrigatórios; preço não negativo; estoque não negativo e não alterável de fora;
// AdicionarEstoque e RemoverEstoque (sem remover mais do que existe); EstoqueBaixo true
// com 5 unidades ou menos.
// Pergunta: por que QuantidadeEstoque deve ter private set?
//
// RESPOSTA / OBSERVAÇÕES
// Resposta: com set público, qualquer código poderia escrever um estoque negativo ou um
// número inventado, pulando as regras de AdicionarEstoque e RemoverEstoque. Com private
// set, o estoque só muda pelos métodos que validam.
//
// SAÍDA ESPERADA
//   20
//   10
//   False
//   Remoção recusada.
//   4
//   True
// ============================================================

using System;

class Produto
{
    public string Nome { get; private set; }
    public string Codigo { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEstoque { get; private set; }

    public bool EstoqueBaixo
    {
        get { return QuantidadeEstoque <= 5; }
    }

    public Produto(string nome, string codigo, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome é obrigatório.");
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("Código é obrigatório.");
        if (preco < 0)
            throw new ArgumentException("Preço não pode ser negativo.");

        Nome = nome;
        Codigo = codigo;
        Preco = preco;
        QuantidadeEstoque = 0;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("Quantidade deve ser maior que zero.");
        QuantidadeEstoque += quantidade;
    }

    public bool RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0 || quantidade > QuantidadeEstoque)
        {
            Console.WriteLine("Remoção recusada.");
            return false;
        }
        QuantidadeEstoque -= quantidade;
        return true;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Teclado", "TEC-001", 150);

        produto.AdicionarEstoque(20);
        Console.WriteLine(produto.QuantidadeEstoque);

        produto.RemoverEstoque(10);
        Console.WriteLine(produto.QuantidadeEstoque);
        Console.WriteLine(produto.EstoqueBaixo);

        produto.RemoverEstoque(50);   // mais do que existe
        produto.RemoverEstoque(6);
        Console.WriteLine(produto.QuantidadeEstoque);
        Console.WriteLine(produto.EstoqueBaixo);

        // produto.QuantidadeEstoque = 500;   não compila (private set)
    }
}
