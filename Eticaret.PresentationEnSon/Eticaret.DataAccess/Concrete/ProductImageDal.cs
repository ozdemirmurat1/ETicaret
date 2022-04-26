using Eticaret.Core.DataAccess;
using Eticaret.DataAccess.Abstract;
using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.DataAccess.Concrete
{
    public class ProductImageDal : RepositoryBase<ProductImage, EticaretContext>, IProductImageDal
    {
    }
}
