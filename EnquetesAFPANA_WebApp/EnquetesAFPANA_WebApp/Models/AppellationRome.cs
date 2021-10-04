using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class AppellationRome
    {
        public AppellationRome()
        {
            ExercerFonctions = new HashSet<ExercerFonction>();
        }

        public int CodeAppellationRome { get; set; }
        public string LibelleAppellationRome { get; set; }
        public string CodeRome { get; set; }

        public virtual Rome CodeRomeNavigation { get; set; }
        public virtual ICollection<ExercerFonction> ExercerFonctions { get; set; }
    }
}
