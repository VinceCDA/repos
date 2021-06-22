using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExceptions
{
    class Exemple3
    {
        internal static void Entree()
        {
            Fonction1();
            Console.ReadLine();
        }

        private static void Fonction1()
        {
            Fonction2();
        }

        private static void Fonction2()
        {
            try
            {
                int resultat = Division(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("F2 Erreur Division 0 Message : {0} \r\n Application : {1} Fonction : {2}",
              ex.Message, ex.Source, ex.TargetSite);
              
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("F2 Erreur arithmétique autre que div 0 Message : {0} \r\n Application : {1} Fonction : {2}",
                    ex.Message, ex.Source, ex.TargetSite);
            }
            catch (Exception ex)
            {
                Console.WriteLine("F2 Erreur autre Message : {0} \r\n Application : {1} Fonction : {2} Pile {3} ",
                    ex.Message, ex.Source, ex.TargetSite,ex.StackTrace);
            }
          
        }

        private static int Division(int p1, int p2)
        {
                string s = "A";
                p2 = int.Parse(s);
                return p1 / p2;
        }

        //private static int Division(int p1, int p2)
        //{
        //    try
        //    {
        //        return p1 / p2;
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine("Exception Message : {0} \r\n Application : {1} Fonction : {2}",
        //            ex.Message, ex.Source, ex.TargetSite);
        //        return 0;
        //    }

        //}
    }
}
