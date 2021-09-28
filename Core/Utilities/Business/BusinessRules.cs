using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    /// <summary>  </summary>
    public class BusinessRules
    {
        /// <summary>  </summary>
        /// <param name="logics">  </param>
        /// <returns>  </returns>
        public static IResult Run(params IResult[] logics)
        {
            //TODO This method will be updated so all errors will be returned once instead of only one.
            return logics.FirstOrDefault(result => !result.Success);
        }
    }
}
