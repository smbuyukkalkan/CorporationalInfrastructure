using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    /// <summary> Implements data access operations related to a <see cref="Category"/> and managed by Entity Framework. </summary>
    public class EfCategoryDal : EfEntityRepositoryBase<Category, CorporationalInfrastructureDbContext>, ICategoryDal { }
}