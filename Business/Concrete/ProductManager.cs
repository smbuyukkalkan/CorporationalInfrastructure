using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    /// <summary>  </summary>
    public class ProductManager : IProductService
    {
        /// <summary>  </summary>
        private readonly IProductDal _productDal;

        /// <summary>  </summary>
        private readonly ICategoryService _categoryService;

        /// <summary>  </summary>
        /// <param name="productDal">  </param>
        /// <param name="categoryService">  </param>
        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }

        /// <summary>  </summary>
        /// <param name="product">  </param>
        /// <returns>  </returns>
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRules.Run(
                CheckIfProductCountOfCategoryIsCorrect(product.CategoryId),
                CheckIfProductNameExists(product.Name),
                CheckIfCategoryLimitExceeded()
                );

            if (result != null)
                return result;

            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        /// <summary>  </summary>
        /// <param name="product">  </param>
        /// <returns>  </returns>
        public IResult Update(Product product)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>  </summary>
        /// <returns>  </returns>
        public IDataResult<List<Product>> GetAll()
        {
            var allProducts = _productDal.GetAll();

            if (allProducts.Count == 0)
                return new ErrorDataResult<List<Product>>(Messages.NoProductExists);

            return new DataResult<List<Product>>(_productDal.GetAll(), true, Messages.ProductListGenerated);
        }

        /// <summary>  </summary>
        /// <param name="categoryId">  </param>
        /// <returns>  </returns>
        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId));
        }

        /// <summary>  </summary>
        /// <param name="productId">  </param>
        /// <returns>  </returns>
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == productId));
        }

        /// <summary>  </summary>
        /// <param name="min">  </param>
        /// <param name="max">  </param>
        /// <returns>  </returns>
        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        /// <summary>  </summary>
        /// <returns>  </returns>
        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        /// <summary>  </summary>
        /// <param name="categoryId">  </param>
        /// <returns>  </returns>
        private IResult CheckIfProductCountOfCategoryIsCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result > 15)
                return new ErrorResult(Messages.ProductCountOfCategoryGreaterThan15);

            return new SuccessResult();
        }

        /// <summary>  </summary>
        /// <param name="productName">  </param>
        /// <returns>  </returns>
        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _productDal.GetAll(p => p.Name == productName).Any();
            if (result)
                return new ErrorResult(Messages.ProductWithSameNameAlreadyExists);

            return new SuccessResult();
        }

        /// <summary>  </summary>
        /// <returns>  </returns>
        private IResult CheckIfCategoryLimitExceeded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count > 15)
                return new ErrorResult(Messages.CategoryLimitReached);

            return new SuccessResult();
        }
    }
}
