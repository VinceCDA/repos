using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class SubBooklet {
        private DateTime _dateStart;
        private Booklet _booklet;
        private int? _sessionNumber;
        private Member _member;
        [Key]
        public int Id { get; set; }
        public DateTime DateStart { get => _dateStart; set => _dateStart = value; }
        public Booklet Booklet { get => _booklet; set => _booklet = value; }
        public int? SessionNumber { get => _sessionNumber; set => _sessionNumber = value; }
        //public Member Member { get => _member; set => _member = value; }
        public Member Member { get; set; }

        public SubBooklet() {
        }
    }
}