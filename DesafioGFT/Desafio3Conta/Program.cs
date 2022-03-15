using Desafio3Conta.Entities;

namespace Desafio3Conta;

public class Program
{
    // DESAFIO 3
    static void Main(string[] args)
    {
        ContaCorrente cc = new(12558, "Ubiratan Roberte", 25000.00);
        ContaPoupanca cp = new(16589, "Clecio Gomes", 18000.00);

        Console.WriteLine(cc);
        Console.WriteLine();
        Console.WriteLine(cp);
    }
}