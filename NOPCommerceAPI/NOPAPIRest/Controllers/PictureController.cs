using Microsoft.AspNetCore.Mvc;
using NopCommerceBOL;
using NopCommerceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NOPAPIRest.Controllers
{
    public class PictureController : Controller
    {
        private readonly ECommerceSimplifieContext _context;

        public PictureController(ECommerceSimplifieContext context)
        {
            _context = context;
        }
        [Route("api/picture/GetPicture/{id}")]
        [HttpGet]
        public IActionResult GetPicture(int id)
        {
            Picture picture = _context.Pictures.Find(id);
            return File(picture.PictureBinary, picture.MimeType);
        }
        [Route("api/picture/GetProductPicture/{productId}/{displayOrder}")]
        [HttpGet]
        public IActionResult GetProductPicture(int productId,int displayOrder)
        {
            Picture picture = _context.
                ProductPictureMappings.
                Where(ppm => (ppm.DisplayOrder == displayOrder && ppm.ProductId == productId))
                .Select(ppm => ppm.Picture).FirstOrDefault();
            return File(picture.PictureBinary, picture.MimeType);
        }
    }
}
