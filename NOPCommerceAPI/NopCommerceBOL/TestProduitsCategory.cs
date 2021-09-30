using System;
using System.Collections.Generic;

#nullable disable

namespace NopCommerceBOL
{
    public partial class TestProduitsCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
    }
}
