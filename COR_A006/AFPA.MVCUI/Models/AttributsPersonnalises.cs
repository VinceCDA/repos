using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Web.Mvc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPA.MVCUI.Models
{
    /// <summary>
    /// Attribut de vérification de l'antériorité d'une date / date de référence
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true,
        Inherited = false)]
    public class DateInferieureAAttribute : ValidationAttribute, IClientValidatable
    {
        string _dateReference;

        public string DateReference
        {
            get { return _dateReference; }
            set { _dateReference = value; }
        }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            DateTime? valeur = value as DateTime?;
            if (value == null) return ValidationResult.Success;

            PropertyInfo proprieteDate = validationContext.ObjectType.GetProperty(_dateReference);
            DateTime? valeurDate = proprieteDate.GetValue(validationContext.ObjectInstance) as DateTime?;

            if (valeurDate == null || valeur.Value >= valeurDate.Value)
            { return new ValidationResult(ErrorMessage); }

            return ValidationResult.Success;

        }

        public IEnumerable<ModelClientValidationRule>
            GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            {
                List<ModelClientValidationRule> regles = new List<ModelClientValidationRule>();
                ModelClientValidationRule regle = new ModelClientValidationRule();
                regle.ErrorMessage = ErrorMessageString;
                regle.ValidationType = "dateinferieurea";
                regle.ValidationParameters.Add("dateverif", this.GetType().Name);
                regle.ValidationParameters.Add("datereference", this.DateReference);
                regles.Add(regle);
                return regles;
            }
        }
    }
    /// <summary>
    /// Vérification d'un SIRET.
    ///
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class SiretValidation : ValidationAttribute, IClientValidatable
    {
        public override string FormatErrorMessage(string name)
        {
            return string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name);
        }
        public override bool IsValid(object value)
        {
            if (value == null || value.ToString() == string.Empty)
            { return true; }

            string siret = value as string;
            if (siret.Trim().Length != 14 || !Luhn.IsLuhnValide(siret))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Méthode permettant de faire la validation client-side
        /// Permet de fournir les paramêtres utilisés ensuite par le Js sur la page web.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public System.Collections.Generic.IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule()
            {
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
                ValidationType = "siretvalidation"
            };
            yield return rule;
        }
    }
    internal class Luhn
    {
        /// <summary>
        /// Vérification de la formule de Luhn
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns></returns>
        internal static bool IsLuhnValide(string valeur)
        {
            int chiffre;
            int somme = 0;
            int impair = valeur.Length & 1;
           
            for (int i = 0; i < valeur.Length; i++)
            {
                chiffre = int.Parse(valeur[i].ToString()) * (2 - (i+impair) % 2);
                somme += chiffre >9 ? chiffre - 9 : chiffre;
            }
            return (somme % 10 == 0);
        }
    }
}