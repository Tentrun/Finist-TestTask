using Finist_TestTask.DAL.Interfaces.Base;
using Finist_TestTask.DAL.Interfaces.Repositories;
using Finist_TestTask.DAL.Repositories.Base;
using Finist_TestTask.DAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Finist_TestTask.DAL.DI;

public static class DatabaseDependencyInjection
{
    public static IServiceCollection AddApplicationDataBase(this IServiceCollection services, string connectionString)
    {
        services
            .AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseNpgsql(connectionString);
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            })
            .AddScoped(typeof(IGenericRepository< >), typeof(GenericRepository< >))
            .AddScoped<IUnitOfWork, UnitOfWork>()
            .AddScoped<ICardRepository, CardRepository>()
            .AddScoped<IDemandRepository, DemandRepository>()
            .AddScoped<IExpressRepository, ExpressRepository>()
            .AddScoped<IClientRepository, ClientRepository>();

        return services;
    }
}