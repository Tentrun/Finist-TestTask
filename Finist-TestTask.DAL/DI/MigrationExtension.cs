using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Finist_TestTask.DAL.DI;

public static class MigrationExtension
{
    public static IServiceProvider ApplyMigrations(this IServiceProvider provider)
    {
        using var scope = provider.CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate();
        return provider;
    }
}