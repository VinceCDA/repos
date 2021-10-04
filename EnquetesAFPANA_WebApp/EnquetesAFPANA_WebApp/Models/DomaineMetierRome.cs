﻿using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class DomaineMetierRome
    {
        public DomaineMetierRome()
        {
            Romes = new HashSet<Rome>();
        }

        public string CodeDomaineRome { get; set; }
        public string IntituleDomaineRome { get; set; }
        public string CodeFamilleRome { get; set; }

        public virtual FamilleMetierRome CodeFamilleRomeNavigation { get; set; }
        public virtual ICollection<Rome> Romes { get; set; }
    }
}
