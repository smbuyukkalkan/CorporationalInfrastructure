namespace Core.Entities
{
    /// <summary> Defines a table in the database and contains common properties of the tables. </summary>
    public interface IEntity
    {
        /// <summary> Record identification number. </summary>
        int Id { get; set; }
    }
}
