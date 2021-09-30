using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NOPAPIRest.ModelViews
{
    public class ProductAbr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int PictureId { get; set; }
        public decimal Price { get; set; }
        public int DisplayOrder { get; set; }
    }
}
