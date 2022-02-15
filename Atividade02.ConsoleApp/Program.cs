using System;

namespace Atividade02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 50; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("A");
                    }
                        else
                        {
                            Console.Write("B");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
