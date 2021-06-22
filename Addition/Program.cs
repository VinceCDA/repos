using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            // V1();
            V2();
        }
        static void V1()
        {
            string nombre1;
            string nombre2;
            int resultat;
            Console.WriteLine("Saisissez le 1er nombre");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Saisissez le 2eme nombre");
            nombre2 = Console.ReadLine();
            resultat = int.Parse(nombre1) + int.Parse(nombre2);
            Console.WriteLine($"Resultat {resultat}");
        }
        static void V2()
        {
            int nombre1;
            int nombre2;
            int resultat;
            nombre1 = Acqui();
            nombre2 = Acqui();
            resultat = Res(nombre1, nombre2);
            Console.WriteLine($"Resultat {resultat}");
            //  Console.WriteLine($"Resultat {Res(Acqui(), Acqui())}");


        }
        static int Acqui()
        {
            string nombre;
            int sortie;
            bool test;
            //Console.WriteLine("Saisissez un nombre entier");
            //nombre = Console.ReadLine();
            //bool test = int.TryParse(nombre, out sortie);
            do
            {
                Console.WriteLine("Saisissez un nombre entier");
                nombre = Console.ReadLine();
                test = int.TryParse(nombre, out sortie);

            } while (test == false);
            return sortie;
            //Console.WriteLine("Saisissez le 2eme nombre");
            //nombre2 = Console.ReadLine();
        }
        static int Res(int n1,int n2)
        {
            int resultat;
            resultat = n1 + n2;
            return resultat;

        }
    }
}
