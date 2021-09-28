namespace Core.Utilities.Results
{
    /// <summary> Represents a result of an operation which indicates that the operation is successful, optionally with a message. </summary>
    public class SuccessResult : Result
    {
        /// <summary> Creates an instance of a successful result with given message. </summary>
        /// <param name="message"></param>
        public SuccessResult(string message) : base(true, message) { }

        /// <summary> Creates an instance of a successful result without any message. </summary>
        public SuccessResult() : base(true) { }
    }
}
