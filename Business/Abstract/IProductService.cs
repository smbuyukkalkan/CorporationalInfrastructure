using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    /// <summary> Defines business operations on a <see cref="Product"/>. </summary>
    public interface IProductService
    {
        /// <summary> Retrieves all <see cref="Product"/>s from the data source. </summary>
        /// <returns>  </returns>
        IDataResult<List<Product>> GetAll();

        /// <summary>  </summary>
        /// <param name="id">  </param>
        /// <returns>  </returns>
        IDataResult<List<Product>> GetAllByCategoryId(int id);

        /// <summary>  </summary>
        /// <param name="min">  </param>
        /// <param name="max">  </param>
        /// <returns>  </returns>
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        /// <summary>  </summary>
        /// <returns>  </returns>
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        /// <summary>  </summary>
        /// <param name="productId">  </param>
        /// <returns>  </returns>
        IDataResult<Product> GetById(int productId);

        /// <summary>  </summary>
        /// <param name="product">  </param>
        IResult Add(Product product);

        /// <summary>  </summary>
        /// <param name="product">  </param>
        /// <returns>  </returns>
        IResult Update(Product product);
    }
}
