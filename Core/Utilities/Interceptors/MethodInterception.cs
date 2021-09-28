using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    /// <summary>  </summary>
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        /// <summary>  </summary>
        /// <param name="invocation"></param>
        protected virtual void OnBefore(IInvocation invocation) { }

        /// <summary>  </summary>
        /// <param name="invocation"></param>
        protected virtual void OnAfter(IInvocation invocation) { }

        /// <summary>  </summary>
        /// <param name="invocation"></param>
        /// <param name="e"></param>
        protected virtual void OnException(IInvocation invocation, Exception e) { }

        /// <summary>  </summary>
        /// <param name="invocation"></param>
        protected virtual void OnSuccess(IInvocation invocation) { }

        /// <summary>  </summary>
        /// <param name="invocation"></param>
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);

            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }

            OnAfter(invocation);
        }
    }
}
