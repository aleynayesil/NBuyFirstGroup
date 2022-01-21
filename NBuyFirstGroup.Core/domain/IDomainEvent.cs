using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.domain
{
    //kampanya gibi işlemlerde 
    //gerçekleşecek olay ile ilgili bir interface tanımladım entity içerisinde bir değişim state değerinde bir değişim sonucu bu event başka bir entity e haber verecek örn fiyat değiştiğinde bu ürünü favlamış olan kullanıcılara e posta göndermeliyim.sisteme makale girildiğinde takip edilen yazarın son makalesini eposta olarak alma
    public interface IDomainEvent
    {

        public string Name { get; set; }//event Name=< ordered event,shipped event
    }

}
