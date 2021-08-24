using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestHashSetHeritage
{
   public abstract class Personne : INotifyPropertyChanged
    {
        int _code;
        string _nom;
        string _prenom;
        public int Code { get; set; }
        public string Nom { get { return _nom; } 
            set 
            {
                if (value != this._nom)
                {
                    NotifyPropertyChanged("Nom");
                }
                this._nom = value;
            } 
        }
        public string Prenom { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public override bool Equals(Object personne)
        {
            Personne personneRef = personne as Personne;
            if (personneRef == null) return false;
            return (personneRef.Code == this.Code);
        }

        public override int GetHashCode()
        {   
            return Code.GetHashCode(); ;
        }
        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="personneA">Instance Personne</param>
        /// <param name="personneB">Instance Personne</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Personne personneA, Personne personneB)
        {
            return personneA is null ? personneB is null : personneA.Equals(personneB);
        }
        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="personneA">Instance Personne</param>
        /// <param name="personneB">Instance Personne</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Personne personneA, Personne personneB)
        {
            return personneA is null ? !(personneB is null) : !personneA.Equals(personneB);
        }
        private void NotifyPropertyChanged(string nomPropriete)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nomPropriete));
            }
        }
    }
}
