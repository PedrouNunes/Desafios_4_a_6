using System;

namespace Desafio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Digite a quantidade de valores lidos: ");
            x = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[x];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite o valor da posição lidos: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
                    
        }
    }
}
