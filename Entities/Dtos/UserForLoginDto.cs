using Core.Entities;

namespace Entities.Dtos
{
    /// <summary>  </summary>
    public class UserForLoginDto : IDto
    {
        /// <summary>  </summary>
        public string Email { get; set; }

        /// <summary>  </summary>
        public string Password { get; set; }
    }
}
