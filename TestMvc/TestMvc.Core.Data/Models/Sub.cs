using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class Sub {
        private DateTime _dateStart;
        private Subscription _subscription;
        private Member _member;
        [Key]
        public int Id { get; set; }
        public DateTime DateStart { get => _dateStart; set => _dateStart = value; }
        public Subscription Subscription { get => _subscription; set => _subscription = value; }
        //public Member Member { get => _member; set => _member = value; }
        public Member Member { get; set; }

        public Sub() {
        }
    }
}