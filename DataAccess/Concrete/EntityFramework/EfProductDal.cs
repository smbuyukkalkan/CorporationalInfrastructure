using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    /// <summary> Implements data access operations related to a <see cref="Product"/> and managed by Entity Framework Core. </summary>
    public class EfProductDal : EfEntityRepositoryBase<Product, CorporationalInfrastructureDbContext>, IProductDal
    {
        /// <summary>  </summary>
        /// <returns>  </returns>
        public List<ProductDetailDto> GetProductDetails()
        {
            using var context = new CorporationalInfrastructureDbContext();

            var result = from p in context.Products
                join c in context.Categories on p.CategoryId equals c.Id
                select new ProductDetailDto
                {
                    Id = p.Id,
                    ProductName = p.Name,
                    CategoryName = c.Name,
                    UnitsInStock = p.UnitsInStock
                };

            return result.ToList();
        }
    }
}
