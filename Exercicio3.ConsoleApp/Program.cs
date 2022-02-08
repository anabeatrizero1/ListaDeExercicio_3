using System;
/*
 * • Desenvolver um algoritmo que efetue a soma de todos os números
ímpares que são múltiplos de três e que se encontram no conjunto dos
números de 1 até 500
 */
namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            //soma dos impares muliplos de 3 
            for (int i = 0; i < 500; i++)
            {
                if(i % 3 == 0)
                {
                    if(i%2 == 1)
                    {
                        soma += i;

                    }
                }
            }
            Console.WriteLine("A soma dos números impares que são multipos de 3 (1 à 500) é " + soma);
            Console.ReadKey();

        }
    }
}
