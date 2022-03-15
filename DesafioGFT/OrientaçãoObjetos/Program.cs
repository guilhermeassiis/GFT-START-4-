using OrientaçãoObjetos.Entities;

namespace OrientacaoObjetos;

public class Program
{
    // DESAFIO 1
    static void Main(string[] args)
    {
        // Instanciando objetos
        Gerente gerente = new Gerente("Clecio", 23, 6500.00, 5);
        Supervisor supervisor = new Supervisor("Ubiratan", 24, 5500.00, 4);
        Vendedor vendedor = new Vendedor("Guilherme", 22, 1600.00, 2);

        // Chamando o metodo Bonificacao
        Console.WriteLine(gerente.Bonificacao());
        Console.WriteLine(supervisor.Bonificacao());
        Console.WriteLine(vendedor.Bonificacao());
    }
}
