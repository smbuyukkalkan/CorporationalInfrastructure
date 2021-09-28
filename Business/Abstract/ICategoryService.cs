using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    /// <summary>  </summary>
    public interface ICategoryService
    {
        /// <summary>  </summary>
        /// <returns>  </returns>
        IDataResult<List<Category>> GetAll();

        /// <summary>  </summary>
        /// <param name="categoryId">  </param>
        /// <returns>  </returns>
        IDataResult<Category> GetById(int categoryId);
    }
}
