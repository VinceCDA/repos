using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace A003
{
   internal static class Transactions
    {
       internal static SqlConnection CreerConnection(string connectionString)
       {
           SqlConnection oConnection = new SqlConnection(connectionString);
           return oConnection;
       }
       internal static SqlCommand CreerCommandeMere(SqlConnection oConnection,string nomMere)
       {
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Connection = oConnection;
            oCommand.CommandText = "psMere_insert";
            SqlCommandBuilder.DeriveParameters(oCommand);
            oCommand.Parameters[2].Value = nomMere;
            oCommand.Parameters[1].Direction = ParameterDirection.Output;
            oCommand.Parameters[3].Direction = ParameterDirection.Output;

            return oCommand;
       }
       internal static SqlCommand CreerCommandeFille(SqlConnection oConnection,SqlCommand nomMere,string idFille, string nomFille)
       {
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandType = CommandType.StoredProcedure;
            oCommand.Connection = oConnection;
            oCommand.CommandText = "psFille_insert";
            SqlCommandBuilder.DeriveParameters(oCommand);
            //IdMere
            oCommand.Parameters[1].Value = nomMere.Parameters[1].Value;
            //Idille
            oCommand.Parameters[2].Value = idFille;
            //NomFille
            oCommand.Parameters[3].Value = nomFille;
            oCommand.Parameters[4].Direction = ParameterDirection.Output;
            // A compléter pour obtenir la liste des paramètres
            return oCommand;
       }
       internal static void ExecuterCommandeMere(SqlCommand oCommand, params object[] parametres)
       {
           oCommand.Parameters["@NomMere"].Value = parametres[0];
           oCommand.ExecuteNonQuery();

       }
       internal static void ExecuterCommandeFille(SqlCommand oCommand, params object[] parametres)
       {
           oCommand.Parameters[0].Value = parametres[0];

       }
    }
}
