using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Bibliotheque.BOL;
using System.Data;
using System.Transactions;

namespace Bibliotheque.DAL
{
    public class AdherentDAO
    {
        private static AdherentDAO _instance = null;
        private static readonly object _verrou = new object();
        public static AdherentDAO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new AdherentDAO();
                    }
                }
                return _instance;
            }
        }
        public Adherent GetByID(string idAdherent)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection() )
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SqlParameter pIdAdherent = command.CreateParameter();
                pIdAdherent.ParameterName = "@IdAdherent";
                pIdAdherent.DbType = DbType.String;
                pIdAdherent.Direction = ParameterDirection.InputOutput;
                pIdAdherent.Value = idAdherent;
                command.Parameters.Add(pIdAdherent);
                command.CommandText = "Select IdAdherent,PrenomAdherent,NomAdherent from Adherent where idAdherent = @IdAdherent";
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;
                }
            }
        }
        public Livre GetLivreByID(string isbn)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            using ( SqlCommand command2 = cnx.CreateCommand())
            {
                Livre livre = new Livre();
                HashSet<Exemplaire> exemplaires = new HashSet<Exemplaire>();
                command.CommandType = CommandType.Text;
                SqlParameter pISBN = command.CreateParameter();
                pISBN.ParameterName = "@Isbn";
                pISBN.DbType = DbType.String;
                pISBN.Direction = ParameterDirection.InputOutput;
                pISBN.Value = isbn;
                command.Parameters.Add(pISBN);
                command.CommandText = "Select ISBN,Titre FROM Livre where ISBN = @Isbn";
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        ChargerLivre(rd,livre);
                    }
                    
                }
                command2.CommandType = CommandType.Text;
                SqlParameter pISBN2 = command2.CreateParameter();
                pISBN2.ParameterName = "@Isbn";
                pISBN2.DbType = DbType.String;
                pISBN2.Direction = ParameterDirection.InputOutput;
                pISBN2.Value = isbn;
                command2.Parameters.Add(pISBN2);
                command2.CommandText = "SELECT IdExemplaire,Empruntable,ISBN FROM Exemplaire WHERE ISBN = @Isbn";
                using (SqlDataReader rd = command2.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        livre.Exemplaires.Add(ChargerExemplaire(rd));
                    }

                }
                return livre;


            }
        }
        public HashSet<Adherent> GetAll()
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "Select IdAdherent,PrenomAdherent,NomAdherent from Adherent";
                return AlimenterListe(command);
            }

        }
        public HashSet<Pret> GetAllPreet()
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdAdherent,IdExemplaire,DateEmprunt,DateRetour FROM Pret";
                return AlimenterListePret(command);
            }

        }
        public HashSet<Pret> GetPret(string idAdherent)
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SqlParameter pIdAdherent = command.CreateParameter();
                pIdAdherent.ParameterName = "@IdAdherent";
                pIdAdherent.DbType = DbType.String;
                pIdAdherent.Direction = ParameterDirection.InputOutput;
                pIdAdherent.Value = idAdherent;
                command.Parameters.Add(pIdAdherent);
                command.CommandText = "SELECT IdAdherent,IdExemplaire,DateEmprunt,DateRetour FROM Pret WHERE IdAdherent = @IdAdherent";
                return AlimenterListePret(command);
            }

        }
        private HashSet<Adherent> AlimenterListe(SqlCommand command)
        {
            HashSet<Adherent> adherents = new HashSet<Adherent>();
            using (SqlDataReader rd = command.ExecuteReader())
            {
                while (rd.Read())
                {
                    adherents.Add(ChargerDonnees(rd));
                }
            }
            return adherents;
        }
        private HashSet<Pret> AlimenterListePret(SqlCommand command)
        {
            HashSet<Pret> prets = new HashSet<Pret>();
            using (SqlDataReader rd = command.ExecuteReader())
            {
                while (rd.Read())
                {
                    prets.Add(ChargerPret(rd));
                }
            }

            return prets;
        }
        private Adherent ChargerDonnees(SqlDataReader rd)
        {
            Adherent adherent = new Adherent
            {

                AdherentID = rd["IdAdherent"].ToString(),
                Nom = rd["NomAdherent"].ToString(),
                Prenom = rd["PrenomAdherent"] == DBNull.Value ? string.Empty : rd["PrenomAdherent"].ToString(),
                // Prenom = rd["PrenomAdherent"]?.ToString

            };
            adherent.Prets.UnionWith(GetPret(adherent.AdherentID));
            return adherent;
        }
        private Pret ChargerPret(SqlDataReader rd)
        {
            Pret pret = new Pret();
            pret.AdherentID = rd["IdAdherent"].ToString();
            pret.IdExemplaire = (int)rd["IdExemplaire"];
            pret.DateEmprunt = DateTime.Parse(rd["DateEmprunt"].ToString());
            if (DateTime.TryParse(rd["DateRetour"].ToString(),out DateTime date))
            {
                pret.DateRetour = date;
            }
            else
            {
                pret.DateRetour = null;
            }
            return pret;
        }
        private Livre ChargerLivre(SqlDataReader rd,Livre livre)
        {
            livre.ISBN = rd["ISBN"].ToString();
            livre.Titre = rd["Titre"].ToString();
            return livre;
        }
        private Exemplaire ChargerExemplaire(SqlDataReader rd)
        {
            Exemplaire exemplaire = new Exemplaire();
            exemplaire.ISBN = rd["ISBN"].ToString();
            exemplaire.IdExemplaire = (int)rd["IdExemplaire"];
            exemplaire.Empruntable = (bool)rd["Empruntable"];
            return exemplaire;
        }

        public bool TransacPret(Adherent adherent, int idExemplaire)
        {

            if (adherent.EmprunterExemplaireIsValid(adherent))
            {
                using (var scopePret = new TransactionScope())
                {
                    using (SqlConnection cnx = DB.Instance.GetDBConnection())
                    using (SqlCommand command = cnx.CreateCommand())
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Pret_Insert";
                        SqlParameter sqlParameterIdAd = command.CreateParameter();
                        sqlParameterIdAd.ParameterName = "@IdAdherent";
                        sqlParameterIdAd.DbType = DbType.String;
                        sqlParameterIdAd.Direction = ParameterDirection.Input;
                        sqlParameterIdAd.Value = adherent.AdherentID;
                        command.Parameters.Add(sqlParameterIdAd);
                        SqlParameter sqlParameterIdEx = command.CreateParameter();
                        sqlParameterIdEx.ParameterName = "@IdExemplaire";
                        sqlParameterIdEx.DbType = DbType.Int32;
                        sqlParameterIdEx.Direction = ParameterDirection.Input;
                        sqlParameterIdEx.Value = idExemplaire;
                        command.Parameters.Add(sqlParameterIdEx);
                        SqlParameter sqlParameterDateEmp = command.CreateParameter();
                        sqlParameterDateEmp.ParameterName = "@DateEmprunt";
                        sqlParameterDateEmp.DbType = DbType.Date;
                        sqlParameterDateEmp.Direction = ParameterDirection.Input;
                        sqlParameterDateEmp.Value = DateTime.Now;
                        command.Parameters.Add(sqlParameterDateEmp);
                        SqlParameter sqlParameterDateRet = command.CreateParameter();
                        sqlParameterDateRet.ParameterName = "@DateRetour";
                        sqlParameterDateRet.DbType = DbType.Date;
                        sqlParameterDateRet.Direction = ParameterDirection.Input;
                        sqlParameterDateRet.Value = null;
                        command.Parameters.Add(sqlParameterDateRet);
                        command.ExecuteNonQuery();
                        using (var scopeExemplaire = new TransactionScope())
                        {
                            using (SqlConnection cnx2 = DB.Instance.GetDBConnection())
                            using (SqlCommand command2 = cnx2.CreateCommand())
                            {
                                command2.CommandType = CommandType.StoredProcedure;
                                command2.CommandText = "Exemplaire_Update";
                                SqlParameter sqlParameterIdExemp = command.CreateParameter();
                                sqlParameterIdExemp.ParameterName = "@IdExemplaire";
                                sqlParameterIdExemp.DbType = DbType.Int32;
                                sqlParameterIdExemp.Direction = ParameterDirection.Input;
                                sqlParameterIdExemp.Value = idExemplaire;
                                command2.Parameters.Add(sqlParameterIdExemp);
                                SqlParameter sqlParameterEmpruntable = command2.CreateParameter();
                                sqlParameterEmpruntable.ParameterName = "@Empruntable";
                                sqlParameterEmpruntable.DbType = DbType.Boolean;
                                sqlParameterEmpruntable.Direction = ParameterDirection.Input;
                                sqlParameterEmpruntable.Value = false;
                                command2.Parameters.Add(sqlParameterEmpruntable);
                                command2.ExecuteNonQuery();
                            }
                            scopeExemplaire.Complete();
                        }
                    }
                    scopePret.Complete();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
               
    


        public void Create(Adherent adherent)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandText = "dbo.Adherent_Insert";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres 
                SqlParameter parameter;
                parameter = new SqlParameter();
                parameter.ParameterName = "@RETURN_VALUE";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@IdAdherent";
                parameter.SqlDbType = SqlDbType.NChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 10;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@NomAdherent";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 50;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@PrenomAdherent";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 50;
                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@IdAdherent"].Value = adherent.AdherentID;
                command.Parameters["@NomAdherent"].Value = adherent.Nom;
                command.Parameters["@PrenomAdherent"].Value = adherent.Prenom;
                command.ExecuteNonQuery();

                // Mise à jour éventuelle si nécessaire
                adherent.Prenom = command.Parameters["@NomAdherent"].Value.ToString();
            }
        }
        public void Update(Adherent adherent)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandText = "dbo.Adherent_Update";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres 
                SqlParameter parameter;
                parameter = new SqlParameter();
                parameter.ParameterName = "@RETURN_VALUE";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@IdAdherent";
                parameter.SqlDbType = SqlDbType.NChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 10;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@NomAdherent";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 50;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@PrenomAdherent";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 50;
                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@IdAdherent"].Value = adherent.AdherentID;
                command.Parameters["@NomAdherent"].Value = adherent.Nom;
                command.Parameters["@PrenomAdherent"].Value = adherent.Prenom;

                if (command.ExecuteNonQuery() == 0)
                {
                    throw new Exception(Messages.UpdateNonTraite);
                }
            }
        }
        public void Delete(string idAdherent)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandText = "dbo.Adherent_Delete";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres 
                SqlParameter parameter;
                parameter = new SqlParameter();
                parameter.ParameterName = "@RETURN_VALUE";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@IdAdherent";
                parameter.SqlDbType = SqlDbType.NChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 10;
                command.Parameters.Add(parameter);

                // Passage des valeurs

                command.Parameters["@IdAdherent"].Value = idAdherent;
                if (command.ExecuteNonQuery() == 0)
                {
                    throw new Exception(Messages.UpdateNonTraite);
                }
            }
        }
    }
}