using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business.Services
{
    public interface IUserTokenService
    {
        UserToken Get(string TokenKey);

        void Add(string token, int userId);
    }
}
