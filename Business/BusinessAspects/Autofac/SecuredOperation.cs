using Business.Constants;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac
{
    //Authorization aspectlerini Core'da yapmama sebebim her projenin yetkilendirmesi farklıdır.
    //JWT için bu classı geliştiriyoruz.
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor; //jwt ye yapılan her istek için bir httpcontext oluşturmak için ekledik.

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(','); //bir string metni belirttiğimiz karaktere göre(",") ayırıp array'e atıyor.
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>(); //ServiceTool bizim injection alt yapımızı okumaya yarayan bir araç. 

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles(); //o anki kullanıcının claimrollerini buluyor. 
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
