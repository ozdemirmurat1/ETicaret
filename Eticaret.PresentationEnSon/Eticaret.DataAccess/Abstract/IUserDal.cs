using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticaret.Core.DataAccess;
using Eticaret.Entities;

namespace Eticaret.DataAccess.Abstract
{
    public interface IUserDal:IRepository<User>
    {

    }
}
