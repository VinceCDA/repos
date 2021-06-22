using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez un mot :");
            string mot = Console.ReadLine();
            int nblettre = mot.Length;
            //char x = mot[0];
            //char y = mot[nblettre-1];
            string mottraité = "";
            for (int a = 0; a < nblettre; a++)
            {
                if (mot[a] != ' ')
                {
                    mottraité = mottraité + mot[a];
                }
            }
            //Console.WriteLine($"{x}{y}");
            //Console.WriteLine($"{nblettre}");
            int nbtraité = mottraité.Length;
            int i = 0;
            int j = nbtraité - 1;
            while (mottraité[i] == mottraité[j] && i<j)
            {
                i++;
                j--;
            }
            if (i>=j)
            {
                Console.WriteLine("C'est un palindrome.");
            }
            else
            {
                Console.WriteLine("Ce n'est pas un palindrome.");
            }
        }
    }
}
