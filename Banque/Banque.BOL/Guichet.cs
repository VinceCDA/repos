
namespace Banque.BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guichet
    {
        public Guichet()
        {
            this.Clients = new HashSet<Client>();
            this.Comptes = new HashSet<Compte>();
        }
    
        public string CodeGuichet { get; set; }
        public string CodeBanque { get; set; }
        public string Domiciliation { get; set; }
        public string Dénomination { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
    
        public virtual Banque Banque { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Compte> Comptes { get; set; }
    }
}
