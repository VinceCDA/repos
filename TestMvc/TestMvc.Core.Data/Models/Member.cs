using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TestMvc.Core.Data.Models;

namespace EnergySport.Data.Models {

    public class Member {
        private string _name;
        private string _firstName;
        private DateTime _birthDay;
        private string _email;
        private string _mobilePhone;
        private string _landLinePhone;
        private string _postalMail;
        private Gender _gender;
        //private List<Sub> _statusSub;
        //private List<SubBooklet> _statusSubBooklet;
        private string _medicalCertificate;
        private DateTime _medicalCertificateStart;
        private DateTime _medicalCertificateEnd;
        private string _profilePicture;
        [Key]
        public int MemberId { get; set; }
        public string Name { get => _name; set => _name = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public DateTime BirthDay { get => _birthDay; set => _birthDay = value; }
        public string Email { get => _email; set => _email = value; }
        public string MobilePhone { get => _mobilePhone; set => _mobilePhone = value; }
        public string LandLinePhone { get => _landLinePhone; set => _landLinePhone = value; }
        public string PostalMail { get => _postalMail; set => _postalMail = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        //public List<Sub> StatusSub { get => _statusSub; set => _statusSub = value; }
        //public List<SubBooklet> StatusSubBooklet { get => _statusSubBooklet; set => _statusSubBooklet = value; }
        public string MedicalCertificate { get => _medicalCertificate; set => _medicalCertificate = value; }
        public DateTime MedicalCertificateStart { get => _medicalCertificateStart; set => _medicalCertificateStart = value; }
        public DateTime MedicalCertificateEnd { get => _medicalCertificateEnd; set => _medicalCertificateEnd = value; }
        public string ProfilePicture { get => _profilePicture; set => _profilePicture = value; }
        public virtual ICollection<Sub> Subs { get; set; }
        public virtual ICollection<SubBooklet> SubBooklets { get; set; }
        public List<Session_Participant_Member> Participants { get; set; }
        public List<Session_WaitingList_Member> WaitingList { get; set; }

        public Member() {
            this.Subs = new HashSet<Sub>();
            this.SubBooklets = new HashSet<SubBooklet>();
        }
    }
}