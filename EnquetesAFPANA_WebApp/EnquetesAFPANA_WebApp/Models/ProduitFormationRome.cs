﻿using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class ProduitFormationRome
    {
        public int CodeProduitFormation { get; set; }
        public string CodeRome { get; set; }

        public virtual ProduitFormation CodeProduitFormationNavigation { get; set; }
        public virtual Rome CodeRomeNavigation { get; set; }
    }
}
