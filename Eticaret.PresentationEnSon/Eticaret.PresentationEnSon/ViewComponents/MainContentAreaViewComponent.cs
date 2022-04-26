using Eticaret.Business.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.ViewComponents
{
    public class MainContentAreaViewComponent:ViewComponent
    {
        private readonly IProductService _productService;
        public MainContentAreaViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productService.ProductWithImages();
            return View(products);
        }
    }
}
