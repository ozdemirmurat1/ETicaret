using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eticaret.Business.Helpers;
using Eticaret.Business.Services;
using Eticaret.Entities;
using Microsoft.AspNetCore.Http;

namespace Eticaret.PresentationEnSon.Areas.Admin.Helpers
{
    public class AdminChecker:IAdminChecker
    {        
        ICookieHelper _cookieHelper;
        IUserService _userService;
        IUserTokenService _userTokenService;

        public AdminChecker(ICookieHelper cookieHelper, IUserService userService, IUserTokenService userTokenService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTokenService = userTokenService;
        }

        public bool Check(HttpRequest request)
        {
            var token = _cookieHelper.Get(CookieTypes.admin, request);
            if (token != null)
            {
                var userId = _userTokenService.Get(token).UserId;
                var user = _userService.GetById(userId);
                if (user.IsAdmin) return true;
                return false;
            }
            else return false;
        }
        
    }
}
