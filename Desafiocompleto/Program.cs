using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace EstacionamentoPOO
{
    class Veiculo
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public TimeSpan? HoraEntrada { get; private set; }
        public TimeSpan? HoraSaida { get; private set; }
        public double ValorPago { get; private set; }

        public Veiculo(string placa, string modelo)
        {
            if (string.IsNullOrWhiteSpace(placa))
                throw new Exception("Placa não pode ser vazia");

            Placa = placa;
            Modelo = modelo;
        }

        public void RegistrarEntrada(string hora)
        {
            if (HoraEntrada != null)
                throw new Exception("Veículo já possui entrada registrada");

            HoraEntrada = TimeSpan.ParseExact(hora, @"hh\:mm", CultureInfo.InvariantCulture);
        }

        public void RegistrarSaida(string hora)
        {
            if (HoraEntrada == null)
                throw new Exception("Veículo ainda não entrou");

            if (HoraSaida != null)
                throw new Exception("Saída já registrada");

            HoraSaida = TimeSpan.ParseExact(hora, @"hh\:mm", CultureInfo.InvariantCulture);

            if (HoraSaida < HoraEntrada)
                throw new Exception("Saída não pode ser antes da entrada");

            CalcularValor();
        }

        private void CalcularValor()
        {
            double horas = (HoraSaida.Value - HoraEntrada.Value).TotalHours;

            if (horas < 1)
                horas = 1;

            horas = Math.Ceiling(horas);

            ValorPago = horas * 10;
        }

        public string ExibirDados()
        {
            return $"Placa: {Placa} | Modelo: {Modelo} | " +
                   $"Entrada: {HoraEntrada} | Saída: {HoraSaida} | Valor: R$ {ValorPago}";
        }
    }

    class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();

        public void EntradaVeiculo(string placa, string modelo, string hora)
        {
            if (veiculos.Any(v => v.Placa == placa && v.HoraSaida == null))
                throw new Exception("Veículo já está no estacionamento");

            Veiculo v = new Veiculo(placa, modelo);
            v.RegistrarEntrada(hora);

            veiculos.Add(v);
        }

        public void SaidaVeiculo(string placa, string hora)
        {
            Veiculo v = veiculos.FirstOrDefault(v => v.Placa == placa && v.HoraSaida == null);

            if (v == null)
                throw new Exception("Veículo não encontrado ou já saiu");

            v.RegistrarSaida(hora);

            Console.WriteLine(v.ExibirDados());
        }

        public void ListarVeiculos()
        {
            foreach (var v in veiculos)
            {
                Console.WriteLine(v.ExibirDados());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento est = new Estacionamento();

            while (true)
            {
                Console.WriteLine("\n1 - Entrada");
                Console.WriteLine("2 - Saída");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Placa: ");
                            string placa = Console.ReadLine();

                            Console.Write("Modelo: ");
                            string modelo = Console.ReadLine();

                            Console.Write("Hora entrada (HH:mm): ");
                            string horaEntrada = Console.ReadLine();

                            est.EntradaVeiculo(placa, modelo, horaEntrada);
                            Console.WriteLine("Entrada registrada!");
                            break;

                        case "2":
                            Console.Write("Placa: ");
                            placa = Console.ReadLine();

                            Console.Write("Hora saída (HH:mm): ");
                            string horaSaida = Console.ReadLine();

                            est.SaidaVeiculo(placa, horaSaida);
                            break;

                        case "3":
                            est.ListarVeiculos();
                            break;

                        case "0":
                            return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
    }
}