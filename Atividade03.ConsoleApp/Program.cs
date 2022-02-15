using System;

namespace Atividade03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora_atual = 0;

            Console.WriteLine("Que horas são:");
            hora_atual = int.Parse(Console.ReadLine());

            if (hora_atual >= 0 && hora_atual <= 12)
                Console.WriteLine("Bom dia");
                else if (hora_atual >= 12 && hora_atual <= 18)
                    Console.WriteLine("Boa tarde");
                else if(hora_atual >= 18 && hora_atual <= 24)
                    Console.WriteLine("Boa noite");

            Console.ReadLine();
        }
    }
}
