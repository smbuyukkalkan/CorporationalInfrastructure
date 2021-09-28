using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;

namespace Business.Concrete
{
    /// <summary>  </summary>
    public class AuthManager : IAuthService
    {
        /// <summary>  </summary>
        private readonly IUserService _userService;

        /// <summary>  </summary>
        private readonly ITokenHelper _tokenHelper;

        /// <summary>  </summary>
        /// <param name="userService">  </param>
        /// <param name="tokenHelper">  </param>
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        /// <summary>  </summary>
        /// <param name="userForRegisterDto">  </param>
        /// <param name="password">  </param>
        /// <returns>  </returns>
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            HashingHelper.CreatePasswordHash(password, out var passwordHash, out var passwordSalt);

            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        /// <summary>  </summary>
        /// <param name="userForLoginDto">  </param>
        /// <returns>  </returns>
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
                return new ErrorDataResult<User>(Messages.UserNotFound);

            var passwordVerification = HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt);
            if (!passwordVerification)
                return new ErrorDataResult<User>(Messages.InvalidPassword);

            return new SuccessDataResult<User>(userToCheck, Messages.LoginSuccessful);
        }

        /// <summary>  </summary>
        /// <param name="email">  </param>
        /// <returns>  </returns>
        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }

            return new SuccessResult();
        }

        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <returns>  </returns>
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
