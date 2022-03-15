namespace ImcDesafio4;

public class Program
{
    // DESAFIO 4
    static void Main(string[] args)
    {
        Console.Write("Digite Seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digitie sua altura: ");
        double altura = double.Parse(Console.ReadLine());
        
        CalculadoraIMC calcImc = new(nome, peso, altura);

        Console.WriteLine();
        Console.WriteLine(calcImc);
    }
}