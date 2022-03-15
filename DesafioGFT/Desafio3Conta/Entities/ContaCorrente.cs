using Desafio3Conta.Entities.Abstracts;
using System.Globalization;

namespace Desafio3Conta.Entities;
public class ContaCorrente : Conta
{
    // Construtor
    public ContaCorrente(long numero, string? titular, double saldo) : base(numero, titular, saldo)
    {
        this.Saldo = saldo - 0.75;
    }

    // Overrides
    public override double Rendimentos()
    {
        return (Saldo - 0.75) * 0.05; 
    }

    public override string ToString()
    {
        return "Numero da Conta: " + Numero + "\n" +
               "Nome do titular: " + Titular + "\n" +
               "Saldo Atual: " + Saldo + "\n" +
               "Rendimentos: " + this.Rendimentos().ToString("F2", CultureInfo.InvariantCulture);
    }
}
