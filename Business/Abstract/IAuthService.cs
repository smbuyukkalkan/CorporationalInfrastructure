using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;

namespace Business.Abstract
{
    /// <summary>  </summary>
    public interface IAuthService
    {
        /// <summary>  </summary>
        /// <param name="userForRegisterDto">  </param>
        /// <param name="password">  </param>
        /// <returns>  </returns>
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);

        /// <summary>  </summary>
        /// <param name="userForLoginDto">  </param>
        /// <returns>  </returns>
        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        /// <summary>  </summary>
        /// <param name="email">  </param>
        /// <returns>  </returns>
        IResult UserExists(string email);

        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <returns>  </returns>
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
