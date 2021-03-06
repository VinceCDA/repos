using System;
using System.Collections.Generic;

#nullable disable

namespace LinqToEntities2.Models
{
    public partial class OffreFormation
    {
        public OffreFormation()
        {
            StagiaireOffreFormations = new HashSet<StagiaireOffreFormation>();
        }

        public int IdOffreFormation { get; set; }
        public string IdEtablissement { get; set; }
        public DateTime DateDebutOffreFormation { get; set; }
        public DateTime DateFinOffreFormation { get; set; }
        public int? IdPersonne { get; set; }
        public string IdProduitFormation { get; set; }

        public virtual Etablissement IdEtablissementNavigation { get; set; }
        public virtual Personne IdPersonneNavigation { get; set; }
        public virtual ProduitDeFormation IdProduitFormationNavigation { get; set; }
        public virtual ICollection<StagiaireOffreFormation> StagiaireOffreFormations { get; set; }
    }
}
