using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class ExercerFonction
    {
        public int IdExercerFonction { get; set; }
        public int IdtypeContrat { get; set; }
        public int CodeAppellationRome { get; set; }
        public Guid IdentifiantMailing { get; set; }
        public string DureeContrat { get; set; }
        public DateTime DateEntreeFonction { get; set; }
        public DateTime? DateSortieFonction { get; set; }
        public DateTime DateReponse { get; set; }

        public virtual AppellationRome CodeAppellationRomeNavigation { get; set; }
        public virtual DureeContrat DureeContratNavigation { get; set; }
        public virtual Soumissionnaire IdentifiantMailingNavigation { get; set; }
        public virtual TypeContrat IdtypeContratNavigation { get; set; }
    }
}
