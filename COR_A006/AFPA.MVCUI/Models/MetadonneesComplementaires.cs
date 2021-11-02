using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AFPA.MVCUI.Models
{
    public sealed class OffreFormationMetaDataEX
    {
        [DateInferieureA(DateReference = "DateFinOffreFormation",
         ErrorMessage = "La date communiquée n'est pas correcte")]
        public System.DateTime DateDebutOffreFormation { get; set; }
    }
    public sealed class EntrepriseMetaDataEX
    {
        [SiretValidation(ErrorMessage = "Le numéro de SIRET n'est pas conforme")]
        public System.DateTime NumeroSIRET { get; set; }
    }
}