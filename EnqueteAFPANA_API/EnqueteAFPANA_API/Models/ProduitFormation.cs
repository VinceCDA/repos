using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class ProduitFormation
    {
        public ProduitFormation()
        {
            OffreFormations = new HashSet<OffreFormation>();
            ProduitFormationRomes = new HashSet<ProduitFormationRome>();
        }

        public int CodeProduitFormation { get; set; }
        public int? IdCartePedagogique { get; set; }
        public string NiveauFormation { get; set; }
        public string LibelleProduitFormation { get; set; }
        public string LibelleCourtFormation { get; set; }
        public bool FormationContinue { get; set; }
        public bool FormationDiplomante { get; set; }

        public virtual ICollection<OffreFormation> OffreFormations { get; set; }
        public virtual ICollection<ProduitFormationRome> ProduitFormationRomes { get; set; }
    }
}
