using System;
using System.Collections.Generic;

class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico...");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento realizado com Cartão de Crédito");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento realizado com Boleto Bancário");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento realizado via Pix");
    }
}

class Program
{
    static void Main()
    {
        List<Pagamento> pagamentos = new List<Pagamento>();

        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());

        foreach (Pagamento p in pagamentos)
        {
            p.ProcessarPagamento();
        }
    }
}
