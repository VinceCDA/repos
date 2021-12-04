using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage ="Numero requis")]
        [Range(1,999,ErrorMessage ="Doit etre entre 1 et 999")]
        public int Numero { get; set; } 
        [Required(AllowEmptyStrings =false,ErrorMessage ="Titre est requis")]

        public string Titre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Description est requise")]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateOnly? DateCreated { get; set; }
        [DataType(DataType.Date)]
        public DateOnly? DateTimeUpdated { get; set; }
        public Question QuestionId { get; set; }  
    }
}
