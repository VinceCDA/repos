using System;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class Coach {
        private string _name;
        private string _firstName;
        private string _profilePicture;
        private string _nickName;
        [Key]
        public int Id { get; set; }
        public string Name { get => _name; set => _name = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string ProfilePicture { get => _profilePicture; set => _profilePicture = value; }
        public string NickName { get => _nickName; set => _nickName = value; }

        public Coach() {
        }
    }
}