using SalariesBOL;
using System;

namespace SalariesConsole
{
    class Program
    {
        static void Main(string[] args)
        {

        
            Salarie SalarieTest = new Salarie();
            Salarie.Com SalareieTest2 = new Salarie.Com();
            SalarieTest.Matricule = "12aaa12";
            SalarieTest.Nom = "Bibou";
            SalarieTest.Prenom = "kiki";
            SalarieTest.SalaireBrut = 1200;
            SalarieTest.TauxCs = 0.5;
            string dates = "1-01-2000";
            SalarieTest.DateNaissance = DateTime.Parse(dates);
            SalareieTest2.Matricule = "21bbb21";
            SalareieTest2.Nom = "Noidq";
            SalareieTest2.Prenom = "Nfadqsd";
            SalareieTest2.SalaireBrut = 1200;
            SalareieTest2.TauxCs = 0.3;
            SalareieTest2.ChiffreAffaire = 500;
            SalareieTest2.Commission = 0.2;
            string dates2 = "08-08-1980";
            SalareieTest2.DateNaissance = DateTime.Parse(dates2);



            //if (Salarie.controleNom("k"))
            //{

            //}

            try
            {

              //SalarieTest.Prenom = "kik";
              //SalarieTest.Nom = "k";

            }
            catch (Exception e)
            {

               Console.WriteLine(e.Message);
            }

            Salarie s1 = new Salarie();
            s1.Matricule = "22DER22";
            Salarie s2 =  new Salarie();
            s1.Matricule = "22DER22"; 
            Console.WriteLine(s1.Equals(s2));

            //DateTime ds = DateTime.Parse(dates);
            Console.WriteLine(SalarieTest.Matricule);
            Console.WriteLine(SalarieTest.Nom);
            Console.WriteLine(SalarieTest.Prenom);
            Console.WriteLine(SalarieTest.SalaireNet);
            Console.WriteLine(SalarieTest.SalaireBrut);
            Console.WriteLine(SalarieTest.TauxCs);
            Console.WriteLine(SalarieTest.DateNaissance);
            Console.WriteLine(SalareieTest2.Matricule);
            Console.WriteLine($"A{Equals(SalarieTest.Matricule, SalareieTest2.Matricule)}");
            Console.WriteLine($"{SalarieTest.Matricule.GetHashCode()}");
            Console.WriteLine($"{SalareieTest2.Matricule.GetHashCode()}");
            Equals(SalarieTest.Matricule, SalareieTest2.Matricule);
            SalarieTest.ToString();
            SalareieTest2.ToString();
            Console.WriteLine($"{SalarieTest.SalaireNet}");
            Console.WriteLine($"{SalareieTest2.SalaireNet}");










            //Console.WriteLine(sal2.Nom);
            //Console.WriteLine(sal.DateNaissance);
            //Console.WriteLine($"{Salarie.controleTauxCs(-1) }");
            //for (int i = 0; i <= sal.Matricule.Length - 1; i++)
            //{
            //    Console.WriteLine(sal.Matricule[i]);

            //}
            //DateTime d1 = new DateTime(1900,01,01);

            //DateTime d2 = DateTime.Today;
            //Console.WriteLine($"{d1}");
            //Console.WriteLine($"{d2}");
            //TimeSpan ts = d2 - d1;
            //Console.WriteLine($"{ts.Days}");
            //int res = DateTime.Compare(d2, d1);
            //Console.WriteLine($"{res}");
            //Console.WriteLine($"{Console.ReadLine()}");
            //var myDate = DateTime.Now;
            //var newDate = myDate.AddYears(-15);

            //  DateTime.Today.Subtract(DateTime.Days 5475);






        }

    }
}
