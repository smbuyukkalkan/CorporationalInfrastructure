using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    /// <summary>  </summary>
    public static class HashingHelper
    {
        /// <summary>  </summary>
        /// <param name="password">  </param>
        /// <param name="passwordHash">  </param>
        /// <param name="passwordSalt">  </param>
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();

            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            passwordSalt = hmac.Key;
        }

        /// <summary>  </summary>
        /// <param name="password">  </param>
        /// <param name="passwordHash">  </param>
        /// <param name="passwordSalt">  </param>
        /// <returns></returns>
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Compare computed hash against existing hash byte by byte
            return !computedHash.Where((computedHashNthByte, n) => computedHashNthByte != passwordHash[n]).Any();
        }
    }
}
