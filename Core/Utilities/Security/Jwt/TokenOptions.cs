namespace Core.Utilities.Security.Jwt
{
    /// <summary>  </summary>
    public class TokenOptions
    {
        /// <summary>  </summary>
        public string Audience { get; set; }

        /// <summary>  </summary>
        public string Issuer { get; set; }

        /// <summary>  </summary>
        public int AccessTokenExpiration { get; set; }
        
        /// <summary>  </summary>
        public string SecurityKey { get; set; }
    }
}
