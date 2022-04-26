using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.Entities;
using Eticaret.PresentationEnSon.Models;
using Eticaret.Business.Services;
using Eticaret.PresentationEnSon.Areas.Admin.Models;
using Eticaret.Business.Helpers;

namespace Eticaret.PresentationEnSon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IStringHelper _stringHelper;

        public UserController(IUserService userService, IStringHelper stringHelper)
        {
            _userService = userService;
            _stringHelper = stringHelper;
        }

        public IActionResult Index()
        {
            UserListViewModel model = new();
            model.List = _userService.List();
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(UserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(new User()
                {
                    Email=model.Email,
                    Password=_stringHelper.ToMd5(model.Password),
                    IsAdmin=model.IsAdmin,
                    Status=true
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _userService.GetById(id);
            UserAddViewModel userModel = new UserAddViewModel();
            userModel.Email = user.Email;
            userModel.IsAdmin = user.IsAdmin;
            userModel.Id = id;
            return View(userModel);
        }
        [HttpPost]
        public IActionResult Edit(UserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Id=model.Id,
                    Email=model.Email,
                    Password=_stringHelper.ToMd5(model.Password),
                    IsAdmin=model.IsAdmin,
                    Status=true
                    
                };
                _userService.Update(user);
                return RedirectToAction("Index");
            }
            return View(model);
            
        }

    }
}
