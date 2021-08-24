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
   public class GuichetDAC
    {
        private static GuichetDAC _instance = null;
        private static readonly object _verrou = new object();
        /// <summary>
        /// Privatisation du constructeur
        /// </summary>
        private GuichetDAC() { }

        /// <summary>
        /// Méthode de création d'instance publique
        /// </summary>
        public static GuichetDAC Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new GuichetDAC();
                    }
                }
                return _instance;
            }
        }


        public Guichet GetGuichetByClient(Client client)
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT CodeGuichet, CodeBanque,Domiciliation,Dénomination, " +
                                                 "Adresse1, Adresse2, " +
                                                 "CodePostal,  Ville FROM dbo.Guichet " +
                                                 "Where CodeGuichet = @CodeGuichet ";
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeGuichet",
                    Direction = ParameterDirection.Input,
                    Value = client.CodeGuichet
                });

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                   return rd.Read() ? ChargerDonnees(rd) : null;
                }
               
            }

        }

        private HashSet<Guichet> AlimenterListe(SqlCommand cmd)
        {
            HashSet<Guichet> guichets = new HashSet<Guichet>();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    guichets.Add(ChargerDonnees(rd));
                }
            }
            return guichets;
        }
        private Guichet ChargerDonnees(SqlDataReader rd)
        {
            Guichet guichet = new Guichet
            {
                CodeGuichet = rd["CodeGuichet"].ToString(),
                CodeBanque = rd["CodeBanque"].ToString(),
                Domiciliation = rd["Domiciliation"].ToString(),
                Dénomination = rd["Dénomination"].ToString(),
                Adresse1 = rd["Adresse1"].ToString(),
                Adresse2 = rd["Adresse2"].ToString(),
                CodePostal = rd["CodePostal"].ToString(),
                Ville = rd["Ville"].ToString()
            };

            return guichet;
        }
    }
}
