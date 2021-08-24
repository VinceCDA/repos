using Banque.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.DAL
{
    public class CompteDAC
    {
        private static CompteDAC _instance = null;
        private static readonly object _verrou = new object();
        /// <summary>
        /// Privatisation du constructeur
        /// </summary>
        private CompteDAC() { }

        /// <summary>
        /// Méthode de création d'instance publique
        /// </summary>
        public static CompteDAC Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new CompteDAC();
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Retourne les propriétés d'un compte avec les infos type  Compte
        /// </summary>
        /// <param name="codeBanque"></param>
        /// <param name="codeGuichet"></param>
        /// <returns></returns>
        public Compte GetCompteById(string codeBanque, string codeGuichet, string codeClient, string numeroCompte)
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT dbo.Compte.CodeClient, dbo.Compte.NumeroCompte, dbo.Compte.CleRIB, dbo.Compte.IBAN, " +
                    "dbo.Compte.Libellecompte, dbo.Compte.CodeBanque, dbo.Compte.CodeGuichet, dbo.Compte.Solde, dbo.Compte.TypeCompte, " +
                    "dbo.Compte.OrdreListe, dbo.TypeCompte.DésignationTypeCompte, dbo.TypeCompte.CodeTypeCompte, " +
                    " dbo.TypeCompte.EmissionVirementInterne, dbo.TypeCompte.EmissionVirementExterne " +
                    " FROM dbo.Compte INNER JOIN dbo.TypeCompte ON dbo.Compte.TypeCompte = dbo.TypeCompte.CodeTypeCompte " +
                    " WHERE CodeBanque = @CodeBanque AND CodeGuichet = @CodeGuichet AND Codeclient = @Codeclient AND numeroCompte = @numeroCompte";

                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeBanque",
                    Direction = ParameterDirection.Input,
                    TypeName = "String",
                    Value = codeBanque
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@codeGuichet",
                    Direction = ParameterDirection.Input,
                    TypeName = "String",
                    Value = codeGuichet
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@codeClient",
                    Direction = ParameterDirection.Input,
                    TypeName = "String",
                    Value = codeClient
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@numeroCompte",
                    Direction = ParameterDirection.Input,
                    TypeName = "String",
                    Value = numeroCompte
                });
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;

                }
            }

        }
        /// <summary>
        /// Retourne la liste des comptes d'un client avec les infos type  Compte
        /// </summary>
        /// <param name="codeBanque"></param>
        /// <param name="codeGuichet"></param>
        /// <returns></returns>
        public  HashSet<Compte> GetComptesByCodeClient(Client client)
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT dbo.Compte.CodeClient, dbo.Compte.NumeroCompte, dbo.Compte.CleRIB, dbo.Compte.IBAN, " +
                    "dbo.Compte.Libellecompte, dbo.Compte.CodeBanque, dbo.Compte.CodeGuichet, dbo.Compte.Solde, " +
                    "dbo.Compte.OrdreListe, dbo.TypeCompte.DésignationTypeCompte, dbo.TypeCompte.CodeTypeCompte, " +
                    " dbo.TypeCompte.EmissionVirementInterne, dbo.TypeCompte.EmissionVirementExterne " +
                    " FROM dbo.Compte INNER JOIN dbo.TypeCompte ON dbo.Compte.CodeTypeCompte = dbo.TypeCompte.CodeTypeCompte " +
                    " WHERE Codeclient = @Codeclient ";

               
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@codeClient",
                    Direction = ParameterDirection.Input,
                    Value = client.CodeClient
                });

               return AlimenterListe(cmd);
            }

        }
        private HashSet<Compte> AlimenterListe(SqlCommand cmd)
        {
            HashSet<Compte> comptes = new HashSet<Compte>();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    comptes.Add(ChargerDonnees(rd));
                }
            }
            return comptes;
        }
        private Compte ChargerDonnees(SqlDataReader rd)
        {
            Compte compte = new Compte
            {
                CodeBanque = rd["CodeBanque"].ToString(),
                CodeGuichet = rd["CodeGuichet"].ToString(),
                CodeClient = rd["CodeClient"].ToString(),
                CodeTypeCompte = rd["CodeTypeCompte"].ToString(),
                NumeroCompte = rd["NumeroCompte"].ToString(),
                LibelleCompte = rd["Libellecompte"].ToString(),
                IBAN = rd["IBAN"].ToString(),
                OrdreListe = (int)rd["OrdreListe"],
                CleRIB = rd["CleRIB"].ToString(),
                Solde = rd["Solde"] == DBNull.Value ? 0 : (decimal)rd["Solde"]
            };
            TypeCompte typeCompte = new TypeCompte
            {
                CodeTypeCompte = rd["CodeTypeCompte"].ToString(),
                DésignationTypeCompte = rd["DésignationTypeCompte"].ToString(),
                EmissionVirementExterne = (bool)rd["EmissionVirementExterne"],
                EmissionVirementInterne = (bool)rd["EmissionVirementInterne"]
            };
            compte.TypeCompte = typeCompte;
            return compte;
        }
       
       
        
    }

}
