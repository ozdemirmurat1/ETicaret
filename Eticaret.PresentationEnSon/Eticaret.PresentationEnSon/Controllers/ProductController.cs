using Eticaret.Business.Services;
using Eticaret.PresentationEnSon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        IProductImageService _productImageService;

        public ProductController(IProductService productService, IProductImageService productImageService)
        {
            _productService = productService;
            _productImageService = productImageService;
        }

        public IActionResult Index(string name)
        {
            var product = _productService.Get(name);
            
            if (product == null) return RedirectToRoute("default");

            var images = _productImageService.GetImages(product.Id); // ürün resimlerini getirir.

            ProductViewModel model = new ProductViewModel
            {
                ProductDetail=product,
                Images=images                
            };

            _productService.CountUp(product);
            return View(model);
        }
    }
}
