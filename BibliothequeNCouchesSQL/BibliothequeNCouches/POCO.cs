using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.BOL
{
    public class Adherent
    {
        public string AdherentID { get; set; }
        private string _nom;
        //public string Nom { get; set; }
        public string Prenom { get; set; }
        public HashSet<Pret> Prets { get; } = new HashSet<Pret>();
        public string Nom { get => _nom; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Nom adherent");
                }
                _nom = value;
            } 
        }

        /// <summary>
        /// Compare deux instances pour déterminer l'égalité
        /// </summary>
        /// <returns>Vrai si les deux objets sont égaux</returns>
        public override bool Equals(Object obj)
        {
            Adherent objConverti = obj as Adherent;
            if (objConverti == null) return false;
            return (objConverti.AdherentID == this.AdherentID);
        }

        /// <summary>
        /// Compare deux instances pour déterminer l'égalité
        /// Même matricule
        /// </summary>
        /// <param name="salarie"></param>
        /// <returns></returns>
        public bool Equals(Adherent obj)
        {
            if (obj == null) return false;
            return (obj.AdherentID == this.AdherentID);
        }
        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="objA">Instance A</param>
        /// <param name="objB">Instance B</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Adherent objA, Adherent objB)
        {
            return objA is null ? objB is null : objA.Equals(objB);
        }
        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="objA">Instance A</param>
        /// <param name="objB">Instance B</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Adherent objA, Adherent objB)
        {
            return objA is null ? !(objB is null) : !objA.Equals(objB);
        }
        /// <summary>
        /// Une des règles de conception veut que l'on modifie la méthode GetHashCode
        /// Si la méthode Equals est modifiée
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Uniquement si non nul
            return (AdherentID != null) ? AdherentID.GetHashCode() : 0;
        }
        public bool EmprunterExemplaireIsValid(Adherent adherent)
        {
            if (NbPretCoursIsValid(adherent))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool NbPretCoursIsValid(Adherent adherent)
        {
            int nbPret = 0;
            foreach (var item in adherent.Prets)
            {

                if (item.DateRetour == null)
                {
                    nbPret += 1;
                }
            }
            if (nbPret > 5)
            {
                return false;
            }
            return true;
        }

    }
    public class Livre
    {
        public string ISBN { get; set; }
        public string Titre { get; set; }
        public HashSet<Exemplaire> Exemplaires { get; } = new HashSet<Exemplaire>();
        /// <summary>
        /// Compare deux instances pour déterminer l'égalité
        /// </summary>
        /// <returns>Vrai si les deux objets sont égaux</returns>
        public override bool Equals(Object obj)
        {
            Livre objConverti = obj as Livre;
            if (objConverti == null) return false;
            return (objConverti.ISBN == this.ISBN);
        }

        /// <summary>
        /// Compare deux instances pour déterminer l'égalité
        /// Même matricule
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(Livre obj)
        {
            if (obj == null) return false;
            return (obj.ISBN == this.ISBN);
        }
        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="objA">Instance A</param>
        /// <param name="objB">Instance B</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Livre objA, Livre objB)
        {
            return objA is null ? objB is null : objA.Equals(objB);
        }
        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="objA">Instance A</param>
        /// <param name="objB">Instance B</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Livre objA, Livre objB)
        {
            return objA is null ? !(objB is null) : !objA.Equals(objB);
        }
        /// <summary>
        /// Une des règles de conception veut que l'on modifie la méthode GetHashCode
        /// Si la méthode Equals est modifiée
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Uniquement si non nul
            return (ISBN != null) ? ISBN.GetHashCode() : 0;
        }
    }
    public class Exemplaire
    {
        public int IdExemplaire { get; set; }
        public bool Empruntable { get; set; }
        public string ISBN { get; set; }
        public Livre Livre { get; set; }
        public bool Disponible { get; set; }
    }
    public class Pret
    {
        public string AdherentID { get; set; }
        public Adherent Adherent { get; set; }
        public int IdExemplaire { get; set; }
        public Exemplaire Exemplaire { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime? DateRetour { get; set; }
    }
}

