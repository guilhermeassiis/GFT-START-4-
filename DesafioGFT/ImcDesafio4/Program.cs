namespace ImcDesafio4;

public class Program
{
    // DESAFIO 4
    static void Main(string[] args)
    {
        CalculadoraIMC calcImc = new("Guilherme", 80.0, 1.60);

        Console.WriteLine(calcImc);
    }
}