using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class DureeContrat
    {
        public DureeContrat()
        {
            ExercerFonctions = new HashSet<ExercerFonction>();
        }

        public string IdDureeContrat { get; set; }
        public string LibelleDureeContrat { get; set; }

        public virtual ICollection<ExercerFonction> ExercerFonctions { get; set; }
    }
}
