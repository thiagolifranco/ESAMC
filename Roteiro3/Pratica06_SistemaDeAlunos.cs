// ============================================================
// Programação Orientada a Objetos I - ESAMC
// Roteiro 03 | Prática 6 — Sistema de alunos
// ============================================================
//
// ENUNCIADO
// Classe Aluno com Nome, Nota1, Nota2 e Media. Nome não pode ser vazio; notas entre 0 e
// 10 e alteráveis; média calculada automaticamente e não alterável. Esperado: 8 e 6 → 7.
// Depois Nota2 = 10 → 9.
//
// SAÍDA ESPERADA
//   7
//   9
//   Erro: A nota deve estar entre 0 e 10.
// ============================================================

using System;

class Aluno
{
    private string nome;
    private double nota1;
    private double nota2;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nome não pode ser vazio.");
            nome = value;
        }
    }

    public double Nota1
    {
        get { return nota1; }
        set
        {
            if (value < 0 || value > 10)
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            nota1 = value;
        }
    }

    public double Nota2
    {
        get { return nota2; }
        set
        {
            if (value < 0 || value > 10)
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            nota2 = value;
        }
    }

    // calculada: não tem set, não guarda valor
    public double Media
    {
        get { return (Nota1 + Nota2) / 2; }
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.Nome = "Maria";
        aluno.Nota1 = 8;
        aluno.Nota2 = 6;
        Console.WriteLine(aluno.Media);

        aluno.Nota2 = 10;
        Console.WriteLine(aluno.Media);

        try
        {
            aluno.Nota1 = 11;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
