using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPA.BOL
{
    public sealed class AdresseMetaData
    {
        [Display(Name = "Adresse_ComplementIdentification_Name",
                ResourceType = typeof(Annotations))]
        public string ComplementIdentification;
        [Display(Name = "Adresse_NumeroNomVoie_Name",
               ResourceType = typeof(Annotations))]
        public string NumeroNomVoie;
        [Display(Name = "Adresse_ComplementAdresse_Name",
               ResourceType = typeof(Annotations))]
        public string ComplementAdresse;
        [Display(Name = "Adresse_CodePostal_Name",
              ResourceType = typeof(Annotations))]
        [RegularExpression(@"^[0-9]{5}$",
            ErrorMessageResourceName = "CodePostal_FR",
            ErrorMessageResourceType = typeof(Annotations))]
        public string CodePostal;
        [Display(Name = "Adresse_Ville_Name",
              ResourceType = typeof(Annotations))]
        [StringLength(60, MinimumLength = 2,
            ErrorMessageResourceName = "StringLength",
            ErrorMessageResourceType = typeof(Annotations))]
        public string Ville;
    }

    public sealed class EtablissementMetaData
    {
        [Display(Name = "Etablissement_Designation_Name",
            ShortName = "Etablissement_Designation_ShortName",
            Description = "Etablissement_Designation_ShortName",
            ResourceType = typeof(Annotations))]
        [Required(ErrorMessageResourceName = "Required",
            ErrorMessageResourceType = typeof(Annotations))]
        [StringLength(60, MinimumLength = 3,
            ErrorMessageResourceName = "StringLength",
            ErrorMessageResourceType = typeof(Annotations))]

        [RegularExpression(@"^[A-Z]{1}[a-z]{1,}$",
            ErrorMessage = "Le {0} doit commencer par un caractère en majuscule suivis de minuscules !")]
        public string DesignationEtablissement;
    }
    public sealed class OffreFormationMetaData
    {

        [Display(Name = "Code Offre")]
        [Required(ErrorMessage = "L'identifiant de la formation est requis")]
        public int IdOffreFormation { get; set; }

        [Display(Name = "Identifiant collaborateur AFPA",
            Description = "Identifiant du collaborateur AFPA",
            ShortName = "Collaborateur")]

        public int? IdPersonne { get; set; }

        [Display(Name = "Code produit",
        Description = "Produit de formation",
            ShortName = "Produit")]
        [Required(ErrorMessage = "Le code du produit est requis")]
        public string IdProduitFormation { get; set; }

        [Display(Name = "Code Etablissement",
        Description = "Code de l'établissement",
            ShortName = "Etablissement")]
        [StringLength(05, ErrorMessage = "Longueur invalide")]
        [Required(ErrorMessage = "L'identifiant de l'etablissement est requis")]
        public string IdEtablissement { get; set; }

        [Display(Name = "Date de début de la formation", ShortName = "Début le")]
        [Required(ErrorMessage = "La date de début de formation est requise")]

        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime DateDebutOffreFormation { get; set; }

        [Display(Name = "Date de fin de la formation", ShortName = "Fin le")]
        [Required(ErrorMessage = "La date de fin de formation est requise")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime DateFinOffreFormation { get; set; }
        
    }
    public sealed class StagiaireMetaData
    {
        [Display(Name = "Matricule stagiaire", Description = "Matricule du stagiaire", ShortName = "Matricule")]
        [StringLength(8, ErrorMessage = "Longueur invalide")]
        [Required(ErrorMessage = "Le matricule est requis")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Ne doit comporter que des chiffres")]
        public string MatriculeStagiaire;
    }
    public sealed class EntrepriseMetaData
    {
       
        [Required(ErrorMessageResourceName = "Required",
            ErrorMessageResourceType = typeof(Annotations))]
        [Display(Name = "Entreprise_NumeroSIRET_Name",
            ShortName = "Entreprise_NumeroSIRET_ShortName",
            Description = "Entreprise_NumeroSIRET_Description",
            ResourceType = typeof(Annotations))]
       
        public string NumeroSIRET;
        [StringLength(60, MinimumLength = 3,
          ErrorMessageResourceName = "StringLength",
          ErrorMessageResourceType = typeof(Annotations))]
        [Required(ErrorMessageResourceName = "Required",
            ErrorMessageResourceType = typeof(Annotations))]
        [Display(Name = "Entreprise_RaisonSociale_Name",
            ShortName = "Entreprise_RaisonSociale_ShortName",
            Description = "Entreprise_RaisonSociale_Description",
            ResourceType = typeof(Annotations))]
        public string RaisonSociale;
    }
}