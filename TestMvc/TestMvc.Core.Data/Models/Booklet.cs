using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class Booklet {
        private int _sessionQty;
        private string _label;
        private string _description;
        private List<Category> _categories;
        private TimeSpan _length;
        [Key]
        public int Id { get; set; }
        public int SessionQty { get => _sessionQty; set => _sessionQty = value; }
        public string Label { get => _label; set => _label = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Category> Categories { get => _categories; set => _categories = value; }
        public TimeSpan Length { get => _length; set => _length = value; }

        public Booklet() {
        }
    }
}