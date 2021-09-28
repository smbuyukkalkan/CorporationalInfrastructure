using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    /// <summary> Represents a customer which can buy products. </summary>
    public interface ICustomerDal : IEntityRepository<Customer> { }
}
