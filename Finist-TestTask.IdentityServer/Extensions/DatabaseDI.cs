using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Finist_TestTask.IdentityServer.Extensions;

public static class DatabaseDI
{
    public static IServiceCollection AddApplicationDataBase(this IServiceCollection services, string connectionString)
    {
        services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
        
        services
            .AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseNpgsql(connectionString);
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

        return services;
    }
}