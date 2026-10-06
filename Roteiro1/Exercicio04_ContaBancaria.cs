// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 01 | Exercício 04 — Conta bancária
// ============================================================
//
// ENUNCIADO
// Classe ContaBancaria com titular, numeroConta e saldo. Métodos Depositar(valor),
// Sacar(valor) (só se tiver saldo) e ExibirSaldo(). Não permitir saldo negativo. Testar
// com pelo menos duas contas.
//
// RESPOSTA / OBSERVAÇÕES
// A regra "não permitir saldo negativo" só funciona de verdade se saldo for private. Com
// campo público, qualquer um faria c1.saldo = -999. Esse é o gancho para o Roteiro 02
// (encapsulamento).
//
// SAÍDA ESPERADA
//   Thiago: depósito de R$ 500,00 realizado.
//   Thiago: saque de R$ 200,00 realizado.
//   Thiago: saldo insuficiente para sacar R$ 1.000,00.
//   Conta 1001 (Thiago) - Saldo: R$ 300,00
//   Maria: depósito de R$ 100,00 realizado.
//   Maria: valor de depósito inválido.
//   Conta 1002 (Maria) - Saldo: R$ 100,00
// ============================================================

using System;

public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    private decimal saldo;   // private: ninguém mexe direto

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"{Titular}: depósito de {valor:C} realizado.");
        }
        else
        {
            Console.WriteLine($"{Titular}: valor de depósito inválido.");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"{Titular}: saque de {valor:C} realizado.");
        }
        else
        {
            Console.WriteLine($"{Titular}: saldo insuficiente para sacar {valor:C}.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Conta {NumeroConta} ({Titular}) - Saldo: {saldo:C}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria c1 = new ContaBancaria();
        c1.Titular = "Thiago";
        c1.NumeroConta = 1001;

        ContaBancaria c2 = new ContaBancaria();
        c2.Titular = "Maria";
        c2.NumeroConta = 1002;

        c1.Depositar(500);
        c1.Sacar(200);
        c1.Sacar(1000);   // deve ser recusado
        c1.ExibirSaldo();

        c2.Depositar(100);
        c2.Depositar(-50); // inválido
        c2.ExibirSaldo();
    }
}
