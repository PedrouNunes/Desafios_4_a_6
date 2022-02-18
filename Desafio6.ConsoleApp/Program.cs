using System;

namespace Desafio6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testes, homens, salto, contSalto = 0;

            Console.WriteLine("Digite a quantidade de testes: ");
            testes = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= testes; i++)
            {
                Console.WriteLine("Digite o numero de homens: ");
                homens = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o numero de saltos: ");
                salto = Convert.ToInt32(Console.ReadLine());

                for(int j = 0; j < homens; j++)
                {
                    contSalto = contSalto + salto;
                if(contSalto > homens)
                    {
                        contSalto = -1;
                    }
                }
                Console.WriteLine("Caso " + i + ": " + contSalto);
            }
        }
    }
}
