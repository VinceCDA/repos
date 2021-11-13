using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class Subscription {
        private string _label;
        private string _description;
        private List<Category> _categories;
        private TimeSpan _length;
        [Key]
        public int Id { get; set; }
        public string Label { get => _label; set => _label = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Category> Categories { get => _categories; set => _categories = value; }
        public TimeSpan Length { get => _length; set => _length = value; }

        public Subscription() {
        }
    }
}