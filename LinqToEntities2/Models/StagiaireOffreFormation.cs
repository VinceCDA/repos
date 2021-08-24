using System;
using System.Collections.Generic;

#nullable disable

namespace LinqToEntities2.Models
{
    public partial class StagiaireOffreFormation
    {
        public int IdPersonne { get; set; }
        public int IdOffreFormation { get; set; }
        public string IdEtablissement { get; set; }
        public DateTime DateEntreeStagiaire { get; set; }
        public DateTime? DateSortieStagiaire { get; set; }

        public virtual OffreFormation Id { get; set; }
        public virtual Personne IdPersonneNavigation { get; set; }
    }
}
