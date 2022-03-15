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
    public override string Bonificacao()
    {
        return "Sua bonificação é de: " + (Salario + (500.00 * grauInstrucao * 3)).ToString("F2", CultureInfo.InvariantCulture);
    }
}