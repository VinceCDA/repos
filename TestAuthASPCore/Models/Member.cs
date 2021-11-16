using Microsoft.AspNetCore.Identity;

namespace TestAuthASPCore.Models
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
        //public Gender Gender { get => _gender; set => _gender = value; }
        //public List<Sub> StatusSub { get => _statusSub; set => _statusSub = value; }
        //public List<SubBooklet> StatusSubBooklet { get => _statusSubBooklet; set => _statusSubBooklet = value; }
        //public string MedicalCertificate { get => _medicalCertificate; set => _medicalCertificate = value; }
        public DateTime MedicalCertificateStart { get; set; }
        //public DateTime MedicalCertificateEnd { get => _medicalCertificateEnd; set => _medicalCertificateEnd = value; }
        //public string ProfilePicture { get => _profilePicture; set => _profilePicture = value; }
        //public virtual ICollection<Sub> Subs { get; set; }
        //public virtual ICollection<SubBooklet> SubBooklets { get; set; }
        //public List<Session_Participant_Member> Participants { get; set; }
        //public List<Session_WaitingList_Member> WaitingList { get; set; }
    }
}
