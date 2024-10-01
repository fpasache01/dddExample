using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace Namespace
{
    /// <summary>
    /// 
    /// </summary>
     public static class ServiceInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddSingleton<ITestService,TestService>();
            return services;
        }
    }
}
