using OrientacaoObjetos;
using System.Globalization;

namespace OrientaçãoObjetos.Entities;
public class Vendedor : Colaborador
{
    // Construtor
    public Vendedor(string? nome, int idade, double salario, int grauInstrucao) : base(nome, idade, salario, grauInstrucao)
    {
    }
    // Metodo Bonificacao
    public override double Bonificacao()
    {
        return (Salario + (300.00 * grauInstrucao * 4));
    }
    public override string ToString()
    {
        return "Nome: " + Nome + "\n" +
               "Idade: " + Idade + "\n" +
               "Salario: " + Salario + "\n" +
               "Bonificação: " + this.Bonificacao().ToString("F2", CultureInfo.InvariantCulture); ;
    }
}
