namespace ContaBanco;

public class ContaComercial : Conta
{
    public double LimiteEmprestimo { get; set; }
    public double Emprestimo(double valorEmprestimo)
    {

        return LimiteEmprestimo <= valorEmprestimo ? Saldo += valorEmprestimo : Saldo;

    }
}