using Core.DataAccess;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    /// <summary>  </summary>
    public interface IUserDal : IEntityRepository<User>
    {
        /// <summary>  </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<OperationClaim> GetClaims(User user);
    }
}
