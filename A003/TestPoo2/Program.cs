using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poo3;

namespace TestPoo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphe1();
            TesterCollection();
            

            
          
        }

        static void Polymorphe1()
        {
            Salarie sal1 = new Salarie("Bost", "Vincent", "96AAA11");

            Commercial com1 = new Commercial("Bost", "Vincent", "96AAA11", 10000, 0.10m)
            {
                SalaireBrut = 3500.00m,
                TauxCS = 0.35m
            };

            Console.WriteLine("Salaire commercial attendu {0} obtenu {1} assertion {2} ", 3275, com1.SalaireNet, 3275 == com1.SalaireNet);
            Console.WriteLine("Détails : {0}", com1.ToString());
            Console.ReadLine();
        }
        static void TesterCollection()
        {
            
           
            Salaries salaries = new Salaries();
            Salarie salarietest = new Salarie("Bliud", "Bliud", "11xxx11");
            Salarie salarietest2 = new Salarie("rtezsq", "Giuop", "11xxx11");
            salarietest.SalaireBrut = 1000;
            salarietest2.SalaireBrut = 1500;
            salarietest.ModificationSalaire += Salarietest_ModificationSalaire;
            salarietest.SalaireBrut = 1200;
            //Salarie salarietest3 = new Salarie("Bliud", "Bliud", "11xxx11");
            salaries.Add(salarietest);
            //bool t = Salarie.Equals(salarietest2,salarietest3);
            //t = salarietest2.Equals(salarietest3);
            try
            {
               salaries.Add(salarietest2);
            }
            catch (SalarieException e)
            {

                Console.WriteLine(e.IdMessage);
                Console.WriteLine(e.Message);
            }
          
            //salaries.Add(salarietest);
            //salaries.Add(salarietest3);
            //Salarie s = null;
            //salaries.Remove(salaries.GetSalarie("12aaa12"));
            //Console.WriteLine($"{salaries.Exists(x => x.Matricule == "12aaa12")}");
            //Console.WriteLine($"{salaries.GetSalarie("12aaa12")}");
            //salaries.Remove(salarietest2);
            //salaries.RemoveSalarie("12aaa12");
            //salaries.SaveText(@"c:\");
            //salaries.LoadText();
           // salarietest.SalaireBrut = 1100;
            foreach (Salarie item in salaries)
            {
                Console.WriteLine(item);
            }
            //salaries.SaveXml();
            
            Console.ReadLine();
            
            
            
        }

        private static void Salarietest_ModificationSalaire(object sender, SalaireModifieEventArgs e)
        {
            decimal tauxAugmentation;
            Console.WriteLine($"Ancien Salaire:{e.AncienSalaireArg}");
            tauxAugmentation = (100 * e.SalaireBrutArg) / e.AncienSalaireArg - 100;
            Console.WriteLine($"Taux Augmentation:{tauxAugmentation}%");
            
        }
    }
}