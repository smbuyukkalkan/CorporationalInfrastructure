
namespace Core.Utilities.Results
{
    /// <summary> Represents a result of an operation which indicates that the operation is not successful, optionally with a message. </summary>
    public class ErrorResult : Result
    {
        /// <summary> Creates an instance of a error result with given message. </summary>
        /// <param name="message"></param>
        public ErrorResult(string message) : base(false, message) { }

        /// <summary> Creates an instance of a error result without any message. </summary>
        public ErrorResult() : base(false) {}
    }
}
