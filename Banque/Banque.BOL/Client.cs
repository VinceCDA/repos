

namespace Banque.BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
 
        public Client()
        {
            this.Comptes = new HashSet<Compte>();
            this.ComptesExternes = new HashSet<CompteExterne>();
        }
    
        public string CodeClient { get; set; }
        public string NomClient { get; set; }
        public string CodeGuichet { get; set; }
        public string CodeBanque { get; set; }
        public string PrénomClient { get; set; }
        public string CodeSecret { get; set; }
        public Nullable<System.DateTime> DateDerniereConnexion { get; set; }
        public string EtatCompte { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
    
        public virtual Guichet Guichet { get; set; }
      
        public virtual ICollection<Compte> Comptes { get; set; }
        public virtual ICollection<CompteExterne> ComptesExternes { get; set; }
       
        /// <summary>
        /// Deux références de comptes sont identiques si codes client,Banque,Guichet et Numéros de compte
        /// sont identiques 
        /// </summary>
        /// <returns>Vrai si les deux objets sont égaux</returns>
        public override bool Equals(Object client)
        {
            Client clientRef = client as Client;
            if (clientRef == null) return false;
            return clientRef.CodeClient == this.CodeClient ;
        }

        public override int GetHashCode()
        {
          
            return CodeClient.GetHashCode(); ;
        }
        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="compteA">Instance Compte</param>
        /// <param name="compteB">Instance Compte</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Client clientA, Client clientB)
        {
            return clientA is null ? clientB is null : clientA.Equals(clientB);
        }
        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="compteA">Instance Compte</param>
        /// <param name="compteB">Instance Compte</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Client clientA, Client clientB)
        {
            return clientA is null ? clientB is null : clientA.Equals(clientB);
        }

    }
}
