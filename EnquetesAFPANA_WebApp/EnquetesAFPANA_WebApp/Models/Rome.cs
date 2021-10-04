using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class Rome
    {
        public Rome()
        {
            AppellationRomes = new HashSet<AppellationRome>();
            ProduitFormationRomes = new HashSet<ProduitFormationRome>();
        }

        public string CodeRome { get; set; }
        public string IntituleCodeRome { get; set; }
        public string CodeDomaineRome { get; set; }

        public virtual DomaineMetierRome CodeDomaineRomeNavigation { get; set; }
        public virtual ICollection<AppellationRome> AppellationRomes { get; set; }
        public virtual ICollection<ProduitFormationRome> ProduitFormationRomes { get; set; }
    }
}
