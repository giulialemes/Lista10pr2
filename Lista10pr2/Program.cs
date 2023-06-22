using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num;

            Console.WriteLine("Escolha um exercicio: ");

            Console.WriteLine("====MENU====");
            Console.WriteLine("1 exercicio ");
            Console.WriteLine("2 exercicio ");
            Console.WriteLine("3 exercicio ");
            Console.WriteLine("4 exercicio ");
            Console.WriteLine("5 exercicio ");
            Console.WriteLine("6 exercicio ");
            Console.WriteLine("7 exercicio ");
            Console.WriteLine("============");

            num = int.Parse(Console.ReadLine());



            case 1:

            int nummero, nummaior, nummenor, q;
            int[] vet;

            Console.WriteLine("digite a quantidade de variaveis:");
            q = int.Parse(Console.ReadLine());
            vet = new int[q];

            float soma = 0;

            Console.WriteLine("digite um numero");
            nummero = int.Parse(Console.ReadLine());
            vet[0] = nummero;
            nummaior = nummero;
            nummenor = nummero;

            for (int i = 1; i < q; i++)
            {
                Console.WriteLine("digite um numero");
                vet[i] = int.Parse(Console.ReadLine());


                if (vet[i] < nummenor)
                {
                    nummenor = vet[i];
                }
                if (vet[i] > nummaior)
                {
                    nummaior = vet[i];
                }
            }
            for (int i = 0; i < q; i++)
            {
                soma += vet[i];
            }
            Console.WriteLine("O menor numero é: " + nummenor + " e o maior é: " + nummaior + " media aritmetrica: " + soma/ q );
            break;

            case 2:

                int j, some = 0, media = 0;
                 int[] vete;

            do
            {
                Console.WriteLine("digite a quantidade de numeros (numero maior que 0)");
                j = int.Parse(Console.ReadLine());
                vete = new int[j];

            } while (j <= 0);

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("digite um numero");
                vet[i] = int.Parse(Console.ReadLine());
                soma = soma + vet[i];
            }
            media = some / j;

            for (int i = 0; i < j; i++)
            {
                if (vete[i] >= media)
                {
                    Console.WriteLine("os numeros maiores que a média é: " + vet[i]);
                }
                break;
               
                case 3:

                    nt t, soma = 0, media = 0;
                int[] vet;

                Random rand = new Random();

                do
                {
                    Console.WriteLine("digite a quantidade de numeros (numero maior que 0)");
                    t = int.Parse(Console.ReadLine());
                    vet = new int[t];

                } while (t <= 0);

                for (int i = 0; i < t; i++)
                {
                    vet[i] = rand.Next(1, 100);
                    soma = soma + vet[i];
                }
                media = soma / t;

                for (int i = 0; i < t; i++)
                {
                    if (vet[i] >= media)
                    {
                        Console.WriteLine("os numeros maiores que a média é: " + vet[i]);
                    }

                }
            }
            case 4:
            {
                string[] vet1;

                Console.WriteLine("digite a quantidade de nomes:");
                int qq = int.Parse(Console.ReadLine());
                vet1 = new string[qq];

                for (int i = 0; i < qq; i++)
                {
                    Console.WriteLine("digite os nomes:");
                    vet1[i] = Console.ReadLine();

                }

                Console.WriteLine("\n");

                for (int i = qq - 1; i >= 0; i--)
                {
                    Console.WriteLine("posicão[{0}] = {1}", i, vet1[i]);
                }
            }
            case 5:
            {
                int t, somex = 0, medie = 0, par = 0, imp = 0;
                int[] veto;

                Random rand = new Random();

                do
                {
                    Console.WriteLine("digite a quantidade de numeros: (maior que zero");
                    veto = new int[t];

                } while (t <= 0);

                for (int i = 0; i < t; i++)
                {
                    veto[i] = rand.Next(1, 100);
                    if (veto[i] % 2 == 0)
                    {
                        par += 1;
                    }
                    else
                    {
                        imp += 1;
                    }
                }
                Console.WriteLine("A quantidade de numeros pares é: " + par + " e a quantidade de numeros impares é: " + imp);
            }
            break;

           case6: 
                int opcao;

                do
                {
                    Console.WriteLine("=================MENU=================");
                    Console.WriteLine("para rodar o exercício 1 - digite 1");
                    Console.WriteLine("para rodar o exercício 2 - digite 2");
                    Console.WriteLine("para rodar o exercício 3 - digite 3");
                    Console.WriteLine("para rodar o exercício 4 - digite 4");
                    Console.WriteLine("para rodar o exercício 5 - digite 5");
                    Console.WriteLine("para sair do programa - digite 10");

                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("obrigada por usar meu programa;)!");

                            break;

                        case 1:
                            Exercicio1();

                            break;

                        case 2:
                            Exercicio2();

                            break;

                        case 3:
                            Exercicio3();

                            break;

                        case 4:
                            Exercicio4();

                            break;

                        case 5:
                            Exercicio5();

                            break;

                        default:
                            Console.WriteLine("opção erradex!");

                            break;
                    }
                } while (opcao != 0);
            }
        }
    }



