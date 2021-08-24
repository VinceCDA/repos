
namespace Banque.BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeCompte
    {
        public string CodeTypeCompte { get; set; }
        public string DésignationTypeCompte { get; set; }
        public bool EmissionVirementInterne { get; set; }
        public bool EmissionVirementExterne { get; set; }
    }
}
