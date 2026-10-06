// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Prática 4 — Retângulo com área calculada
// ============================================================
//
// ENUNCIADO
// Classe Retangulo com Largura, Altura e Area (somente leitura, calculada). Teste com 10
// × 5 (esperado 50). Depois mude a largura para 20 e veja a área mudar sozinha.
//
// SAÍDA ESPERADA
//   Área: 50
//   Área depois de mudar a largura: 100
// ============================================================

using System;

class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get { return Largura * Altura; }
    }
}

class Program
{
    static void Main()
    {
        Retangulo r = new Retangulo();
        r.Largura = 10;
        r.Altura = 5;
        Console.WriteLine("Área: " + r.Area);

        r.Largura = 20;
        Console.WriteLine("Área depois de mudar a largura: " + r.Area);

        // r.Area = 1000;   ERRO: Area não tem set
    }
}
