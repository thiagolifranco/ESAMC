using System;

interface IVoar
{
    void Voar();
}

interface INadar
{
    void Nadar();
}

class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato está voando.");
    }

    public void Nadar()
    {
        Console.WriteLine("O pato está nadando.");
    }
}

class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A águia está voando.");
    }
}

class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe está nadando.");
    }
}

class Program
{
    static void Main()
    {
        Pato pato = new Pato();

        pato.Voar();
        pato.Nadar();

        Aguia aguia = new Aguia();

        aguia.Voar();

        Peixe peixe = new Peixe();

        peixe.Nadar();
    }
}
