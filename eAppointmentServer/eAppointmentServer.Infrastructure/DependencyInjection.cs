using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eAppointmentServer.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)

        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"))
            );
                services.AddIdentity<AppUser, AppRole>(action =>
                {
                action.Password.RequiredLength = 1;
                action.Password.RequireNonAlphanumeric = false;
                action.Password.RequireDigit = false;
                action.Password.RequireLowercase = false;
                action.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
            return services;
        }
    }
}
