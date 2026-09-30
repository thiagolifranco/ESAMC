using System;

class Veiculo
{
    public string Marca;
    public string Modelo;
    public int NumeroDeRodas;

    public void ExibirDados()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Número de rodas: " + NumeroDeRodas);
    }
}

class Carro : Veiculo
{
    public int NumeroDePortas;
}

class Moto : Veiculo
{
    public bool PossuiBagageiro;
}

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();

        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.NumeroDeRodas = 4;
        carro.NumeroDePortas = 4;

        Console.WriteLine("CARRO");
        carro.ExibirDados();
        Console.WriteLine("Número de portas: " + carro.NumeroDePortas);

        Console.WriteLine();

        Moto moto = new Moto();

        moto.Marca = "Honda";
        moto.Modelo = "CG 160";
        moto.NumeroDeRodas = 2;
        moto.PossuiBagageiro = true;

        Console.WriteLine("MOTO");
        moto.ExibirDados();
        Console.WriteLine("Possui bagageiro: " + moto.PossuiBagageiro);
    }
}