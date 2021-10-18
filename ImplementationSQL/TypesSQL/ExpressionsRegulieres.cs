using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;

namespace TypesSQL
{
    public static class ExpressionsRegulieres
    {
        [SqlFunctionAttribute(IsDeterministic=true)]
        public static SqlBoolean ExpressionRegIsMatch(SqlString valeur,SqlString motif)
        {
            if (valeur.IsNull || motif.IsNull)
            {
                return SqlBoolean.False;
            }
            return Regex.IsMatch(valeur.Value, motif.Value);
        }
    }
        public static class Luhn 
        {
    public static bool IsLuhnValide(string valeur)
        {
            int chiffre;
            int somme = 0;
            int impair = valeur.Length & 1;
           
            for (int i = 0; i < valeur.Length; i++)
            {
                chiffre = int.Parse(valeur[i].ToString()) * (2 - (i+impair) % 2);
                somme += chiffre >9 ? chiffre - 9 : chiffre;
            }
            return (somme % 10 == 0);
        }
    }
}