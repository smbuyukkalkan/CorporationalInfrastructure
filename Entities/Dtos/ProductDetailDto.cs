using Core.Entities;

namespace Entities.Dtos
{
    /// <summary>  </summary>
    public class ProductDetailDto : IDto
    {
        /// <summary>  </summary>
        public int Id { get; set; }

        /// <summary>  </summary>
        public string ProductName { get; set; }

        /// <summary>  </summary>
        public string CategoryName { get; set; }

        /// <summary>  </summary>
        public short UnitsInStock { get; set; }
    }
}
