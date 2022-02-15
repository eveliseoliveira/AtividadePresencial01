using System;

namespace Atividade04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int media_valor = 0, valor_positivo = 0, valor_negativo = 0, soma = 0;

            int[] armazena_valor = new int[6];

            for(int i = 1; i < armazena_valor.Length; i++)
            {
                Console.WriteLine("Insira o " + i + "° valor:");
                armazena_valor[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1; i < armazena_valor.Length; i++)
            {
                soma += armazena_valor [i];
                media_valor = soma / 5;

                if (armazena_valor[i] > 0)
                {
                    valor_positivo++;
                }
                else if (armazena_valor[i] < 0)
                {
                    valor_negativo++;
                }
            }
            Console.WriteLine("A média aritimética é: " + media_valor + "\nAquantidade de valores positivos é: " 
                + valor_positivo + "\nAquantidade de valores negativos é: " + valor_negativo);

            Console.ReadLine();
        }
    }
}
