// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Prática 1 — Transformando GetSaldo() em propriedade
// ============================================================
//
// ENUNCIADO
// Substitua GetSaldo() por uma propriedade Saldo. Deve permitir
// Console.WriteLine(conta.Saldo); mas não conta.Saldo = 1000;. Explique em comentário
// por que Saldo é somente leitura para o código externo.
//
// SAÍDA ESPERADA
//   100
// ============================================================

using System;

class ContaBancaria
{
    private decimal saldo;

    // Saldo é somente leitura para o código externo porque o saldo
    // só deve mudar por operações com regras (Depositar, Sacar).
    // Se fosse alterável direto, alguém poderia colocar -5000.
    public decimal Saldo
    {
        get { return saldo; }
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
            saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(100);
        Console.WriteLine(conta.Saldo);

        // conta.Saldo = 1000;   ERRO: a propriedade não tem set
    }
}
