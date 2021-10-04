using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class TitreCivilite
    {
        public TitreCivilite()
        {
            Beneficiaires = new HashSet<Beneficiaire>();
        }

        public int CodeTitreCivilite { get; set; }
        public string TitreCiviliteAbrege { get; set; }
        public string TitreCiviliteComplet { get; set; }

        public virtual ICollection<Beneficiaire> Beneficiaires { get; set; }
    }
}
