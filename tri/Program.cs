using System;

namespace tri
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] tabA = { -2,0, 10, 1, 25, 62, 3 };


            TriBulle(tabA);
            TriSelec(tabA);
            





        }

        private static void TriBulle(int[] tabA)
        {
            int nb = tabA.Length;
            int temp = 0;
            bool perm = true;
            while (perm)
            {
                perm = false;
                for (int i = 0; i < nb - 1; i++)
                {
                    if (tabA[i] > tabA[i + 1])
                    {
                        perm = true;
                        temp = tabA[i + 1];
                        tabA[i + 1] = tabA[i];
                        tabA[i] = temp;
                    }
                }
            }
            Console.WriteLine("Tri Bulle :");
            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine($"{tabA[i]}");
            }
        }
        private static void TriSelec(int[] tabA)
        {
            int nb = tabA.Length;
            for (int i = 0; i < nb-1; i++)
            {
                int mini = tabA[i];
                int posmini = i;
                for (int j = i+1; j < nb; j++)
                {
                    if (mini>tabA[j])
                    {
                        mini = tabA[j];
                        posmini = j;
                    }
                }
                mini = tabA[i];
                tabA[i] = tabA[posmini];
                tabA[posmini] = mini;
            }
            Console.WriteLine("Tri sélectif :");
            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine($"{tabA[i]}");
            }
        }
    }
}
