using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    /// <summary>  </summary>
    public static class SigningCredentialsHelper
    {
        /// <summary>  </summary>
        /// <param name="securityKey">  </param>
        /// <returns>  </returns>
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
