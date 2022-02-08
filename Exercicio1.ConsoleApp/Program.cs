using System;

/*
 • Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
programa deverá calcular e mostrar:
a. A menor altura do grupo;
b. A maior altura do grupo;
 
 
 */
namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double menorAltura;
            double maiorAltura;
            double[] alturas = new double[15];
            for (int i = 0; i < alturas.Length; i++)
            {
                Console.Write("Digite a altua da pessoa {0} : " , (i+1));
                alturas[i] = Convert.ToDouble(Console.ReadLine());
               
            }
            maiorAltura = alturas[0];
            menorAltura = alturas[0];

            for(int i = 0;i < alturas.Length; i++)
                if(alturas[i] > maiorAltura)
            {
                    maiorAltura = alturas[i];
            }else if(alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }

            Console.WriteLine("A menor altura é: " + menorAltura);
            Console.WriteLine("A maior altura é: " + maiorAltura);
            Console.ReadLine();
        }
    }
}
