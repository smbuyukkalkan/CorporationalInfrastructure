using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;

namespace Core.Utilities.Security.Jwt
{
    /// <summary>  </summary>
    public class JwtHelper : ITokenHelper
    {
        /// <summary>  </summary>
        public IConfiguration Configuration { get; }

        /// <summary>  </summary>
        private readonly TokenOptions _tokenOptions;

        /// <summary>  </summary>
        private DateTime _accessTokenExpiration;

        /// <summary>  </summary>
        /// <param name="configuration">  </param>
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }

        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <param name="operationClaims">  </param>
        /// <returns>  </returns>
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token=token,
                Expiration = _accessTokenExpiration
            };
        }

        /// <summary>  </summary>
        /// <param name="tokenOptions">  </param>
        /// <param name="user">  </param>
        /// <param name="signingCredentials">  </param>
        /// <param name="operationClaims">  </param>
        /// <returns></returns>
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials);

            return jwt;
        }

        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <param name="operationClaims">  </param>
        /// <returns>  </returns>
        private static IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}
