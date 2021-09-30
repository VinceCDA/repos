using System;
using System.Collections.Generic;

namespace NopCommerceBOL
{
    public partial class ProductCategoryMap
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PictureId { get; set; }
        public int Expr1 { get; set; }
        public int Expr2 { get; set; }
        public string Expr3 { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
        public int Expr4 { get; set; }
    }
}
