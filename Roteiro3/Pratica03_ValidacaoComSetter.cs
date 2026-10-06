// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Prática 3 — Validação com setter
// ============================================================
//
// ENUNCIADO
// Classe Produto com Preco que pode ser alterado, não pode ser negativo e lança
// ArgumentException se receber valor inválido. Teste 100, 250 e -50 com try/catch.
// Depois crie Nome que não aceita texto vazio.
//
// RESPOSTA / OBSERVAÇÕES
// Quando a exceção é lançada, o resto do bloco try é pulado e o valor inválido não é
// gravado: o preço continua 250.
//
// SAÍDA ESPERADA
//   Mouse: 100
//   Mouse: 250
//   Erro: O preço não pode ser negativo.
//   Preço final: 250
//   Erro: O nome não pode ser vazio.
// ============================================================

using System;

class Produto
{
    private decimal preco;
    private string nome;

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
                throw new ArgumentException("O preço não pode ser negativo.");
            preco = value;
        }
    }

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio.");
            nome = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        try
        {
            produto.Nome = "Mouse";
            produto.Preco = 100;
            Console.WriteLine($"{produto.Nome}: {produto.Preco}");

            produto.Preco = 250;
            Console.WriteLine($"{produto.Nome}: {produto.Preco}");

            produto.Preco = -50;   // lança a exceção
            Console.WriteLine("Esta linha não é executada.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }

        Console.WriteLine($"Preço final: {produto.Preco}");

        try
        {
            produto.Nome = "";
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
