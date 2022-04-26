using Eticaret.Business.Helpers;
using Eticaret.Business.Services;
using Eticaret.PresentationEnSon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserService _userService;
        private readonly IUserTokenService _userTokenService;

        public HomeController(ICookieHelper cookieHelper, IUserService userService, IUserTokenService userTokenService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTokenService = userTokenService;
        }

        public IActionResult Index()
        {
            return View();
        }
        // başında hiçbir şey yazmayan Action metotları GET işlemi yapar.

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            //Isvalid modelin geçerli olduğunu yani datalar doğru manasına gelir.
            if (ModelState.IsValid)
            {
                var login = _userService.Login(model.Email, model.Password);
                if (login==null)
                {
                    ModelState.AddModelError("LoginError", "Giriş Başarısız.");
                }
                else
                {
                    string guid = Guid.NewGuid().ToString();
                    _cookieHelper.Add(CookieTypes.user, guid, DateTime.Now.AddDays(10), Response);
                    _userTokenService.Add(guid, login.Id);
                    return RedirectToAction("Index", "Home");
                }
                
            }
            else
            {
                // bu model hatalı.
            }
            return View();
        }
        public IActionResult Logout()
        {
            _cookieHelper.Delete(CookieTypes.user, Response);
            return RedirectToAction("Index");
        }
    }
}
