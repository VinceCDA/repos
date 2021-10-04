using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class VueSoumissionnaire
    {
        public Guid IdentifiantMailing { get; set; }
        public string MatriculeBeneficiaire { get; set; }
        public string TitreCiviliteComplet { get; set; }
        public string NomBeneficiaire { get; set; }
        public string PrenomBeneficiaire { get; set; }
        public string LibelleOffreFormation { get; set; }
        public DateTime? DateSortieBeneficiaire { get; set; }
        public string NomEtablissement { get; set; }
        public string LibelleQuestionnaire { get; set; }
        public DateTime DateEntreeBeneficiaire { get; set; }
    }
}
