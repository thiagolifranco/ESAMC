using System.Globalization;

class Veiculo
{
    public string Placa { get; private set; }
    public string Modelo { get; private set; }
    public TimeSpan HoraEntrada { get; private set; }
    public TimeSpan? HoraSaida { get; private set; }
    public decimal? ValorPago { get; private set; }

    public Veiculo(string placa, string modelo, TimeSpan horaEntrada)
    {
        if (placa == "")
            throw new Exception("A placa não pode ficar vazia.");

        if (modelo == "")
            throw new Exception("O modelo não pode ficar vazio.");

        Placa = placa.ToUpper();
        Modelo = modelo;
        HoraEntrada = horaEntrada;
    }

    public void RegistrarSaida(TimeSpan horaSaida)
    {
        if (horaSaida < HoraEntrada)
            throw new Exception("A saída não pode ser antes da entrada.");

        HoraSaida = horaSaida;

        TimeSpan permanencia = horaSaida - HoraEntrada;
        int horasCobradas = (int)Math.Ceiling(permanencia.TotalHours);

        if (horasCobradas < 1)
            horasCobradas = 1;

        ValorPago = horasCobradas * 10;
    }

    public void MostrarDados()
    {
        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Entrada: " + HoraEntrada.ToString(@"hh\:mm"));

        if (HoraSaida == null)
        {
            Console.WriteLine("Saída: Ainda está estacionado");
        }
        else
        {
            Console.WriteLine("Saída: " + HoraSaida.Value.ToString(@"hh\:mm"));

            TimeSpan permanencia = HoraSaida.Value - HoraEntrada;
            Console.WriteLine("Tempo: " + permanencia.Hours + " hora(s) e " + permanencia.Minutes + " minuto(s)");
            Console.WriteLine("Valor pago: " + ValorPago.Value.ToString("C2", CultureInfo.GetCultureInfo("pt-BR")));
        }
    }
}

class Estacionamento
{
    private List<Veiculo> veiculos = new List<Veiculo>();
    private List<Veiculo> historico = new List<Veiculo>();

    public void Entrada(Veiculo veiculo)
    {
        for (int i = 0; i < veiculos.Count; i++)
        {
            if (veiculos[i].Placa == veiculo.Placa)
                throw new Exception("Este veículo já está estacionado.");
        }

        veiculos.Add(veiculo);
    }

    public Veiculo ProcurarVeiculo(string placa)
    {
        for (int i = 0; i < veiculos.Count; i++)
        {
            if (veiculos[i].Placa == placa.ToUpper())
                return veiculos[i];
        }

        throw new Exception("Veículo não encontrado.");
    }

    public void Saida(string placa, TimeSpan horaSaida)
    {
        Veiculo veiculo = ProcurarVeiculo(placa);
        veiculo.RegistrarSaida(horaSaida);
        veiculos.Remove(veiculo);
        historico.Add(veiculo);
    }

    public void MostrarEstacionados()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Não há veículos estacionados.");
            return;
        }

        for (int i = 0; i < veiculos.Count; i++)
            veiculos[i].MostrarDados();
    }

    public void MostrarHistorico(string placa)
    {
        for (int i = 0; i < historico.Count; i++)
        {
            if (historico[i].Placa == placa.ToUpper())
            {
                historico[i].MostrarDados();
                return;
            }
        }

        Console.WriteLine("Veículo não encontrado no histórico.");
    }

}

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine();
            Console.WriteLine("ESTACIONAMENTO");
            Console.WriteLine("1 - Registrar entrada");
            Console.WriteLine("2 - Registrar saída");
            Console.WriteLine("3 - Ver veículos estacionados");
            Console.WriteLine("4 - Consultar veículo que saiu");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite uma opção: ");

            int.TryParse(Console.ReadLine(), out opcao);

            try
            {
                if (opcao == 1)
                    RegistrarEntrada(estacionamento);
                else if (opcao == 2)
                    RegistrarSaida(estacionamento);
                else if (opcao == 3)
                    estacionamento.MostrarEstacionados();
                else if (opcao == 4)
                    fAZER
                else if (opcao != 0)
                    Console.WriteLine("Opção inválida.");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
        }
    }

    static void RegistrarEntrada(Estacionamento estacionamento)
    {
        Console.Write("Digite a placa: ");
        string placa = Console.ReadLine() ?? "";

        Console.Write("Digite o modelo: ");
        string modelo = Console.ReadLine() ?? "";

        Veiculo veiculo = new Veiculo(placa, modelo);
        estacionamento.Entrada(veiculo);
        Console.WriteLine("Entrada registrada com sucesso.");
    }

}
