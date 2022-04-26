using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.ViewComponents
{
    public class PromoAreaViewComponent:ViewComponent
    {
        public PromoAreaViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
