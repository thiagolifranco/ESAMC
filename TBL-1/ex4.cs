using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Número: " + numero);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }
}