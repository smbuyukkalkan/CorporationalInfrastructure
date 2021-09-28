using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    /// <summary>  </summary>
    public class CategoryManager : ICategoryService
    {
        /// <summary>  </summary>
        private readonly ICategoryDal _categoryDal;

        /// <summary>  </summary>
        /// <param name="categoryDal">  </param>
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        /// <summary>  </summary>
        /// <returns>  </returns>
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        /// <summary>  </summary>
        /// <param name="categoryId">  </param>
        /// <returns>  </returns>
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId));
        }
    }
}
