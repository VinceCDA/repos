using System;
using System.Collections.Generic;



namespace EnquetesAFPANA_WebApp.Models
{
    public partial class Questionnaire
    {
        public Questionnaire()
        {
            Soumissionnaires = new HashSet<Soumissionnaire>();
        }

        public int IdQuestionnaire { get; set; }
        public string LibelleQuestionnaire { get; set; }
        public int IdOffre { get; set; }
        public int IdProduit { get; set; }
        public string IdEtablissement { get; set; }
        public string DesignationProduit { get; set; }
        public DateTime DateEnquete { get; set; }
        public string Commentaires { get; set; }

        public virtual ICollection<Soumissionnaire> Soumissionnaires { get; set; }
    }
}
