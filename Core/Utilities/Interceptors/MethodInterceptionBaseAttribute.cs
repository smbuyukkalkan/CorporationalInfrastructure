using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    /// <summary>  </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        /// <summary>  </summary>
        public int Priority { get; set; }

        /// <summary>  </summary>
        /// <param name="invocation"></param>
        public virtual void Intercept(IInvocation invocation) { }
    }
}
