

namespace Banque.BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banque
    {
        
        public Banque()
        {
            this.Guichet = new HashSet<Guichet>();
        }
    
        public string CodeBanque { get; set; }
        public string RaisonSociale { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string BIC { get; set; }
    
      
        public virtual ICollection<Guichet> Guichet { get; set; }
    }
}
