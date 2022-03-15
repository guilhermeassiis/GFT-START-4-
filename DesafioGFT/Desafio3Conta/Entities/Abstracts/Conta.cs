namespace Desafio3Conta.Entities.Abstracts;
public abstract class Conta
{
    // Atributos
    public long Numero { get; private set; } // Impossibilitando ser alterado os atributos de conta
    public string? Titular { get; private protected set; } // Modificador de acesso para mudar logica em classes filhas
    public double Saldo { get; protected set; }

    // Construtor
    public Conta(long numero, string? titular, double saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }
    
    // Rendimentos
    public virtual double Rendimentos()
    {
        return Saldo;
    }
}
