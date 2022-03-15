using OrientacaoObjetos;
using System.Globalization;

namespace OrientaçãoObjetos.Entities;

public class Gerente : Colaborador
{
    // Construtor 
    public Gerente(string? nome, int idade, double salario, int grauInstrucao) : base(nome, idade, salario, grauInstrucao)
    {
    }

    // Metodo Bonificacao 
    public override double Bonificacao()
    {  
        return (Salario + (1000.00 * grauInstrucao * 2));
    }

    public override string ToString()
    {
        return "Nome: " + Nome + "\n" +
               "Idade: " + Idade + "\n" +
               "Salario: " + Salario + "\n" +
               "Bonificação: " + this.Bonificacao().ToString("F2", CultureInfo.InvariantCulture); ;
    }
}
