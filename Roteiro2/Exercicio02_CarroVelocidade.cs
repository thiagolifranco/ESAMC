// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 02 | Exercício 2 — Carro com controle de velocidade
// ============================================================
//
// ENUNCIADO
// Classe Carro com modelo e velocidadeAtual privados. Construtor recebe o modelo;
// velocidade começa em 0. Acelerar(int), Frear(int) (nunca abaixo de 0) e
// ExibirVelocidade().
// Teste esperado: acelera 50 → 50, freia 30 → 20, freia 50 → 0.
//
// SAÍDA ESPERADA
//   Ferrari: 50 km/h
//   Ferrari: 20 km/h
//   Ferrari: 0 km/h
// ============================================================

using System;

class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public Carro(string modelo)
    {
        this.modelo = modelo;
        velocidadeAtual = 0;
    }

    public void Acelerar(int valor)
    {
        if (valor > 0)
            velocidadeAtual += valor;
    }

    public void Frear(int valor)
    {
        if (valor <= 0) return;

        velocidadeAtual -= valor;
        if (velocidadeAtual < 0)
            velocidadeAtual = 0;   // nunca fica negativa
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine($"{modelo}: {velocidadeAtual} km/h");
    }
}

class Program
{
    static void Main()
    {
        Carro c = new Carro("Ferrari");

        c.Acelerar(50);
        c.ExibirVelocidade();   // 50

        c.Frear(30);
        c.ExibirVelocidade();   // 20

        c.Frear(50);
        c.ExibirVelocidade();   // 0

        // c.velocidadeAtual = -100;   ERRO: campo private
    }
}
