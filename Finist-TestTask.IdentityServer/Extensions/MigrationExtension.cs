using Microsoft.EntityFrameworkCore;

namespace Finist_TestTask.IdentityServer.Extensions;

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