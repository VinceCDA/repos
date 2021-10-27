using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    public class Paragraphe
    {
        public int Id { get; set; } 
        public int Numero { get; set; } 
        public string Titre { get; set; }  
        public string Description { get; set; } 
        public Question maQuestion { get; set; }  
    }
}
