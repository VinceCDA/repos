using System;
using System.Collections.Generic;

#nullable disable

namespace LingToEntities.Models
{
    public partial class ShippersRate
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public int? NbOrders { get; set; }
        public decimal? Ratio { get; set; }
    }
}
