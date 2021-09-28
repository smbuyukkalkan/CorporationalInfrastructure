namespace Core.Entities.Concrete
{
    /// <summary>  </summary>
    public class User : IEntity
    {
        /// <summary>  </summary>
        public int Id { get; set; }

        /// <summary>  </summary>
        public string FirstName { get; set; }

        /// <summary>  </summary>
        public string LastName { get; set; }

        /// <summary>  </summary>
        public string Email { get; set; }

        /// <summary>  </summary>
        public byte[] PasswordSalt { get; set; }

        /// <summary>  </summary>
        public byte[] PasswordHash { get; set; }

        /// <summary>  </summary>
        public bool Status { get; set; }
    }
}
