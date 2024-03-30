using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Contracts.Admin;
using AutoMotoStyle.Core.Services;
using AutoMotoStyle.Core.Services.Admin;
using AutoMotoStyle.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AutoMotoStyleServiceExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IDealerService, DealerService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IServiceModel, ServiceModel>();

            return services;
        }
    }
}
