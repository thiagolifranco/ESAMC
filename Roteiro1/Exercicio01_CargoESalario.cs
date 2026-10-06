// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 01 | Exercício 01 — Cargo e salário
// ============================================================
//
// ENUNCIADO
// a) Altere a classe Pessoa adicionando um atributo Cargo.
// b) Crie 3 objetos com os cargos Gerente, Desenvolvedor e Estagiário.
// c) Crie um método que informe o salário de cada um: Gerente R$ 10.000, Desenvolvedor
// R$ 5.000, Estagiário R$ 100. O salário não deve ser atributo.
//
// RESPOSTA / OBSERVAÇÕES
// O :C formata como moeda conforme o idioma do computador; em português aparece "R$". A
// ideia central: salário é consequência do cargo, então é calculado num método.
//
// SAÍDA ESPERADA
//   Olá, meu nome é Ana, tenho 40 anos e sou Gerente.
//   Salário de Ana: R$ 10.000,00
//   Olá, meu nome é Bruno, tenho 28 anos e sou Desenvolvedor.
//   Salário de Bruno: R$ 5.000,00
//   Olá, meu nome é Carla, tenho 20 anos e sou Estagiário.
//   Salário de Carla: R$ 100,00
// ============================================================

using System;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Cargo}.");
    }

    // O salário NÃO é atributo: é calculado a partir do cargo
    public void InformarSalario()
    {
        decimal salario = 0;

        if (Cargo == "Gerente")
            salario = 10000;
        else if (Cargo == "Desenvolvedor")
            salario = 5000;
        else if (Cargo == "Estagiário")
            salario = 100;

        Console.WriteLine($"Salário de {Nome}: {salario:C}");
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ana";
        p1.Idade = 40;
        p1.Cargo = "Gerente";

        Pessoa p2 = new Pessoa();
        p2.Nome = "Bruno";
        p2.Idade = 28;
        p2.Cargo = "Desenvolvedor";

        Pessoa p3 = new Pessoa();
        p3.Nome = "Carla";
        p3.Idade = 20;
        p3.Cargo = "Estagiário";

        p1.Apresentar();
        p1.InformarSalario();
        p2.Apresentar();
        p2.InformarSalario();
        p3.Apresentar();
        p3.InformarSalario();
    }
}
