using Eticaret.Business.Helpers;
using Eticaret.Business.Services;
using Eticaret.PresentationEnSon.Helpers;
using Eticaret.PresentationEnSon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Controllers
{
    public class BasketController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;
        public BasketController(ICookieHelper cookieHelper, IProductService productService, IProductImageService productImageService)
        {
            _cookieHelper = cookieHelper;
            _productService = productService;
            _productImageService = productImageService;
        }

        public IActionResult Index()
        {
            var guidKey = GetGuid();
            var basketDetail = BasketHelper.GetMethods.Get(guidKey);
            BasketIndexViewModel model = new();
            model.Basket = basketDetail;
            return View(model);
        }

        public JsonResult AddBasket(int quantityData,int productIdData)
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket,Request);

            if (basketCookieValue==null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(50), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }

            var product = _productService.Get(productIdData);
            var productImages = _productImageService.GetImages(productIdData);

            BasketHelper.GetMethods.AddProduct(new BasketProduct {

                Image=productImages.First().Name,
                ProductId=productIdData,
                Quantity=quantityData,
                Product=product
            
            }, basketGuid, 0,quantityData);

            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            string basketHtml = $"<a href=\"/mybasket\">Cart - <span class=\"cart-amunt\">{basketDetail.Item2}</span> <i class=\"fa fa-shopping-cart\"></i> <span class=\"product-count\">{basketDetail.Item1}</span></a>";
            return Json(basketHtml);
        }

        public JsonResult GetBasket()
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);

            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(50), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }

            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            string basketHtml = $"<a href=\"/mybasket\">Cart - <span class=\"cart-amunt\">{basketDetail.Item2}</span> <i class=\"fa fa-shopping-cart\"></i> <span class=\"product-count\">{basketDetail.Item1}</span></a>";
            return Json(basketHtml);
        }
        private string GetGuid()
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);

            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(50), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }
            return basketGuid;
        }

        public IActionResult Minus(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(token);
            var product = products.BasketProducts.FirstOrDefault(p => p.ProductId == Id);
            if (product.Quantity==1)
            {
                products.BasketProducts.Remove(product);
            }
            else
            {
                product.Quantity += -1;
            }
            return Redirect("/mybasket");
        }

        public IActionResult Plus(int Id)
        {
            var token = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(token);
            var product = products.BasketProducts.FirstOrDefault(p => p.ProductId == Id);

            product.Quantity += 1;

            return Redirect("/mybasket");
        }
    }
}
