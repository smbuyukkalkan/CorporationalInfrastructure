using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    /// <summary>  </summary>
    public class UserManager : IUserService
    {
        /// <summary>  </summary>
        private readonly IUserDal _userDal;

        /// <summary>  </summary>
        /// <param name="userDal">  </param>
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <returns>  </returns>
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        /// <summary>  </summary>
        /// <param name="user">  </param>
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        /// <summary>  </summary>
        /// <param name="email">  </param>
        /// <returns>  </returns>
        public User GetByMail(string email)
        {
            return _userDal.Get(user => user.Email == email);
        }
    }
}
