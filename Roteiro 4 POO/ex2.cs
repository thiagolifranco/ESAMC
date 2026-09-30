using System;

namespace ExercicioComposicao
{
    
    class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

   
    class Casa
    {
        
        public Pessoa Morador { get; set; }

        public Casa(Pessoa morador)
        {
            Morador = morador;
        }

        
        public void ExibirMorador()
        {
            if (Morador != null)
            {
                Console.WriteLine($"O morador desta casa é: {Morador.Nome}");
            }
            else
            {
                Console.WriteLine("Esta casa está vazia.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa pessoa1 = new Pessoa("Thiago Franco");

           
            Casa minhaCasa = new Casa(pessoa1);

           
            minhaCasa.ExibirMorador();

            Console.ReadLine();
        }
    }
}
