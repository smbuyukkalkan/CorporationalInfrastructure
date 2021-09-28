using Core.Entities;
using System;

namespace Entities.Concrete
{
    /// <summary>  </summary>
    public class Order : IEntity
    {
        /// <summary>  </summary>
        public int Id { get; set; }

        /// <summary>  </summary>
        public int CustomerId { get; set; }

        /// <summary>  </summary>
        public int EmployeeId { get; set; }

        /// <summary>  </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>  </summary>
        public string ShipCity { get; set; }
    }
}
