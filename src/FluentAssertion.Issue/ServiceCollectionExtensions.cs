using System;
using Microsoft.Extensions.DependencyInjection;

namespace FluentAssertion.Issue
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection Register(this IServiceCollection serviceCollection)
        {
            return serviceCollection ?? throw new ArgumentNullException(nameof(serviceCollection));
        }
    }
}
