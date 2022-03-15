using Desafio3Conta.Entities.Abstracts;
using System.Globalization;

namespace Desafio3Conta.Entities;
public class ContaPoupanca : Conta
{  
    // Construtor
    public ContaPoupanca(long numero, string? titular, double saldo) : base(numero, titular, saldo)
    {
    }

    //Overrides
    public override double Rendimentos()
    {
        return (Saldo * 0.07);
    }

    public override string ToString()
    {
        return "Numero da Conta: " + Numero + "\n" +
               "Nome do titular: " + Titular + "\n" +
               "Saldo Atual: " + Saldo + "\n" +
               "Rendimentos: " + this.Rendimentos().ToString("F2", CultureInfo.InvariantCulture);
    }
}
