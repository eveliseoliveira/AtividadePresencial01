using System;

namespace Atividade05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] jogadas_primeiro_jogador = new int[4];

            int[] jogadas_segundo_jogador = new int[4];

            int primeiro_vencedor = 0, segundo_vencedor = 0;

            Console.WriteLine("----- O JOGO -----\n");

            Console.WriteLine("REGRAS DE O JOGO\nO jogo terá 3 rodadas" +
                "\nO jogador que tirar o maior número nessas 3 rodadas vence" +
                "\nOs números permitidos vão de 0 a 6 ");

            Console.WriteLine("\nPrimeiro jogador informe seu nome:");
            string primeiro_jogador = Console.ReadLine();

            Console.WriteLine("\nSegundo jogador informe seu nome:");
            string segundo_jogador = Console.ReadLine();

            for (int i = 1; i < jogadas_primeiro_jogador.Length; i++)
            {
                    Console.WriteLine("\n" + i + "a rodada\n");

                    Console.Write(primeiro_jogador + ":");
                    jogadas_primeiro_jogador[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write(segundo_jogador + ":");
                    jogadas_segundo_jogador[i] = Convert.ToInt32(Console.ReadLine());

                    if (jogadas_primeiro_jogador[i] > 6 || jogadas_segundo_jogador[i] > 6)
                    {
                        Console.WriteLine("Jogada inválida! Reinicie o jogo!");
                        break;
                    }
                    if (jogadas_primeiro_jogador[i] > jogadas_segundo_jogador[i])
                    {
                        Console.WriteLine("\nO jogador " + primeiro_jogador + " jogou "
                            + jogadas_primeiro_jogador[i] + " e venceu a " + i + "a rodada");
                    }
                    else if (jogadas_segundo_jogador[i] > jogadas_primeiro_jogador[i])
                    {
                        Console.WriteLine("\nO jogador " + segundo_jogador + " jogou "
                            + jogadas_segundo_jogador[i] + " e venceu a " + i + "a rodada");
                    }
                    else if (jogadas_primeiro_jogador[i] == jogadas_segundo_jogador[i])
                    {
                        Console.WriteLine("\nHouve um empate definitivo, tente novamente!");

                    }
                    primeiro_vencedor = jogadas_primeiro_jogador[i] + jogadas_primeiro_jogador[i];
                    segundo_vencedor = jogadas_segundo_jogador[i] + jogadas_segundo_jogador[i];
            }
                    if(primeiro_vencedor > segundo_vencedor)
                      Console.WriteLine("\nParabéns " + primeiro_jogador + ", você ganhou o jogo!");
                        else if(segundo_vencedor > primeiro_vencedor)
                            Console.WriteLine("\nParabéns " + segundo_jogador + ", você ganhou o jogo!");

                Console.ReadLine();
            }
        }
    }

