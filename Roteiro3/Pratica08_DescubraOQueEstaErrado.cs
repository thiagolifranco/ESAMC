// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Prática 8 — Descubra o que está errado
// ============================================================
//
// ENUNCIADO
// Analise a classe abaixo, em que o código externo consegue fazer conta.Saldo =
// -999999;.
//     class Conta
//     {
//         public decimal Saldo { get; set; }
//     
//         public void Depositar(decimal valor)
//         {
//             Saldo += valor;
//         }
//     }
// 1) Qual regra pode ser quebrada?
// 2) Como impedir a alteração externa?
// 3) Como Depositar() continua alterando o saldo?
// 4) Existe situação em que get; set; público é aceitável?
//
// RESPOSTA / OBSERVAÇÕES
// 1) O saldo pode ficar negativo ou mudar sem nenhuma operação (sem depósito ou saque).
// Além disso, Depositar aceitava valor negativo.
// 2) Trocando para { get; private set; }.
// 3) Depositar está dentro da classe, e o private set só bloqueia quem está fora.
// 4) Sim, quando o dado não tem regra nenhuma e qualquer valor é válido, como o Email ou
// um apelido numa classe simples.
//
// SAÍDA ESPERADA
//   200
// ============================================================

using System;

class Conta
{
    public decimal Saldo { get; private set; }   // correção 1

    public void Depositar(decimal valor)
    {
        if (valor > 0)                           // correção 2: valida
            Saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        Conta conta = new Conta();
        conta.Depositar(200);
        conta.Depositar(-50);    // ignorado
        Console.WriteLine(conta.Saldo);
        // conta.Saldo = -999999;   agora não compila
    }
}
