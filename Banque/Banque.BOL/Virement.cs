
namespace Banque.BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Virement
    {
        public Compte CompteEmetteur { get; set; }
        public CompteBase CompteDestinataire { get; set; }
        public int IdVirement { get; set; }
        
        public System.DateTime DatePassationOrdre { get; set; }
        public decimal MontantVirement { get; set; }
        public string OrigineVirement { get; set; }
        public string MotifVirement { get; set; }
       
        public string LibelléBeneficiaire { get; set; }
        public string IBANBeneficiaire { get; set; }
        public string BICBeneficiaire { get; set; }
        public string PaysBeneficiaire { get; set; }
        public string BanqueBeneficiaire { get; set; }
        public string NomBeneficiaire { get; set; }
        public Nullable<System.DateTime> DateExecutionOrdre { get; set; }
        public Nullable<System.DateTime> DatePrelevement { get; set; }
        public string CodeExecution { get; set; }
        public Nullable<decimal> CoutVirement { get; set; }
        public virtual Operation Operation { get; set; }
    }
}
