using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Areas.Admin.ViewComponents
{
    public class MainSideBarViewComponent:ViewComponent
    {
        public MainSideBarViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
