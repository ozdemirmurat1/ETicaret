using Eticaret.DataAccess.Abstract;
using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business.Services
{
    public class UserTokenService:IUserTokenService
    {
        private readonly IUserTokenDal _userTokenDal;

        public UserTokenService(IUserTokenDal userTokenDal)
        {
            _userTokenDal = userTokenDal;
        }

        public void Add(string token,int userId)
        {
            var tokenData = new UserToken() 
            {
                CreateDate=DateTime.Now,
                TokenKey=token,
                Status=true,
                UserId=userId
            };
            _userTokenDal.Add(tokenData);
        }

        public UserToken Get(string TokenKey)
        {
            var userToken= _userTokenDal.Get(u => u.TokenKey == TokenKey);
            return userToken;
        }
    }
}
