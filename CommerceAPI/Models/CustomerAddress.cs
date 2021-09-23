using System;
using System.Collections.Generic;

#nullable disable

namespace CommerceAPI.Models
{
    public partial class CustomerAddress
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
