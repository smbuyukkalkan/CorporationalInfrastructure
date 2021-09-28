using Core.Entities;

namespace Entities.Concrete
{
    /// <summary> Represents a product. </summary>
    public class Product : IEntity
    {
        /// <summary> Record identification number. </summary>
        public int Id { get; set; }

        /// <summary> ID of the category this product belongs to. </summary>
        public int CategoryId { get; set; }

        /// <summary> Name of the product. </summary>
        public string Name { get; set; }

        /// <summary> Count of units of the product available to be sold. </summary>
        public short UnitsInStock { get; set; }

        /// <summary> Price of a unit of the product. </summary>
        public decimal UnitPrice { get; set; }
    }
}
