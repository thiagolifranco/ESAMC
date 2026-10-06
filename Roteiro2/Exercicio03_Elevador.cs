// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 02 | Exercício 3 — Elevador
// ============================================================
//
// ENUNCIADO
// Classe Elevador com andarAtual e totalAndares privados. Construtor recebe o total de
// andares; começa no andar 0. Subir() e Descer() mudam 1 andar, sem passar do último nem
// abaixo de 0. ExibirAndar().
//
// SAÍDA ESPERADA
//   Andar atual: 2
//   Andar atual: 1
//   Já está no térreo.
//   Andar atual: 0
//   --- Teste adicional ---
//   Já está no térreo.
//   Andar atual: 0
//   Já está no último andar.
//   Andar atual: 3
// ============================================================

using System;

class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        andarAtual = 0;
    }

    public void Subir()
    {
        if (andarAtual < totalAndares)
            andarAtual++;
        else
            Console.WriteLine("Já está no último andar.");
    }

    public void Descer()
    {
        if (andarAtual > 0)
            andarAtual--;
        else
            Console.WriteLine("Já está no térreo.");
    }

    public void ExibirAndar()
    {
        Console.WriteLine($"Andar atual: {andarAtual}");
    }
}

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(10);
        e.Subir();
        e.Subir();
        e.ExibirAndar();   // 2
        e.Descer();
        e.ExibirAndar();   // 1
        e.Descer();
        e.Descer();        // tenta passar do 0
        e.ExibirAndar();   // 0

        Console.WriteLine("--- Teste adicional ---");
        Elevador e2 = new Elevador(3);
        e2.Descer();
        e2.ExibirAndar();  // 0
        e2.Subir();
        e2.Subir();
        e2.Subir();
        e2.Subir();        // tenta passar do 3
        e2.ExibirAndar();  // 3
    }
}
