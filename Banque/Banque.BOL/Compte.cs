//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banque.BOL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;

    public partial class Compte : CompteBase
    { 
       
        #region Propriétés
        public string CodeTypeCompte { get; set; }
        public string IBAN { get; set; }
        public Nullable<decimal> Solde { get; set; }
        public virtual TypeCompte TypeCompte { get; set; }
        #endregion



    }
}