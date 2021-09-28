using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Utilities.IoC
{
    /// <summary>  </summary>
    public static class ServiceTool
    {
        /// <summary>  </summary>
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>  </summary>
        /// <param name="services">  </param>
        /// <returns>  </returns>
        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
