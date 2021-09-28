namespace Core.Utilities.Results
{
    /// <summary>  </summary>
    /// <typeparam name="T">  </typeparam>
    public class ErrorDataResult<T> : DataResult<T>
    {
        /// <summary>  </summary>
        /// <param name="data">  </param>
        /// <param name="message">  </param>
        public ErrorDataResult(T data, string message) : base(data, false, message) { }

        /// <summary>  </summary>
        /// <param name="data">  </param>
        public ErrorDataResult(T data) : base(data, false) { }

        /// <summary>  </summary>
        /// <param name="message">  </param>
        public ErrorDataResult(string message) : base(default, false, message) { }

        /// <summary>  </summary>
        public ErrorDataResult() : base(default, false) { }
    }
}
