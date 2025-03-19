using System;
using System.Collections.Generic;

// Strategy Interface
public interface IContaPoupancaStrategy
{
    double CalcularJuros(double saldo);
}

// Concrete Strategies
public class ContaPoupancaClassica : IContaPoupancaStrategy
{
    public double CalcularJuros(double saldo) => saldo * 0.01;
}

public class ContaPoupancaInfantil : IContaPoupancaStrategy
{
    public double CalcularJuros(double saldo) => saldo * 0.03;
}

public class ContaPoupancaRendaFixa : IContaPoupancaStrategy
{
    public double CalcularJuros(double saldo) => saldo * 0.04;
}

// Context Class (ContaPoupanca)
public class ContaPoupanca
{
    public string Titular { get; private set; }
    private double _saldo;
    private int _estado;
    private int _tipo;
    private DateTime _dataCriacao;
    private IContaPoupancaStrategy _strategy;

    public ContaPoupanca(string titular, double saldo, int tipo, IContaPoupancaStrategy strategy)
    {
        Titular = titular;
        _saldo = saldo;
        _tipo = tipo;
        _dataCriacao = DateTime.Now;
        _strategy = strategy;
    }

    public void DefinirEstrategia(IContaPoupancaStrategy strategy)
    {
        _strategy = strategy;
    }

    public bool Depositar(double valor)
    {
        if (valor <= 0) return false;
        _saldo += valor;
        return true;
    }

    public bool Levantar(double valor)
    {
        if (valor > _saldo || valor <= 0) return false;
        _saldo -= valor;
        return true;
    }

    public void AplicarJuros()
    {
        double juros = _strategy.CalcularJuros(_saldo);
        _saldo += juros;
        Console.WriteLine($"Juros aplicados: {juros} euros, Novo saldo: {_saldo} euros");
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo atual de {Titular}: {_saldo} euros");
    }
}

// Teste da aplicação
class Program
{
    static void Main()
    {
        ContaPoupanca conta1 = new ContaPoupanca("Maria", 1000, 1, new ContaPoupancaClassica());
        ContaPoupanca conta2 = new ContaPoupanca("João", 2000, 2, new ContaPoupancaInfantil());
        ContaPoupanca conta3 = new ContaPoupanca("Ana", 3000, 3, new ContaPoupancaRendaFixa());

        conta1.AplicarJuros();
        conta2.AplicarJuros();
        conta3.AplicarJuros();
        Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        conta1.MostrarSaldo();
        conta2.MostrarSaldo();
        conta3.MostrarSaldo();

    }
}
