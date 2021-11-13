using System;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class Activity {
        private string _code;
        private string _label;
        private string _color;
        private int _length;
        private DateTime? _startRegisterDate;
        private DateTime? _endRegisterDate;
        private int? _maxRegisterNumberByClient;
        private TimeSpan _endUnregisterDate;
        [Key]
        public string Code { get => _code; set => _code = value; }
        public string Label { get => _label; set => _label = value; }
        public string Color { get => _color; set => _color = value; }
        public int Length { get => _length; set => _length = value; }
        public DateTime? StartRegisterDate { get => _startRegisterDate; set => _startRegisterDate = value; }
        public DateTime? EndRegisterDate { get => _endRegisterDate; set => _endRegisterDate = value; }
        public int? MaxRegisterNumberByClient { get => _maxRegisterNumberByClient; set => _maxRegisterNumberByClient = value; }
        public TimeSpan EndUnregisterDate { get => _endUnregisterDate; set => _endUnregisterDate = value; }

        public Activity() {
        }
    }
}