namespace Core.Utilities.Results
{
    /// <summary> Defines a result of an operation which indicates whether the operation is successful or not, optionally with a message. </summary>
    public interface IResult
    {
        /// <summary> The result of the operation. </summary>
        bool Success { get; }

        /// <summary> The message about the result of the operation. </summary>
        string Message { get; }
    }
}
