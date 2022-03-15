using OrientacaoObjetos;
using System.Globalization;

namespace OrientaçãoObjetos.Entities;

public class Supervisor : Colaborador
{
    // Construtor
    public Supervisor(string? nome, int idade, double salario, int grauInstrucao) : base(nome, idade, salario, grauInstrucao)
    {
    }
    // Metodo Bonificação
    public override double Bonificacao()
    {
        return (Salario + (500.00 * grauInstrucao * 3));
    }
    public override string ToString()
    {
        return "Nome: " + Nome + "\n" +
               "Idade: " + Idade + "\n" +
               "Salario: " + Salario + "\n" +
               "Bonificação: " + this.Bonificacao().ToString("F2", CultureInfo.InvariantCulture); ;
    }
}