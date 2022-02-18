using System;

namespace Desafio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nComandos;
            String comandos;
            
            do
            {
                do
                {
                    Console.Write("Digite o numero de comandos do sargento: ");
                    nComandos = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite os comandos: ");
                    comandos = Convert.ToString(Console.ReadLine());

                    char[] comandosSargento = comandos.ToCharArray();
                } while (comandos.Length != nComandos);

                char posicao = 'N';

                for (int i = 0; i < comandos.Length; i++)
                {
                    while (comandos[i] == 'E' || comandos[i] == 'e')
                    {
                        switch (posicao)
                        {
                            case 'N':
                                posicao = 'O';
                                break;
                            case 'S':
                                posicao = 'L';
                                break;
                            case 'L':
                                posicao = 'N';
                                break;
                            case 'O':
                                posicao = 'S';
                                break;
                        }
                        break;
                    }
                        while (comandos[i] == 'D' || comandos[i] == 'd')
                        {
                            switch (posicao)
                            {
                                case 'N':
                                    posicao = 'L';
                                    break;
                                case 'S':
                                    posicao = '0';
                                    break;
                                case 'L':
                                    posicao = 'S';
                                    break;
                                case 'O':
                                    posicao = 'N';
                                    break;
                            }
                            break;
                        }
                    }

                Console.WriteLine(posicao);
            } while (nComandos != 0);
        }
    }
}