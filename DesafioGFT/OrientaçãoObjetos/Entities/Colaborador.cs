using System.Globalization;

namespace OrientacaoObjetos;
public abstract class Colaborador
{
    // Atributos
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public double Salario { get; set; }
    public int grauInstrucao { get; set; }

    // Construtor
    public Colaborador(string? nome, int idade, double salario, int grauInstrucao)
    {
        Nome = nome;
        Idade = idade;
        Salario = salario;
        this.grauInstrucao = grauInstrucao;
    }

    // Metodos
    public virtual string Bonificacao() // Adicionado virtual para usar metodos override em classes filhas
    {
        return "Sua bonificacao é de : " + Salario.ToString("F2", CultureInfo.InvariantCulture);
    }

}