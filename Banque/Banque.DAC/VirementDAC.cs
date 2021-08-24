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
    public class VirementDAC
    {
        private static VirementDAC _instance = null;
        private static readonly object _verrou = new object();
        /// <summary>
        /// Privatisation du constructeur
        /// </summary>
        private VirementDAC() { }

        /// <summary>
        /// Méthode de création d'instance publique
        /// </summary>
        public static VirementDAC Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new VirementDAC();
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// Vérification des entrées avant transaction
        /// </summary>
        /// <param name="compteEmetteur">Compte emetteur</param>
        /// <param name="compteDestination">Compte du destinataitre</param>
        /// <param name="coutVirement">String fu montant</param>
        /// <param name="virement">Objet virement avec date et motif</param>
        /// <returns></returns>
        public int CheckDemandeVirement(Compte compteEmetteur,CompteBase compteDestination,string coutVirement, Virement virement)
        {
            decimal parseVirement;
            if (compteEmetteur == compteDestination)
            {
                return 4;
            }
            if (!decimal.TryParse(coutVirement, out parseVirement))
            {
                return 3;
            }
            if (compteEmetteur.Solde < parseVirement)
            {
                return 2;
            }
            if (compteEmetteur.TypeCompte.EmissionVirementExterne == false && compteEmetteur.CodeBanque != compteDestination.CodeBanque)
            {
                return 5;
            }
            virement.CoutVirement = parseVirement;
            return TransactionVirement(compteEmetteur, compteDestination,virement);
        }
        /// <summary>
        /// Transaction avec la base de donnees
        /// </summary>
        /// <param name="compteEmetteur">Compte de l'emetteur du virmeent</param>
        /// <param name="compteDestinataire">Compte du destinataire</param>
        /// <param name="virement">Information du virement</param>
        /// <returns></returns>
        private int TransactionVirement(Compte compteEmetteur, CompteBase compteDestinataire, Virement virement)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[PS_Virement_Ajouter]";
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@NumeroCompteEmetteur",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 11,
                    Value = compteEmetteur.NumeroCompte
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeBanqueEmetteur",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 5,
                    Value = compteEmetteur.CodeBanque
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeGuichetEmetteur",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 5,
                    Value = compteEmetteur.CodeGuichet
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@MontantVirement",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Decimal,
                    Value = virement.CoutVirement
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@MotifVirement",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 100,
                    Value = virement.MotifVirement
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeBanqueBeneficiaire",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 5,
                    Value = compteDestinataire.CodeBanque
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@CodeGuichetBeneficiaire",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 5,
                    Value = compteDestinataire.CodeGuichet
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@NumeroCompteBeneficiaire",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 11,
                    Value = compteDestinataire.NumeroCompte
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@LibelléBeneficiaire",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.Char,
                    Size = 50,
                    Value = compteDestinataire.LibelleCompte
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@DatePrelevement",
                    Direction = ParameterDirection.Input,
                    SqlDbType = SqlDbType.DateTime,
                    Value = virement.DatePrelevement
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@IdVirement",
                    Direction = ParameterDirection.Output,
                    SqlDbType = SqlDbType.Int,
                });
                return cmd.ExecuteNonQuery();
            }
        }
                
            
    }
}
