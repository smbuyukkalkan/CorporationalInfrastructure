using Core.Entities;

namespace Entities.Dtos
{
    /// <summary>  </summary>
    public class UserForRegisterDto : IDto
    {
        /// <summary>  </summary>
        public string Email { get; set; }

        /// <summary>  </summary>
        public string Password { get; set; }

        /// <summary>  </summary>
        public string FirstName { get; set; }

        /// <summary>  </summary>
        public string LastName { get; set; }
    }
}
