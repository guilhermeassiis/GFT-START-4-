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
    public override string Bonificacao()
    {  
        return "Sua bonificação é de: " + (Salario + (1000.00 * grauInstrucao * 2)).ToString("F2", CultureInfo.InvariantCulture);
    }
}
