using Microsoft.Extensions.DependencyInjection;
using System;

namespace FluentAssertion.Issue
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection Register(this IServiceCollection serviceCollection)
        {
            _ = serviceCollection ?? throw new ArgumentNullException(nameof(serviceCollection));
            return serviceCollection;
        }
    }
}
