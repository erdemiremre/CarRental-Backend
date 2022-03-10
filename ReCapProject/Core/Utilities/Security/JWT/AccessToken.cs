using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; } //JWT'nin ta kendisi kullanıcı postmande girecek ona göre iş yapacak
        public DateTime Expiration { get; set; } //tokenin bitiş süresi
    }
}
