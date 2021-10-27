using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Titre { get; set; }    
        public List<Reponse> Reponses { get; set; } 
    }
}
