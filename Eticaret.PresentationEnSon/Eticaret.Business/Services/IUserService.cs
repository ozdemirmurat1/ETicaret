using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eticaret.Business.Services
{
    public interface IUserService
    {
        User Login(string username, string password);
        User AdminLogin(string username, string password);
        User GetById(int userId);
        List<User> List();
        void Delete(int id);  // soft delete yapacak.
        void Add(User userData);
        void Update(User userData);
    }
}
