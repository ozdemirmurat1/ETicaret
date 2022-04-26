using Eticaret.Business.Services;
using Eticaret.PresentationEnSon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.ViewComponents
{
    public class ProductWidgetAreaViewComponent:ViewComponent
    {
        IProductService _productService;
        public ProductWidgetAreaViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            ProductWidgetAreaViewModel model = new ProductWidgetAreaViewModel();
            model.NewProducts = _productService.ProductWithImages().OrderByDescending(x => x.Id).Take(4).ToList();
            model.MostView = _productService.ProductWithImages().OrderByDescending(x => x.Counter).Take(4).ToList();
            return View(model);
        }
    }
}
