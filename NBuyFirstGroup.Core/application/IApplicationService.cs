using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.application
{
    //uygulamaya gelen iş isteklerini yakalayıp işlemek içn açtığımız servis(use- case işlemleri)
    //trequest gelen istek
    //tresponse uygulamadan çıkan sonuç son kullanıcıya dönen sonuç response
    public interface IApplicationService<in TRequest, out TResponce>//girdi çıktı
    {
        TResponce OnProcess(TRequest request);
    }
}
