using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.caching
{
    public interface ICacheStore<TModel>
    {
        //kategori cache ,kategori listesi tutacağım

        void Set(string cacheKey, TModel model);//keye göre cacheler.in
        TModel Get(string cacheKey);//keye göre cache getirir.out

        void Clear(string cacheKey);//cache temizler
    }
}
