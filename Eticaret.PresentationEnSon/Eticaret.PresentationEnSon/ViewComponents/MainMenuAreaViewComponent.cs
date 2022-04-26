using Eticaret.Business.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.ViewComponents
{
    public class MainMenuAreaViewComponent:ViewComponent
    {
        ICategoryService _categoryService;
        public MainMenuAreaViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _categoryService.List();
            return View(result);
        }
    }
}
