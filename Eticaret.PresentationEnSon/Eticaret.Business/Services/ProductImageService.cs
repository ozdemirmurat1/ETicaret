using Eticaret.DataAccess.Abstract;
using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business.Services
{
    public class ProductImageService : IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageService(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public List<ProductImage> GetImages(int ProductId)
        {
            return _productImageDal.List(x => x.ProductId == ProductId).OrderBy(s=>s.Sort).ToList();
        }
    }
}
