namespace Core.Utilities.Results
{
    /// <summary>   </summary>
    /// <typeparam name="T">  </typeparam>
    public class SuccessDataResult<T> : DataResult<T>
    {
        /// <summary>  </summary>
        /// <param name="data">  </param>
        /// <param name="message">  </param>
        public SuccessDataResult(T data, string message) : base(data, true, message) { }

        /// <summary>  </summary>
        /// <param name="data">  </param>
        public SuccessDataResult(T data) : base(data, true) { }

        /// <summary>  </summary>
        /// <param name="message">  </param>
        public SuccessDataResult(string message) : base(default, true, message) { }

        /// <summary>  </summary>
        public SuccessDataResult() : base(default, true) {}
    }
}
