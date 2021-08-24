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
    public class CompteExterneDAC
    {
        private static CompteExterneDAC _instance = null;
        private static readonly object _verrou = new object();
        /// <summary>
        /// Privatisation du constructeur
        /// </summary>
        private CompteExterneDAC() { }

        /// <summary>
        /// Méthode de création d'instance publique
        /// </summary>
        public static CompteExterneDAC Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new CompteExterneDAC();
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
        public CompteExterne GetCompteExterneById(string codeBanque, string codeGuichet, string codeClient, string numeroCompte)
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT dbo.CompteExterne.CodeClient, dbo.CompteExterne.NumeroCompte, dbo.CompteExterne.CleRIB, " +
                    "dbo.CompteExterne.LibelleCompte, dbo.CompteExterne.CodeBanque, dbo.CompteExterne.CodeGuichet, " +
                    "dbo.CompteExterne.OrdreListe " +
                    " FROM dbo.CompteExterne " +
                    " WHERE CodeBanque = @CodeBanque AND CodeGuichet = @CodeGuichet AND Codeclient = @Codeclient AND numeroCompte = @numeroCompte";

                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeBanque",
                    Direction = ParameterDirection.Input,
                    Value = codeBanque
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@codeGuichet",
                    Direction = ParameterDirection.Input,
                    Value = codeGuichet
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@codeClient",
                    Direction = ParameterDirection.Input,
                    Value = codeClient
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@numeroCompte",
                    Direction = ParameterDirection.Input,
                    Value = numeroCompte
                });
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;

                }
            }

        }
        public void AddCompteExterne(CompteExterne compte)
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "[psCompteExterne_Ajouter]";

                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeBanque",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 5,
                    Value = compte.CodeBanque
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@codeGuichet",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 5,
                    Value = compte.CodeGuichet
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@codeClient",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 8,
                    Value = compte.Client.CodeClient
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@numeroCompte",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 11,
                    Value = compte.NumeroCompte
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@cleRib",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 2,
                    Value = compte.CleRIB
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@libellecompte",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 100,
                    Value = compte.LibelleCompte
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@OrdreListe",
                    Direction = ParameterDirection.Output,
                    SqlDbType = SqlDbType.Int
                });

                cmd.ExecuteNonQuery();
                compte.OrdreListe = (int)cmd.Parameters["@OrdreListe"].Value;

            }
        }
        /// <summary>
        /// Retourne la liste des comptes d'un client avec les infos type  Compte
        /// </summary>
        /// <param name="codeBanque"></param>
        /// <param name="codeGuichet"></param>
        /// <returns></returns>
        public HashSet<CompteExterne> GetComptesExternesByCodeClient(Client client)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT dbo.CompteExterne.CodeClient, dbo.CompteExterne.NumeroCompte, dbo.CompteExterne.CleRIB, " +
                    "dbo.CompteExterne.LibelleCompte, dbo.CompteExterne.CodeBanque, dbo.CompteExterne.CodeGuichet, " +
                    "dbo.CompteExterne.OrdreListe " +
                    " FROM dbo.CompteExterne " +
                    " WHERE Codeclient = @Codeclient";
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeClient",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Int,
                    Size = 8,
                    Value = client.CodeClient
                });

                return AlimenterListe(cmd);

            }
            //return new HashSet<CompteExterne>(); // FAKE
        }

        private HashSet<CompteExterne> AlimenterListe(SqlCommand cmd)
        {
            HashSet<CompteExterne> comptes = new HashSet<CompteExterne>();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    comptes.Add(ChargerDonnees(rd));
                }
            }
            return comptes;
        }
        private CompteExterne ChargerDonnees(SqlDataReader rd)
        {
            CompteExterne compte = new CompteExterne
            {
                CodeBanque = rd["CodeBanque"].ToString(),
                CodeGuichet = rd["CodeGuichet"].ToString(),
                NumeroCompte = rd["NumeroCompte"].ToString(),
                CleRIB = rd["CleRIB"].ToString(),
                LibelleCompte = rd["Libellecompte"].ToString(),
                OrdreListe = (int)rd["OrdreListe"]
            };
            return compte;
        }
        public HashSet<CompteBase> LiaisionsComptes(Client client)
        {
            
            HashSet<Compte> comptes = new HashSet<Compte>();
            comptes = CompteDAC.Instance.GetComptesByCodeClient(client);
            HashSet<CompteExterne> compteExternes = new HashSet<CompteExterne>();
            compteExternes = GetComptesExternesByCodeClient(client);
            HashSet<CompteBase> comptesOut = new HashSet<CompteBase>();
            comptesOut.UnionWith(comptes);
            comptesOut.UnionWith(compteExternes);
            return comptesOut;
        }
    }



}


