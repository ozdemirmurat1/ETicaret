using Eticaret.Business.Services;
using Eticaret.PresentationEnSon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public ShopController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index(string name,int? page)
        {
            var category = _categoryService.GetCategory(name);
            var products = _productService.GetCategoryProducts(category.Id, page);
            ShopViewModel model = new ShopViewModel()
            {
                Products=products,
                CurrentPage=page ?? 1,  // ?? page null ise 1 değerini CurrentPage e ata değilse page değerini ata
                TotalPage=_productService.TotalPage(category.Id),
                CategoryName=name              
            };
            return View(model);
        }
    }
}
