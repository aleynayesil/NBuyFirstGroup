using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.authentication
{
    //kimliği doğrulanmış kullanııc bilgilerini döndürür
    public class AuthenticatedUser
    {
        public string Email { get; private set; }
        public string UserName { get; private set; }
        public string AccessToken { get; private set; }//oturum için kullanılan token değeri
        public DateTime? AccountExpirationDate { get; private set; }//oturum süresi dolduğu taktirde bir daha login olması lazım

        public AuthenticatedUser()
        {

        }

        public void SetAuthenticatedUser(string email, string username,string accessToken,DateTime accountExpirationDate)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("E-posta alanı boş geçilemez.");
            if (!email.Contains("@"))
                throw new Exception("E-posta formatında giriş yapınız.");
            if (string.IsNullOrEmpty(accessToken))
                throw new Exception("Access token gerekli.");
            //eğen yanlışlıkla şuandan küçük bir değer seçilmişse minimumda 20 dklık oturum aç
            //oturum düştü mü düşmedimi diye kontrol edicez
            if (accountExpirationDate <= DateTime.Now)
                accountExpirationDate = DateTime.Now.AddMinutes(20);

            if (string.IsNullOrEmpty(username))
                username = email.Trim();//username boş ise email olarak defaultta ayarla

            Email = email.Trim();
            UserName = username.Trim();
            AccessToken = accessToken.Trim();
            AccountExpirationDate = accountExpirationDate;
        }
    }
}
