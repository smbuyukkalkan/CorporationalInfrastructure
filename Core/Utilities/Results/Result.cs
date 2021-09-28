namespace Core.Utilities.Results
{
    /// <summary> Represents a result of an operation which indicates whether the operation is successful, optionally with a message. </summary>
    public class Result : IResult
    {
        public bool Success { get; }
        public string Message { get; }

        /// <summary> Creates an instance of a result with given success status and message. </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        /// <summary> Creates an instance of a result with given success status. </summary>
        /// <param name="success"></param>
        public Result(bool success)
        {
            Success = success;
        }
    }
}
