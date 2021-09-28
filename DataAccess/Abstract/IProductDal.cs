using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    /// <summary> Represents a product which can be bought by customers. </summary>
    public interface IProductDal : IEntityRepository<Product>
    {
        /// <summary>  </summary>
        /// <returns>  </returns>
        List<ProductDetailDto> GetProductDetails();
    }
}
