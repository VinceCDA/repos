﻿using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class Beneficiaire
    {
        public Beneficiaire()
        {
            BeneficiaireOffreFormations = new HashSet<BeneficiaireOffreFormation>();
        }

        public string MatriculeBeneficiaire { get; set; }
        public int CodeTitreCivilite { get; set; }
        public string NomBeneficiaire { get; set; }
        public string PrenomBeneficiaire { get; set; }
        public DateTime? DateNaissanceBeneficiaire { get; set; }
        public string MailBeneficiaire { get; set; }
        public string TelBeneficiaire { get; set; }
        public string Ligne1Adresse { get; set; }
        public string Ligne2Adresse { get; set; }
        public string Ligne3Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string UserId { get; set; }
        public string IdPays2 { get; set; }
        public string PathPhoto { get; set; }

        public virtual TitreCivilite CodeTitreCiviliteNavigation { get; set; }
        public virtual ICollection<BeneficiaireOffreFormation> BeneficiaireOffreFormations { get; set; }
    }
}
