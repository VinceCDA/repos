using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class Soumissionnaire
    {
        public Soumissionnaire()
        {
            ExercerFonctions = new HashSet<ExercerFonction>();
        }

        public Guid IdentifiantMailing { get; set; }
        public string MatriculeBeneficiaire { get; set; }
        public int IdQuestionnaire { get; set; }
        public bool? ReponseEmploi { get; set; }
        public DateTime? DateEnregistrementReponse { get; set; }

        public virtual Questionnaire IdQuestionnaireNavigation { get; set; }
        public virtual ICollection<ExercerFonction> ExercerFonctions { get; set; }
    }
}
