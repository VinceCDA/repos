using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; } 
        public int ParagrapheId { get; set; }
        public List<Reponse> Reponses { get; set; } 
    }
}
