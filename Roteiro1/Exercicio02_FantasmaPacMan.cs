// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 01 | Exercício 02 — Fantasma do PAC-MAN
// ============================================================
//
// ENUNCIADO
// Crie a classe dos fantasmas com pelo menos os atributos habilidade, nick e cor.
// Métodos:
// - GerarFantasma(): imprime os atributos.
// - Mover(string direcao): imprime "Nick se moveu para direção".
//
// SAÍDA ESPERADA
//   Fantasma gerado: Blinky | Cor: Vermelho | Habilidade: Persegue o Pac-Man diretamente
//   Fantasma gerado: Pinky | Cor: Rosa | Habilidade: Prepara emboscadas
//   Blinky se moveu para cima
//   Pinky se moveu para esquerda
// ============================================================

using System;

public class Fantasma
{
    public string Nick;
    public string Cor;
    public string Habilidade;

    public void GerarFantasma()
    {
        Console.WriteLine($"Fantasma gerado: {Nick} | Cor: {Cor} | Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}

public class Program
{
    public static void Main()
    {
        Fantasma blinky = new Fantasma();
        blinky.Nick = "Blinky";
        blinky.Cor = "Vermelho";
        blinky.Habilidade = "Persegue o Pac-Man diretamente";

        Fantasma pinky = new Fantasma();
        pinky.Nick = "Pinky";
        pinky.Cor = "Rosa";
        pinky.Habilidade = "Prepara emboscadas";

        blinky.GerarFantasma();
        pinky.GerarFantasma();

        blinky.Mover("cima");
        pinky.Mover("esquerda");
    }
}
