using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Models
{
    public class ProductWidgetAreaViewModel
    {
        public List<ProductImagesCustomModel> NewProducts { get; set; }

        public List<ProductImagesCustomModel> MostView { get; set; }
    }
}
