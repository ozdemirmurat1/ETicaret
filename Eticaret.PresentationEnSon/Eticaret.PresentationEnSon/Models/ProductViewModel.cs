using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Models
{
    public class ProductViewModel
    {
        public Product ProductDetail { get; set; }

        public List<ProductImage> Images { get; set; }
    }
}
