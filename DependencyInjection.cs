using dotNetDependencyInjection.Interfaces;
using dotNetDependencyInjection.Repositories;
using dotNetDependencyInjection.Services;

namespace dotNetDependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this
        IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            return services;
        }

    } 
}

