using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    /// <summary>  </summary>
    public interface IUserService
    {
        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <returns>  </returns>
        List<OperationClaim> GetClaims(User user);

        /// <summary>  </summary>
        /// <param name="user">  </param>
        void Add(User user);

        /// <summary>  </summary>
        /// <param name="email">  </param>
        /// <returns>  </returns>
        User GetByMail(string email);
    }
}
