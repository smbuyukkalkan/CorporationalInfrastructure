using Business.Constants;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Business.BusinessAspects.Autofac
{
    /// <summary> For use of JWT </summary>
    public class SecuredOperation : MethodInterception
    {
        /// <summary>  </summary>
        private readonly string[] _roles;

        /// <summary>  </summary>
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>  </summary>
        /// <param name="roles">  </param>
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        /// <summary>  </summary>
        /// <param name="invocation">  </param>
        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();

            if (_roles.Any(role => roleClaims.Contains(role)))
                return;

            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
