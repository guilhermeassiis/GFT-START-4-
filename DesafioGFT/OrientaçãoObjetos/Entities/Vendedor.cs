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
    public override string Bonificacao()
    {
        return "Sua bonificação é de: " + (Salario + (300.00 * grauInstrucao * 4)).ToString("F2", CultureInfo.InvariantCulture);
    }
}
