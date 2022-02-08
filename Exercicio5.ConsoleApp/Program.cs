using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero que deseja fatorar: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;
            for (int i = a; i > 1; i--)
            {
                fatorial *= i;
            }
            Console.WriteLine("O resultado de {0}! é {1} ", a, fatorial);   
            Console.ReadKey();
        }
    }
}
