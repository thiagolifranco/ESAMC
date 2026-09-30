using System;
using System.Collections.Generic;

abstract class Funcionario
{
    public string Nome { get; set; }

    public abstract decimal CalcularSalario();
}

class Gerente : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 8000;
    }
}

class Programador : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 6000;
    }
}

class Program
{
    static void Main()
    {
        Funcionario gerente = new Gerente();
        Funcionario programador = new Programador();

        Console.WriteLine("Salário Gerente: " + gerente.CalcularSalario());
        Console.WriteLine("Salário Programador: " + programador.CalcularSalario());

        List<Funcionario> funcionarios = new List<Funcionario>();
        funcionarios.Add(new Gerente());
        funcionarios.Add(new Programador());

        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine(f.CalcularSalario());
        }
    }
}
