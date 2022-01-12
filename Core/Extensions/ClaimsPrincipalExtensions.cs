using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Core.Extensions
{
    //ClaimsPrincipal kullanıcının claimlerine erişebilmek için kullanılan bir .net class'ı 
    // biz bu classı genişleterek kendimiz yeni metotlar ekliyoruz.
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList(); //kişi eğer token istiyorsa onun claimlerini buluyor. 
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal) //direkt rolleri döndürecek metot
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
