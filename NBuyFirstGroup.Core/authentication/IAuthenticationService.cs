using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.authentication
{
    public interface IAuthenticationService
    {//task açmamızın sebebi başka servis üzerinden bağlanılabilir google facebook gibi
        Task AuthenticateAsync(string email, string password, bool persistence);//bu servis üzerinden sisteme login olacağız
    }
    //eğer kullanıcı başarılı bir şekilde giriş yaptıysa ısauthenticated true döner
    public class AuthenticationResult
    {
        public AuthenticatedUser User { get; set; }
        public bool IsAuthenticated { get; set; }
        public string ErrorMessage { get; set; }
    }
}
