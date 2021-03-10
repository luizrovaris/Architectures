using CustomerRelationship.Domain.CustomerRelationship;
using CustomerRelationship.Domain.CustomerRelationship.Impl;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerRelationship.Facade.Plumbing
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddFacadeDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICustomerManager, CustomerManager>();

            return services;
        }
    }
}
