using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

namespace LinqToObject_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stagiaire> stagiaires = JeuEssai.CreeListeStagiaire();
            int[] entiers = JeuEssai.CreeListeEntiers();
            IEnumerable<double> liste = JeuEssai.CreeListeDouble();
            string strTest1 = "azeazerq";
            string strTest2 = "sdfsdfsdf";
            string strTest3 = "qsqsf qzrqsfqsa azrqs qazrqsf qsdaz";
            var test = stagiaires.Where(s => s.Nom == "Conti").ToList();
            Func<string, string, int> calculLongueur = (texte1, texte2) => texte1.Length + texte2.Length;
            Console.WriteLine($"Res d'ajout des 2 mots : {calculLongueur(strTest1, strTest2)}");
            Console.WriteLine($"Res nombre mots : {strTest3.WordCount()}");
            Console.WriteLine($"Res calcul median : {liste.CalculMedian()}");
            Console.WriteLine($"Res MaxValue : {entiers.Where(i => i == entiers.Max()).Single()}");
            Console.WriteLine($"Res MinValue : {entiers.Where(i => i == entiers.Min()).Single()}");
            Console.WriteLine($"Res Moyenne : {entiers.Average()}");
            Console.WriteLine($"Res Somme : {entiers.Sum()}");
            var tot = (entiers.Where(i => i % 2 == 0).ToList().Sum())*2;
            var tot2 = (entiers.Where(i => i % 2 != 0).ToList().Sum()) * 3;
            var tot3 = entiers.OrderBy(e => e).ToList();
            var tot4 = (entiers.Where(i => i * i > 5).ToList());
            var tot5 = (entiers.Where(i => i % 5 == 0).ToList());
            var tot6 = (entiers.Where(i => i.Carre() > entiers.Average()* entiers.Average()).ToList());
            int int3 = 1;
            foreach (int value in Enumerable.Range(1, 5))
            {
                int3 = int3 * value;
            }
            //Saaaaaaaa
            //
            //
            Stagiaire tt = stagiaires.Where(s => s.Age == stagiaires.Max(s => s.Age)).Single();
            Stagiaire tt2 = stagiaires.Where(s => s.Age == stagiaires.Min(s => s.Age)).Single();
            Stagiaire tt3 = stagiaires.Where(s => s.Nom.Length == stagiaires.Max(s => s.Nom.Length)).Single();
            var tt4 = stagiaires.OrderBy(s => s.Nom.Length).ToList();
            var tt5 = stagiaires.OrderByDescending(s => s.Nom.Length).ToList();
            var tt7 = stagiaires.OrderBy(s => s.Nom.Length).Skip(2).Take(4).ToList();
            var tt8 = stagiaires.Average(s => s.Age);
            var tt9 = stagiaires.Where(s => s.Age > tt8).ToList();
            //
            //
            //
            var tt10 = ServiceController.GetServices();
            ServiceController sc = new ServiceController();
            sc = ServiceController.GetServices().Where(sc => sc.Status == ServiceControllerStatus.Running && sc.ServiceName == "MSSQLSERVER").FirstOrDefault();
            sc.Stop();
            Console.ReadLine();
        }
    }
    public static class Extensions
    {
        public static int WordCount(this string texte)
        {
            string[] subs = texte.Split(' ');
            return subs.Count();
        }
        public static double CalculMedian(this IEnumerable<double> vs)
        {
            double temp;
            if (vs.Count() % 2 != 0)
            {
                temp = Math.Round(vs.Count() / 2.0);
                return vs.ElementAt((int)temp);
            }
            else
            {
                temp = vs.Count() / 2;
                return (vs.ElementAt((int)temp) + vs.ElementAt((int)temp + 1)) / 2.0;
            }
        }
        public static int Carre(this int entier)
        {
            return entier * entier;
        }
    }
}
