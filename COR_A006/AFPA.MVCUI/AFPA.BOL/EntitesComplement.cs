using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AFPA.BOL
{
    #region Adresse
    [MetadataType(typeof(AdresseMetaData))]
    public partial class Adresse
    {

        public override bool Equals(object obj)
        {
            Adresse adresse = obj as Adresse;
            return (adresse == null
                ? false
                :
                adresse.ComplementIdentification == this.ComplementIdentification
                && adresse.NumeroNomVoie == this.NumeroNomVoie
                && adresse.ComplementAdresse == this.ComplementAdresse
                && adresse.CodePostal == this.CodePostal
                && adresse.Ville == this.Ville
                );
        }
        public override int GetHashCode()
        {
            return (this.CodePostal == null || this.CodePostal == string.Empty
                ? 0
                : string.Format("{0}{1}{2}{3}{4}",
                ComplementIdentification, NumeroNomVoie, ComplementAdresse, CodePostal, Ville).GetHashCode());
        }
    }
    #endregion
    #region Entreprise
    [MetadataType(typeof(EntrepriseMetaData))]
    public partial class Entreprise : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
        public override bool Equals(object obj)
        {
            Entreprise entreprise = obj as Entreprise;
            return (entreprise == null ? false : entreprise.IdEntreprise == this.IdEntreprise);
        }
        public override int GetHashCode()
        {
            return (this.IdEntreprise == null ? 0 : this.IdEntreprise.GetHashCode());
        }
    }
    #endregion
    #region Etablissement
    [MetadataType(typeof(EtablissementMetaData))]
    public partial class Etablissement : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }


    }
    #endregion

    #region Personne
    public partial class Personne : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
    }
    #endregion


    #region OffreFormation
    [MetadataType(typeof(OffreFormationMetaData))]
    public partial class OffreFormation : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
        public override bool Equals(object obj)
        {
            OffreFormation offreFormation = obj as OffreFormation;
            return (offreFormation == null
                ? false
                : (offreFormation.IdOffreFormation == this.IdOffreFormation && offreFormation.IdEtablissement == this.IdEtablissement));
        }
        public override int GetHashCode()
        {
            return (this.IdOffreFormation == 0 || this.IdEtablissement == null
                ? 0
                : string.Format("{0}{1}", IdOffreFormation, IdEtablissement).GetHashCode());
        }
    }
    #endregion
    public partial class Pee : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
    }
    public partial class Periode_Pee : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
    }
    public partial class ProduitDeFormation : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
    }
    #region Stagiaire
    [MetadataType(typeof(StagiaireMetaData))]
    public partial class Stagiaire
    {
        public int Age
        {
            get
            {
                if (this.DateNaissanceStagiaire == DateTime.MinValue) { return 0; }
                if (DateTime.Now.DayOfYear >= this.DateNaissanceStagiaire.DayOfYear)
                    return DateTime.Now.Year - this.DateNaissanceStagiaire.Year + 1;
                else
                    return DateTime.Now.Year - this.DateNaissanceStagiaire.Year;
            }
        }
        public override bool Equals(object obj)
        {
            Stagiaire stagiaire = obj as Stagiaire;
            return (stagiaire == null ? false : stagiaire.MatriculeStagiaire == this.MatriculeStagiaire);
        }
        public override int GetHashCode()
        {
            return (this.MatriculeStagiaire == null ? 0 : this.MatriculeStagiaire.GetHashCode());
        }
    }

    #endregion
    public partial class Stagiaire_OffreFormation : IEntityPOCOState
    {

        private EntityPOCOState _etat = EntityPOCOState.Unchanged;
        public EntityPOCOState Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }
    }
}
