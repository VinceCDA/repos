using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LinqToObject_A1
{
    class Program
    {
        static void Main(string[] args)
        {
           TesterExtensionsEtLambda.Tester();

           // Exo_001_1.P1_Min_Max();
            //Exo_001_1.P2_Moyenne();
            //Exo_001_1.P3_Somme();
            //Exo_001_1.P4_Somme();
            //Exo_001_1.P5_ListeOrdonnee();
            //  Exo_001_1.P6_ListeCarreSup5();
            //Exo_001_1.P7_ListeDivisible5();
            //   Exo_001_1.P8_CarreSupMoyenneCarre();
            //Exo_001_1.P9_Range_1_to_5();
        //   Exo_001_1.P9_Factoriel(20);
          //  Exo_001_2.P1_PlusJeunesPlusAge();
          //  Exo_001_2.P2_NomLeplusLong();
            //// Exo_001_2.P3_ListeOrdonneAge();
           // Exo_001_2.P3_ListeOrdonneNbCarNom();
            //Exo_001_2.P4_ListeOrdonneAge();
            //Exo_001_2.P5_NomCommencePar("b");
            //Exo_001_2.P6_NomContient("b");
            //Exo_001_2.P7_Pagination(1, 5);
            Exo_001_2.P8_AgeMoyenStagiaires();
          //  Exo_001_2.P9_StagiairesAgeSupMoyenne();
           // Exo_001_2.P9_StagiairesAgeInfMoyenne();
        //    Exo_001_3.ArreterServices("MSSQL");

            Console.Read();
        }
    }

    internal static class Exo_001_1
    {
        static int[] Liste = JeuEssai.CreeListeEntiers();

        internal static void P1_Min_Max()
        {

            Console.WriteLine($"Valeur Maximale de la liste V 1 : {Liste.Max()}");

            int max = (from nb in Liste
                       orderby nb descending
                       select nb).First();

            Console.WriteLine($"Valeur Maximale de la liste V 2 : {max}");

            Console.WriteLine($"Valeur Maximale de la liste V 3 : " +
                $"{Liste.Aggregate((e, next) => e = (e > next) ? e : next)}");

            Console.WriteLine($"Valeur Minimale de la liste V 1 : {Liste.Min()}");

            var min = (from nb in Liste
                       orderby nb ascending
                       select nb).First();

            Console.WriteLine($"Valeur Maximale de la liste V 2 : {min}");
        }
        internal static void P2_Moyenne()
        {
            Console.WriteLine("Valeur moyenne de la liste : {0}", Liste.Average());

        }
        internal static void P3_Somme()
        {
            Console.WriteLine("Somme des éléments de la liste : {0}",
                Liste.Sum());


        }
        internal static void P4_Somme()
        {
            Console.WriteLine("Variante si x nombre pair somme x * 2 si impair somme x * 3 {0}",
                   Liste.Sum(x => (x % 2 == 0) ? x * 2 : x * 3));

        }
        internal static void P5_ListeOrdonnee()
        {
            Console.WriteLine("Liste ordonnée \r\n");
            ObjectDumper.Write(Liste.OrderBy(x => x));
            Console.WriteLine();
        }
        internal static void P6_ListeCarreSup5()
        {
            Console.WriteLine("Liste des nombres dont carré est > 5 \r\n");
            ObjectDumper.Write(Liste.Where(x => x * x > 5).OrderBy(x => x));
            Console.WriteLine();
        }
        internal static void P7_ListeDivisible5()
        {
            Console.WriteLine("Liste des nombres divisibles par 5");
            Console.WriteLine();
            foreach (var item in Liste.Where(x => x % 5 == 0).OrderBy(x => x))
            {
                Console.Write($"{item};");
            }
            Console.WriteLine();
        }

        internal static void P8_CarreSupMoyenneCarre()
        {
            List<int> Liste = Enumerable.Range(1, 100000).ToList();
            Console.WriteLine("Liste des nombres dont le carré est supérieur au carré de la moyenne");
            Console.WriteLine();
            Stopwatch sw = Stopwatch.StartNew();
            double moyenne = Liste.Average();
            double moyenneCarre = moyenne * moyenne;
            var Liste2 = Liste.Where(x => x * x > moyenneCarre).OrderBy(x => x).ToList();
            long tps1 = sw.ElapsedMilliseconds;
            Console.WriteLine($"tps Version 1 : {tps1}");
       //     sw.Stop();
            sw.Reset();
            sw.Start();
            var Liste3 = Liste.Where(x => x * x > Liste.Average() * Liste.Average()).OrderBy(x => x).ToList();
            long tps2 = sw.ElapsedMilliseconds;
            Console.WriteLine($"tps Version 2 : {tps2}");

            // Temps version 1 : 4
            // Temps version 2 : 147134 soit environ 37 000 fois plus long 
        }

        internal static void P9_Range_1_to_5()
        {
            IEnumerable<int> tabEntiers = Enumerable.Range(1, 5);
        }

        internal static void P9_Factoriel(int nombre)
        {
            Console.WriteLine();
            long factoriel=0;
            if (nombre > 0)
            {
                factoriel = Enumerable.Range(1, nombre).Aggregate((agreg, next) => agreg * next);

                // Explications pour nombre = 3
                // La méthode initialise par défaut la valeur d'agrégat avec la première valeur du tableau
                // 
                // Premier passage agreg prend le résultat de 1 * 1 et le range dans agreg
                // Deuxième passage next vaut 2 agreg prend 1 * 2  = 2
                // Troisième passage next vaut 3 agreg prend 2 * 3 = 6 
               
            }
            
            Console.WriteLine($"Le factoriel de {nombre} est {factoriel:N} ");
        }

    }
    internal static class Exo_001_2
    {
        static List<Stagiaire> Liste = JeuEssai.CreeListeStagiaire();

        internal static void P1_PlusJeunesPlusAge()
        {
            // Attention à l'imbrication des agrégats
            var req = Liste.Where(s => s.DateNaissance == Liste.Max(st => st.DateNaissance));
            var req2 = req.Select(s => new { s.DateNaissance, s.Nom });
            var req3 = req.Select(s => new StagiaireMinifie() { NeLe = s.DateNaissance?.Date, Nom = s.Nom });

            var lesPlusJeunes = req.ToList();
            // Plus performante est cette version
            DateTime? dateNaissanceRecente = Liste.Max(s => s.DateNaissance?.Date);
            //DateTime? dateNaissanceRecente2 = Liste.Max(s => s.DateNaissance.Value);

            var lesPlusJeunes2 = Liste.FindAll(s => s.DateNaissance == dateNaissanceRecente);
            Console.WriteLine("Stagiaires les plus jeunes :");
            ObjectDumper.Write(lesPlusJeunes);
            DateTime? dateNaissanceAncienne = Liste.Min(s => s.DateNaissance);
            Stagiaire lePlusAge = Liste.Find(s => s.DateNaissance == dateNaissanceAncienne);

            Console.WriteLine("Stagiaire le plus agé :");
            ObjectDumper.Write(lePlusAge);
        }


        internal static void P2_NomLeplusLong()
        {
            int longMax = Liste.Max(s => s.Nom.Length);
            Console.WriteLine("Stagiaire avec le nom le plus long");
            ObjectDumper.Write(Liste.Find(s => s.Nom.Length == longMax));
            Console.WriteLine("Stagiaires (ex aequo avec le nom le plus long");
            ObjectDumper.Write(Liste.FindAll(s => s.Nom.Length == longMax));
        }
        internal static void P3_ListeOrdonneNbCarNom()
        {
            Console.WindowWidth = 120;
            ObjectDumper.Write(Liste.OrderBy(s => s.Nom.Count()));

        }
        internal static void P4_ListeOrdonneAge()
        {
            Console.WindowWidth = 120;
            ObjectDumper.Write(Liste.OrderBy(s => s.DateNaissance));

        }
        internal static void P5_NomCommencePar(string filtre)
        {
            Console.WriteLine("Stagiaires dont le nom commence par {0}", filtre);
            ObjectDumper.Write(Liste.FindAll(s => s.Nom.StartsWith(filtre)));

        }
        internal static void P6_NomContient(string filtre)
        {
            Console.WriteLine("Stagiaires dont le nom contient {0}", filtre);
            ObjectDumper.Write(Liste.FindAll(s => s.Nom.Contains(filtre)));

        }
        internal static void P7_Pagination(int debut, int taillePage)
        {
            Console.WriteLine($"Listes stagiaires du rang {debut} au rang {debut - 1 + taillePage}");
            ObjectDumper.Write(Liste.OrderBy(s => s.Nom).Skip(debut - 1).Take(taillePage));

        }
        internal static void P8_AgeMoyenStagiaires()
        {
            double? ageMoyen = Liste.Where(s => s.DateNaissance.HasValue).Average(s => s.Age);
            double? ageMoyen2 = Liste.Average(s => s.Age);
            Console.WriteLine($"Age moyen des stagiaires {ageMoyen:N} {ageMoyen2:N}");

        }
        internal static void P9_StagiairesAgeSupMoyenne()
        {
            double? ageMoyen = Liste.Where(s => s.DateNaissance.HasValue).Average(s => s.Age);
            double? ageMoyen2 = Liste.Average(s => s.Age);
            Console.WriteLine($"1 : {ageMoyen} 1 : {ageMoyen2}");
            Console.Read();
            var liste = from s in Liste
                        where s.Age > ageMoyen
                        select s;

            Console.WriteLine("Liste des stagiaires dont Age > moyenne");
            ObjectDumper.Write(liste.OrderByDescending(s => s.Age));
        }
        internal static void P9_StagiairesAgeInfMoyenne()
        {
            double? ageMoyen = Liste.Where(s => s.DateNaissance.HasValue).Average(s => s.Age);
            Console.WriteLine("Liste des stagiaires dont Age < moyenne");
            ObjectDumper.Write(Liste.Where(s => s.DateNaissance.HasValue && s.Age < ageMoyen).OrderBy(s => s.Age));
        }
        class StagiaireMinifie
        {
            public DateTime? NeLe { get; set; }
            public string Nom { get; set; }
        }



    }
    internal static class Exo_001_3
    {
        internal static void ArreterServices(string nomService)
        {
            // Il faut installer le pack system.ServiceProcess.ServiceController
            ServiceController.
                GetServices().
                Where(s => s.ServiceName.Contains(nomService)
                && s.Status == ServiceControllerStatus.Running).
                ToList().
                ForEach(
                    s =>
                    {
                        s.Stop();
                        Console.WriteLine($"Service {s.ServiceName} arrêté");
                    });
        }



    }
}

