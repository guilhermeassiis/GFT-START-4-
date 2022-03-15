namespace DesafioGFT;

public class Program
{
    static void Main(string[] args)
    {
        // DESAFIO 2
        int totalImpar = 0;
        while (true)
        {
            // Limpando o Console a cada rodada do looping
            Console.Clear();
            Console.Write("Digite um numero inteiro de no minimo 3 digitos e que esteja entre 350 e 8750: ");
            int num = int.Parse(Console.ReadLine());

            // Transformando o numero em uma string para ser mais facil de iterar
            string? NumInteravel = num.ToString();
            // Verificando o tamanho do numero
            if (NumInteravel.Length <= 2)
            {
                Console.WriteLine("O numero deve conter no minimo 3 digitos");
                Console.ReadKey();
            }
            else
            {
                // Verificando se o numero atende os requisitos
                if (num > 350 && num < 8750)
                {
                    for (int i = 0; i < NumInteravel.Length; i++)
                    {
                        // Verificando se o numero é impar
                        if ((int)NumInteravel[i] % 2 == 1)
                        {
                            totalImpar++;
                        }
                    }
                    // Interação
                    if (totalImpar > 1) Console.WriteLine($"O seu numero possui {totalImpar} unidades de numeros impares!");
                    else Console.WriteLine($"O seu numero possui {totalImpar} numero impar!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("O numero deve estar entre 350 e 8750!");
                    Console.ReadKey();
                }

            }
        }

    }

}
