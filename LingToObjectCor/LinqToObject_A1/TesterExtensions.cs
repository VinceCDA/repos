using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqToObject_A1
{
    public static class TesterExtensionsEtLambda
    {
       public static void Tester()
        {
            List<String> listeMots = new List<string>
           {
               "le plus beau des tangos du monde",
               "Combien avons-nous de candidats pour le 18",
               "le rouge et le noir",
               "CDA open to work"
           };
            var listePlus5 = listeMots.Where(s => s.WordsCount() > 5);
            Console.WriteLine($"Attendu {2==listePlus5.Count()}");
            Console.WriteLine($"Longueur somme {linqExtension.SommeLongueurs("CDA", " 2020")}");

            double[] valeursNbPair = new double[]
            {
               50,
               25,
               100,
               10
            };
            Console.WriteLine($"Valeur médiane attendue {75.00 / 2.00 == valeursNbPair.Median()}");
            double[] valeursNbImpair = new double[]
               {
               50,
               25,
               100,
               10,
               70
               };
            Console.WriteLine($"Valeur médiane attendue {50.00 == valeursNbImpair.Median()}");
        }
    }
}
