using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestIdentity.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public IdentityUser User { get; set; }
        //public DateTime BirthDay { get; set; }
        //public string Email { get; set; }
        //public string MobilePhone { get; set; }
        //public string LandLinePhone { get; set; }
        //public string PostalMail { get; set; }


        //public DateTime MedicalCertificateStart { get; set; }
        //public DateTime MedicalCertificateEnd { get; set; }
        //public string ProfilePicture { get; set; }

    }
}
