using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
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
