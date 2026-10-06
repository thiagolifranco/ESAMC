// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Prática 2 — Pessoa com propriedades automáticas
// ============================================================
//
// ENUNCIADO
// Classe Pessoa com Nome, Idade e Email como propriedades automáticas. No Main: crie,
// atribua, exiba, altere a idade e exiba de novo. Depois transforme Nome em private set
// e observe o erro.
//
// RESPOSTA / OBSERVAÇÕES
// Na primeira parte do exercício, com { get; set; } em todas, você faria p.Nome =
// "Thiago"; no Main. Ao trocar para private set, essa linha deixa de compilar, por isso
// o nome passa a entrar pelo construtor.
//
// SAÍDA ESPERADA
//   Thiago | 34 anos | thiago@email.com
//   Thiago | 35 anos | thiago@email.com
// ============================================================

using System;

class Pessoa
{
    // Versão 1 seria: public string Nome { get; set; }
    // Versão 2 (pedida no fim): Nome só muda dentro da classe
    public string Nome { get; private set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    // como Nome tem private set, o valor entra pelo construtor
    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa("Thiago");
        p.Idade = 34;
        p.Email = "thiago@email.com";

        Console.WriteLine($"{p.Nome} | {p.Idade} anos | {p.Email}");

        p.Idade = 35;
        Console.WriteLine($"{p.Nome} | {p.Idade} anos | {p.Email}");

        // p.Nome = "Outro";
        // ERRO CS0272: o acessador set é inacessível
    }
}
