using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque.BOL;
using System.Data.SqlClient;
using System.Data;

namespace Banque.DAL
{
    public class ClientDAC
    {
        private static ClientDAC _instance = null;
        private static readonly object _verrou = new object();
        /// <summary>
        /// Privatisation du constructeur
        /// </summary>
        private ClientDAC() { }

        /// <summary>
        /// Méthode de création d'instance publique
        /// </summary>
        public static ClientDAC Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new ClientDAC();
                    }
                }
                return _instance;
            }
        }


        public Client GetClientById(string codeClient)
        {
            // A noter
            // Vous pouvez faire un return au sein d'un bloc using, la ressource sera tout de même libérée.
            // La ressource sera aussi libérée si une erreur se produisait dans le bloc using
            // Ce qui ne doit pas être fait serait le renvoi de la ressource managée par l'instruction using
            //
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT        CodeClient, CodeGuichet, CodeBanque, NomClient, PrénomClient, " +
                                                 "CodeSecret, DateDerniereConnexion, EtatCompte, Adresse1, Adresse2, " +
                                                 "CodePostal,  Ville FROM dbo.Client " +
                                                 "Where CodeClient = @CodeClient ";
                cmd.Parameters.Add(new SqlParameter()
                {
                    Direction = ParameterDirection.Input,
                    ParameterName = "@CodeClient",
                    Value = codeClient
                });

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;

                }
            }

        }

        private HashSet<Client> AlimenterListe(SqlCommand cmd)
        {
            HashSet<Client> clients = new HashSet<Client>();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    clients.Add(ChargerDonnees(rd));
                }
            }
            return clients;
        }
        private Client ChargerDonnees(SqlDataReader rd)
        {
            Client client = new Client
            {
                CodeClient = rd["CodeClient"].ToString(),
                NomClient = rd["NomClient"].ToString(),
                CodeGuichet = rd["CodeGuichet"].ToString(),
                CodeBanque = rd["CodeBanque"].ToString(),
                PrénomClient = rd["PrénomClient"].ToString(),
                CodeSecret = rd["CodeSecret"].ToString(),
                DateDerniereConnexion = rd["DateDerniereConnexion"] is DBNull ? null : (DateTime?)rd["DateDerniereConnexion"],
                EtatCompte = rd["EtatCompte"].ToString(),
                Adresse1 = rd["Adresse1"].ToString(),
                Adresse2 = rd["Adresse2"].ToString(),
                CodePostal = rd["CodePostal"].ToString(),
                Ville = rd["Ville"].ToString()
            };

            return client;
        }
        public StatutAuthentification Authentifier(string idClient, string motPasse)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {

                cmd.CommandText = "PS_Client_Authentifier";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    Direction = ParameterDirection.Input,
                    ParameterName = "@IdClient",
                    DbType = DbType.String,
                    Size = 8,
                    Value = idClient
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    Direction = ParameterDirection.Input,
                    ParameterName = "@MotPasse",
                    DbType = DbType.String,
                    Size = 6,
                    Value = motPasse
                });

                cmd.Parameters.Add(new SqlParameter()
                {
                    Direction = ParameterDirection.Output,
                    ParameterName = "@DateConnexion",
                    DbType = DbType.DateTime
                      });
                cmd.Parameters.Add(new SqlParameter()
                {
                    Direction = ParameterDirection.ReturnValue,
                    ParameterName = "@ReturnValue",
                DbType = DbType.Int16
                });
                cmd.ExecuteNonQuery();
                return (StatutAuthentification)cmd.Parameters["@ReturnValue"].Value;

            }

        }
    }
}
