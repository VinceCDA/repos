using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergySport.Data.Models {

    public class Category {
        private List<Activity> _activities;
        [Key]
        public int Id { get; set; }
        public List<Activity> Activities { get => _activities; set => _activities = value; }

        public Category() {
        }
    }
}