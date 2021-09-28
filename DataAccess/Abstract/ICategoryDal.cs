using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    /// <summary> Represents a category which any number of products can belong to. </summary>
    public interface ICategoryDal : IEntityRepository<Category> { }
}
