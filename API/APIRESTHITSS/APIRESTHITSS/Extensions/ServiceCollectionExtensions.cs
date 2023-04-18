using APIRESTHITSS.Interfaces;
using APIRESTHITSS.Repositories;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace APIRESTHITSS.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRespository, CustomerRepository>();
        }
    }
}
