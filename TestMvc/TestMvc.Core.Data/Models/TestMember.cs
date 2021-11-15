using EnergySport.Data.Models;
using System;
using System.Collections.Generic;

namespace TestMvc.Data.Models
{

    public class TestMember
    {
        private string _name;
        private string _firstName;
        private DateTime _birthDay;
        private string _email;
        private string _mobilePhone;
        private string _landLinePhone;
        private string _postalMail;
        private Gender _gender;
        private List<Sub> _statusSub;
        private List<SubBooklet> _statusSubBooklet;
        private string _medicalCertificate;
        private DateTime _medicalCertificateStart;
        private DateTime _medicalCertificateEnd;
        private string _profilePicture;

        public string Name { get => _name; set => _name = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public DateTime BirthDay { get => _birthDay; set => _birthDay = value; }
        public string Email { get => _email; set => _email = value; }
        public string MobilePhone { get => _mobilePhone; set => _mobilePhone = value; }
        public string LandLinePhone { get => _landLinePhone; set => _landLinePhone = value; }
        public string PostalMail { get => _postalMail; set => _postalMail = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public List<Sub> StatusSub { get => _statusSub; set => _statusSub = value; }
        public List<SubBooklet> StatusSubBooklet { get => _statusSubBooklet; set => _statusSubBooklet = value; }
        public string MedicalCertificate { get => _medicalCertificate; set => _medicalCertificate = value; }
        public DateTime MedicalCertificateStart { get => _medicalCertificateStart; set => _medicalCertificateStart = value; }
        public DateTime MedicalCertificateEnd { get => _medicalCertificateEnd; set => _medicalCertificateEnd = value; }
        public string ProfilePicture { get => _profilePicture; set => _profilePicture = value; }



        public TestMember(string name, string firstName, DateTime birthDay, string email, string mobilePhone, string landLinePhone, string postalMail, Gender gender, List<Sub> statusSub, List<SubBooklet> statusSubBooklet, string medicalCertificate, DateTime medicalCertificateStart, DateTime medicalCertificateEnd, string profilePicture)
        {
            _name = name;
            _firstName = firstName;
            _birthDay = birthDay;
            _email = email;
            _mobilePhone = mobilePhone;
            _landLinePhone = landLinePhone;
            _postalMail = postalMail;
            _gender = gender;
            _statusSub = statusSub;
            _statusSubBooklet = statusSubBooklet;
            _medicalCertificate = medicalCertificate;
            _medicalCertificateStart = medicalCertificateStart;
            _medicalCertificateEnd = medicalCertificateEnd;
            _profilePicture = profilePicture;
        }
    }
}
