using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Linq
{    
    public static class linqExtension
    {
        public static double Median(this IEnumerable<double> source)
        {
            if (source.Count() == 0)
            {
                throw new InvalidOperationException("La séquence ne peut être vide.");
            }

            double[] doubles = source.OrderBy(d => d).ToArray();
            int indexMedian = doubles.Length / 2;

            return  (doubles.Length % 2 == 0) 
                ? (doubles[indexMedian] + doubles[indexMedian - 1]) / 2
                : doubles[indexMedian];
            
        }
    public static int WordsCount(this String source)
        {
            return source.Split(new char[] { '.', ' ', ';', '!', '?' }).Count();
        }
    public static Func<string, string, long> SommeLongueurs = (a, b) => a.Length + b.Length;
    }
   
    
}
