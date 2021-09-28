using Core.Entities;

namespace Entities.Concrete
{
    /// <summary> Represents a customer. </summary>
    public class Customer : IEntity
    {
        /// <summary> Record identification number. </summary>
        public int Id { get; set; }

        /// <summary> Name of the customer. </summary>
        public string CustomerName { get; set; }

        /// <summary> Name of the company the customer is representing. </summary>
        public string CompanyName { get; set; }

        /// <summary> The city the customer lives in. </summary>
        public string City { get; set; }
    }
}
