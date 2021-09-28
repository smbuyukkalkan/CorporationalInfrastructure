using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Core.Extensions
{
    /// <summary>  </summary>
    public static class ClaimsPrincipalExtensions
    {
        /// <summary>  </summary>
        /// <param name="claimsPrincipal">  </param>
        /// <param name="claimType">  </param>
        /// <returns>  </returns>
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }

        /// <summary>  </summary>
        /// <param name="claimsPrincipal">  </param>
        /// <returns>  </returns>
        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
