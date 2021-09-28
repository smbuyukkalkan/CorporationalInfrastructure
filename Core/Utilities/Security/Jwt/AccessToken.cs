using System;

namespace Core.Utilities.Security.Jwt
{
    /// <summary>  </summary>
    public class AccessToken
    {
        /// <summary>  </summary>
        public string Token { get; set; }

        /// <summary>  </summary>
        public DateTime Expiration { get; set; }
    }
}
