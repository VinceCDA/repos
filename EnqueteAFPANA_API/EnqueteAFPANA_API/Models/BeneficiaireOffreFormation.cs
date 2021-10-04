using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class BeneficiaireOffreFormation
    {
        public string MatriculeBeneficiaire { get; set; }
        public int IdOffreFormation { get; set; }
        public string Idetablissement { get; set; }
        public DateTime DateEntreeBeneficiaire { get; set; }
        public DateTime? DateSortieBeneficiaire { get; set; }

        public virtual OffreFormation Id { get; set; }
        public virtual Beneficiaire MatriculeBeneficiaireNavigation { get; set; }
    }
}
