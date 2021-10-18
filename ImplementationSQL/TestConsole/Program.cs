using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using TypesSQL;

namespace TestConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            VerifierRegExp();
            VerifierLuhn();
          
           Console.ReadLine();
        }

        static void VerifierRegExp()
        {
            SqlString valeur = "a";
            SqlString modele = "^a";
            Console.WriteLine("Exp Reg Attendu : {0} Obtenu {1}", "true", ExpressionsRegulieres.ExpressionRegIsMatch(valeur, modele));
            valeur = "12345678";
            modele = "^[0-9]{8}$";
            Console.WriteLine("Exp Reg Attendu : {0} Obtenu {1}", "true", ExpressionsRegulieres.ExpressionRegIsMatch(valeur, modele));

        }
        static void VerifierLuhn()
        {
           
            string SiretAmicaleStagiaireAfpa = "78957264100015";
            Console.WriteLine("Luhn Attendu : {0} Obtenu {1}", "true", Luhn.IsLuhnValide(SiretAmicaleStagiaireAfpa));
            string ComiteAfpa = "39900774900019";
            Console.WriteLine("Luhn Attendu : {0} Obtenu {1}", "true", Luhn.IsLuhnValide(ComiteAfpa));
            string NombreImpair = "521";
            Console.WriteLine("Luhn Attendu : {0} Obtenu {1}", "true", Luhn.IsLuhnValide(NombreImpair));
            string NombrePair = "1214";
            Console.WriteLine("Luhn Attendu : {0} Obtenu {1}", "true", Luhn.IsLuhnValide(NombrePair));
           
        }

    }
}
