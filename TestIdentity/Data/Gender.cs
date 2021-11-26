using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TestIdentity.Data
{
    public enum Gender
    {
        [Display(Name ="Homme")]
        MALE,
        [Display(Name ="Femme")]
        FEMALE,
        [Display(Name = "Autre")]
        OTHER

    }
    public static class EnumExtensions
    {
        public static string? GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()?
                    .GetMember(enumValue.ToString())?
                    .First()?
                    .GetCustomAttribute<DisplayAttribute>()?
                    .Name;
        }
    }

}
