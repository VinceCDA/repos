using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class Course {
        private Coach _coach;
        private Activity _activity;
        private Frequency _frequency;
        private string _publicCommentary;
        private string _privateCommentary;
        private List<Session> _sessions;
        private DateTime? _firstSessionDate;
        private DateTime? _lastSessionDate;
        private int _minParticipantsNumber;
        private int _maxParticipantsNumber;
        private int _waitingListMaxSize;
        [Key]
        public int Id { get; set; }
        public Coach Coach { get => _coach; set => _coach = value; }
        public Activity Activity { get => _activity; set => _activity = value; }
        public Frequency Frequency { get => _frequency; set => _frequency = value; }
        public string PublicCommentary { get => _publicCommentary; set => _publicCommentary = value; }
        public string PrivateCommentary { get => _privateCommentary; set => _privateCommentary = value; }
        public List<Session> Sessions { get => _sessions; set => _sessions = value; }
        public DateTime? FirstSessionDate { get => _firstSessionDate; set => _firstSessionDate = value; }
        public DateTime? LastSessionDate { get => _lastSessionDate; set => _lastSessionDate = value; }
        public int MinParticipantsNumber { get => _minParticipantsNumber; set => _minParticipantsNumber = value; }
        public int MaxParticipantsNumber { get => _maxParticipantsNumber; set => _maxParticipantsNumber = value; }
        public int WaitingListMaxSize { get => _waitingListMaxSize; set => _waitingListMaxSize = value; }

        public Course() {
        }
    }
}