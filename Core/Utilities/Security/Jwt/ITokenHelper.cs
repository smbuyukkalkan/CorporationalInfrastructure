using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Core.Utilities.Security.Jwt
{
    /// <summary>  </summary>
    public interface ITokenHelper
    {
        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <param name="operationClaims">  </param>
        /// <returns>  </returns>
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
