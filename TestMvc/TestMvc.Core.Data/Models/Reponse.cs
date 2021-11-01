using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    [Table("Reponse")]
    public class Reponse
    {
        [Key]
        public int Id
        {
            get; set;
        }   
        public string Description
        {
            get; set;
        }
        public int QuestionId
        {
            get; set;
        }
        public int ParagrapheId
        {
            get; set;
        }
    }
}
