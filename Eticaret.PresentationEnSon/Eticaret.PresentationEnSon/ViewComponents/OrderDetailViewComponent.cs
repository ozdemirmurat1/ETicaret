using Eticaret.Business.Helpers;
using Eticaret.Business.Services;
using Eticaret.PresentationEnSon.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.ViewComponents
{
    public class OrderDetailViewComponent:ViewComponent
    {
        private readonly ICookieHelper _cookieHelper;  // hep cookie üzerinden sepete alırız.
        public OrderDetailViewComponent(ICookieHelper cookieHelper)
        {
            _cookieHelper = cookieHelper;
        }
        public IViewComponentResult Invoke()
        {
            var tokenKey = _cookieHelper.Get(CookieTypes.basket,Request);
            var basket = BasketHelper.GetMethods.Get(tokenKey);

            return View(basket);
        }
    }
}
