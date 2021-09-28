using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    /// <summary>  </summary>
    public class EfUserDal : EfEntityRepositoryBase<User, CorporationalInfrastructureDbContext>, IUserDal
    {
        /// <summary>  </summary>
        /// <param name="user">  </param>
        /// <returns>  </returns>
        public List<OperationClaim> GetClaims(User user)
        {
            using var context = new CorporationalInfrastructureDbContext();

            var result = from operationClaim in context.OperationClaims 
                join userOperationClaim in context.UserOperationClaims on operationClaim.Id equals userOperationClaim.Id
                where userOperationClaim.UserId == user.Id
                select new OperationClaim {Id = operationClaim.Id, Name = operationClaim.Name};

            return result.ToList();
        }
    }
}
