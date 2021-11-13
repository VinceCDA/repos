using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TestMvc.Core.Data.Models;

namespace EnergySport.Data.Models {

    public class Session {
        private string _publicCommentary;
        private string _privateCommentary;
        private List<Session_Participant_Member> participants;
        private List<Session_WaitingList_Member> _waitingList;
        private DateTime _sessionDate;
        private Location _location;
        private int _minParticipantsNumber;
        private int _maxParticipantsNumber;
        private int _waitingListMaxSize;
        [Key]
        public int SessionId { get; set; }
        public string PublicCommentary { get => _publicCommentary; set => _publicCommentary = value; }
        public string PrivateCommentary { get => _privateCommentary; set => _privateCommentary = value; }
        public List<Session_Participant_Member> Participants { get => participants; set => participants = value; }
        public List<Session_WaitingList_Member> WaitingList { get => _waitingList; set => _waitingList = value; }
        public DateTime SessionDate { get => _sessionDate; set => _sessionDate = value; }
        public Location Location { get => _location; set => _location = value; }
        public int MinParticipantsNumber { get => _minParticipantsNumber; set => _minParticipantsNumber = value; }
        public int MaxParticipantsNumber { get => _maxParticipantsNumber; set => _maxParticipantsNumber = value; }
        public int WaitingListMaxSize { get => _waitingListMaxSize; set => _waitingListMaxSize = value; }

        public Session() {
        }
    }
}