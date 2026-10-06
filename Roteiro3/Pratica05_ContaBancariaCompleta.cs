// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Prática 5 — Conta bancária completa
// ============================================================
//
// ENUNCIADO
// ContaBancaria com Titular e Saldo. Regras: titular definido na criação; saldo começa
// em zero; código externo consulta mas não altera o saldo; Depositar() só aceita valor >
// 0; Sacar() não deixa saldo negativo. Esperado: depositar 1000, sacar 250 → 750.
//
// SAÍDA ESPERADA
//   750
//   Saque recusado.
//   750
// ============================================================

using System;

class ContaBancaria
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Depósito precisa ser maior que zero.");
            return;
        }
        Saldo += valor;
    }

    public bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo)
        {
            Console.WriteLine("Saque recusado.");
            return false;
        }
        Saldo -= valor;
        return true;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Carlos");
        conta.Depositar(1000);
        conta.Sacar(250);
        Console.WriteLine(conta.Saldo);

        conta.Sacar(5000);   // recusado
        Console.WriteLine(conta.Saldo);

        // conta.Saldo = -5000;   ERRO de compilação por causa do private set
    }
}
