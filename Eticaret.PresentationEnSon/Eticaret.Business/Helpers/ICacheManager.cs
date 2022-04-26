using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business.Helpers
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        void Set(string key, object data);

        void Delete(string key);

        void Clear();

        /*
         product.id.1
         product.all.list
         */

        void Clear(string header);
    }
}
