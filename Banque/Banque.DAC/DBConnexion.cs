using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Banque.DAL
{
    /// <summary>
    /// Fournit les mécanismes de connexion & déconnexion à la base de données
    /// La chaine de connexion doit être initialisé au démarrage de l'application
    /// </summary>

    public class DB
    {
        public static string DbConnectionString { get; set; } = null;
        private static DB _instance = null;
        private static readonly object _verrou = new object();
        public static DB Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new DB();
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// Fournit une connexion à la base de données valide
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetDBConnection()
        {
            SqlConnection oCon = new SqlConnection(DbConnectionString);
            oCon.Open();
            return oCon;
        }
    }
}
