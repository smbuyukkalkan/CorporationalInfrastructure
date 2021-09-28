namespace Core.Entities.Concrete
{
    /// <summary>  </summary>
    public class UserOperationClaim : IEntity
    {
        /// <summary>  </summary>
        public int Id { get; set; }

        /// <summary>  </summary>
        public int UserId { get; set; }

        /// <summary>  </summary>
        public int OperationClaimId { get; set; }
    }
}
