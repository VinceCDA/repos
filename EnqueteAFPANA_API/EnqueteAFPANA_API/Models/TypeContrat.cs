using System;
using System.Collections.Generic;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class TypeContrat
    {
        public TypeContrat()
        {
            ExercerFonctions = new HashSet<ExercerFonction>();
        }

        public int IdtypeContrat { get; set; }
        public string LibelleTypeContrat { get; set; }

        public virtual ICollection<ExercerFonction> ExercerFonctions { get; set; }
    }
}
