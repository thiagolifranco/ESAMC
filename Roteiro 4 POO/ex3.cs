using System;

interface IVeiculo
{
    void Mover();
}

class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O carro está se movendo");
    }
}

class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A bicicleta está se movendo");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        Bicicleta bicicleta = new Bicicleta();

        carro.Mover();
        bicicleta.Mover();
    }
}

