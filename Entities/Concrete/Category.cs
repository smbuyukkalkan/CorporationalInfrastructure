using Core.Entities;

namespace Entities.Concrete
{
    /// <summary> Represents a product category. </summary>
    public class Category : IEntity
    {
        /// <summary> Record identification number. </summary>
        public int Id { get; set; }

        /// <summary> Name of the category. </summary>
        public string Name { get; set; }
    }
}
