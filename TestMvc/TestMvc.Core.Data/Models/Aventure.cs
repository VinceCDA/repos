using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    [Table("Aventures")]
    public class Aventure
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        

    }
}
