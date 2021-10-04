using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
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
