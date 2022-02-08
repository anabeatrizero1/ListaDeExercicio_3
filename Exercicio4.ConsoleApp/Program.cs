using System;
/*
 Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
calcule a tabuada de N.
• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
10N
 */

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, resultado;
            string opcao;
            do
            {
                Console.WriteLine("Digite qual tabuada deseja ler: (1-10) ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 10; i++)
                {
                    resultado = n * i;
                    Console.WriteLine("{0} * {1} = {2}", n, i, resultado);

                }

                Console.WriteLine("Deseja continuar? Digite 's' para sim e 'n' para não!");
                opcao = Console.ReadLine();

                if (opcao == "n")
                    break;

                else if (opcao == "s")
                {
                    Console.Clear();
                    continue;
                }
              

            } while (true);

            Console.ReadKey();
        }
    }
}
