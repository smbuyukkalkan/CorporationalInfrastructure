namespace Core.Utilities.Results
{
    /// <summary> Defines a result of an operation which indicates whether the operation is successful, with some data and optionally a message. </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataResult<T> : IResult
    {
        /// <summary> The data. </summary>
        T Data { get; }
    }
}
