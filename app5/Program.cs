using System;
using System.Collections.Generic;

class Conta
{
    private string numeroConta;
    protected double saldo;

    public Conta(string numeroConta)
    {
        this.numeroConta = numeroConta;
        this.saldo = 0;
    }

    public string NumeroConta
    {
        get { return numeroConta; }
    }

    public double Saldo
    {
        get { return saldo; }
        protected set { saldo = value; }
    }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }
    }

    protected void SetSaldo(double novoSaldo)
    {
        saldo = novoSaldo;
    }
}

class ContaEspecial : Conta
{
    private double limite;

    public ContaEspecial(string numeroConta, double limite) : base(numeroConta)
    {
        this.limite = limite;
    }

    public override void Sacar(double valor)
    {
        double saldoTotal = Saldo + limite;

        if (valor <= saldoTotal)
        {
            saldoTotal -= valor;
            if (saldoTotal >= 0)
            {
                SetSaldo(saldoTotal);
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite excedido.");
            }
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }
    }
}

class ContaPoupanca : Conta
{
    private double taxaJuros;

    public ContaPoupanca(string numeroConta, double taxaJuros) : base(numeroConta)
    {
        this.taxaJuros = taxaJuros;
    }


    public void AplicarJuros()
    {
        double juros = Saldo * taxaJuros;
        Depositar(juros);
        Console.WriteLine("Juros aplicados: " + juros);
    }
}

class Banco
{
    private List<Conta> contas;

    public Banco()
    {
        contas = new List<Conta>();
    }

    public void CadastrarConta(Conta conta)
    {
        contas.Add(conta);
    }

    public Conta ConsultarConta(string numeroConta)
    {
        foreach (Conta conta in contas)
        {
            if (conta.NumeroConta == numeroConta)
            {
                return conta;
            }
        }

        throw new InvalidOperationException("Conta não encontrada.");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco();

        ContaEspecial contaEspecial = new ContaEspecial("12345", 1000);
        banco.CadastrarConta(contaEspecial);

        ContaPoupanca contaPoupanca = new ContaPoupanca("54321", 0.05);
        banco.CadastrarConta(contaPoupanca);

        string numeroConta = "12345";
        Conta contaConsultada = banco.ConsultarConta(numeroConta);
        if (contaConsultada != null)
        {
            Console.WriteLine("Conta encontrada: " + contaConsultada.NumeroConta);
        }

        contaConsultada.Depositar(500);
        contaConsultada.Sacar(200);

        string numeroConta2 = "54321";
        Conta conta2 = banco.ConsultarConta(numeroConta2);
        if (conta2 != null)
        {
            Console.WriteLine("Conta encontrada: " + conta2.NumeroConta);
            conta2.Depositar(1000);
        }

    }
}