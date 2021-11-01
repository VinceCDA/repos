using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        

    }
}
