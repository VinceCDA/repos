using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExceptions
{
    class Exemple2
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

            int resultat = Division(int.MaxValue, int.MaxValue);
        }

        private static int Division(int p1, int p2)
        {
            try
            {
                //string s = "A";
                //p2 = int.Parse(s);
                return p1 * p2;
                //return p1 / p2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Erreur Division 0 Message : {0} \r\n Application : {1} Fonction : {2}",
              ex.Message, ex.Source, ex.TargetSite);
                return 0;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Erreur arithmétique autre que div 0 Message : {0} \r\n Application : {1} Fonction : {2}",
                    ex.Message, ex.Source, ex.TargetSite);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur autre Message : {0} \r\n Application : {1} Fonction : {2}",
                    ex.Message, ex.Source, ex.TargetSite);
                return 0;
            }
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
