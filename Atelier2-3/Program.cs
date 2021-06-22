using System;

namespace Atelier2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Exo4();
            static void Exo1()
            {
                int a;
                string acqui = "";
                do
                {
                    Console.WriteLine("Saisissez un nombre entier :");
                    acqui = Console.ReadLine();
                    int.TryParse(acqui, out a);
                } while (int.TryParse(acqui, out a) == false);
                short b = (short)++a;
                long c = a++;
                Console.WriteLine($"a={a}");
                Console.WriteLine($"b={b}");
                Console.WriteLine($"c={c}");
            }
            static void Exo2()
            {
                int a;
                int b;
                a = 5;
                b = a;
                b += 5;
                Console.WriteLine($"a={a}");
                Console.WriteLine($"b={b}");
                int[] tabA, tabB;
                tabA = new int[3] { 2, 5, 4 };
                tabB = tabA;
                tabB[0] = 9;
                Console.WriteLine($"tabA={tabA[0]},{tabA[1]},{tabA[2]}");
                Console.WriteLine($"tabB={tabB[0]},{tabB[1]},{tabB[2]}");

            }
            static void Exo3()
            {
                static void argumentValeur() 
                {
                    int s = 3;
                    Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
                    modifierValeur(s);
                    Console.WriteLine("Valeur après appel méthode modification valeur {0}", s);
                }
                static void modifierValeur(int o)
                {
                    o = 4;
                }
                argumentValeur();
            }
            static void Exo4()
            {
               
                static void argumentValeur()
                {
                    int s = 3;
                    Console.WriteLine("Valeur avant appel méthode modification valeur {0}", s);
                    modifierValeur(ref s);
                    Console.WriteLine("Valeur après appel méthode modification valeur {0}", s);
                }
                static void modifierValeur(ref int o)
                {
                    o = 4;
                }
                argumentValeur();
            }

        }
    }
}
