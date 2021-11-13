using EnergySport.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMvc.Core.Data.Models
{
    public class Session_Participant_Member
    {
        
        public int MemberId { get; set; }
        
        public int SessionId { get; set; }
        public Member Member { get; set; }
        public Session Session { get; set; }
    }
}
