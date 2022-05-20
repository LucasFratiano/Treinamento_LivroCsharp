using System;

namespace ContaBanco;

public class Conta
{
    public Guid NumeroConta { get; set; }
    public string? Titular { get; set; }
    public double Saldo { get; set; }

    public double Saque(double valorSaque)
    {
        // qtde
        return Saldo = Saldo - valorSaque;

    }
    public double Deposito(double valorDeposito)
    {
        // qtde

        return Saldo = Saldo + valorDeposito;

    }
}
