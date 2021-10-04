using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class OffreFormation
    {
        public OffreFormation()
        {
            BeneficiaireOffreFormations = new HashSet<BeneficiaireOffreFormation>();
        }

        public int IdOffreFormation { get; set; }
        public string IdEtablissement { get; set; }
        public int? NumOffreGesPlan { get; set; }
        public string MatriculeCollaborateurAfpa { get; set; }
        public int CodeProduitFormation { get; set; }
        public string LibelleOffreFormation { get; set; }
        public string LibelleReduitOffreFormation { get; set; }
        public DateTime DateDebutOffreFormation { get; set; }
        public DateTime DateFinOffreFormation { get; set; }
        public int? IdLotAo { get; set; }

        public virtual ProduitFormation CodeProduitFormationNavigation { get; set; }
        public virtual Etablissement IdEtablissementNavigation { get; set; }
        public virtual ICollection<BeneficiaireOffreFormation> BeneficiaireOffreFormations { get; set; }
    }
}
