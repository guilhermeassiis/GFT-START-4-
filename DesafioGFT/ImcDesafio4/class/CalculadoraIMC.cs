
namespace ImcDesafio4;
public class CalculadoraIMC
{
    public string? Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }

    public CalculadoraIMC(string? nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }

    public string? IMC()
    {
        double imc = (Peso / (Altura * Altura));
        if (imc < 18.5) return "Abaixo do peso: " + imc.ToString("F2");
        else if (imc >= 18.5 && imc <= 24.9) return "Peso Normal: " + imc.ToString("F2");
        else if (imc >= 25.0 && imc <= 29.9) return "SobrePeso: " + imc.ToString("F2");
        else if (imc >= 30.0 && imc <= 34.9) return "Obesidade Grau I: " + imc.ToString("F2");
        else if (imc >= 35.0 && imc <= 34.9) return "Obesidade Grau I: " + imc.ToString("F2");
        else return "Obesidade Grau III: " + imc.ToString("F2");
    }
    public override string ToString()
    {
        return "Nome: " + Nome + "\n" +
               "IMC: " + this.IMC();
    }
}

