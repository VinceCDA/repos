using Microsoft.AspNetCore.Identity;

namespace TestIdentity.Models
{
    public class Member : IdentityUser
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string LandLinePhone { get; set; }
        public string PostalMail { get; set; }


        public DateTime MedicalCertificateStart { get; set; }
        public DateTime MedicalCertificateEnd { get; set; }
        public string ProfilePicture { get; set; }

    }
}
