using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Contracts.Admin;
using AutoMotoStyle.Core.Services;
using AutoMotoStyle.Core.Services.Admin;
using AutoMotoStyle.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Identity;

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

        public static  IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            Task.Run(async () =>
             {
                 if (await roleManager.RoleExistsAsync("Administrator"))
                 {
                     return;
                 }

                 var role = new IdentityRole { Name = "Administrator" };
                 await roleManager.CreateAsync(role);

                 var admin = await userManager.FindByNameAsync("admin@automotostyle.com");
                 await userManager.AddToRoleAsync(admin, role.Name);
             })
                 .GetAwaiter()
                 .GetResult();        
            
                        
            return app;
        }


    }
}
