using Finist_TestTask.IdentityServer.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Finist_TestTask.IdentityServer;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser[]
        {
            new IdentityUser
            {
                Id = "9e8aab80-4ab5-4177-99e8-0bdeed2885cd",
                UserName = "+79980007633",
                NormalizedUserName = "+79980007633",
                PasswordHash = "AQAAAAIAAYagAAAAELdRbu9/Adi1/ixkgh91knVbCsJVLaOmXEN4W1x7yjLWG4q4/UDvIhoZWfdTIUDJdA==",
                SecurityStamp = "BDLP4MVGADJZPYWIDWGQHOTQ7UZD4ZLU",
                ConcurrencyStamp = "1f3a9d4c-9fee-4e09-8ee2-6881da0f9f5f"
            },
            new IdentityUser
            {
                Id = "46a7b9cd-1de8-4777-aa4e-edff233d3550",
                UserName = "+79992223344",
                NormalizedUserName = "+79992223344",
                PasswordHash = "AQAAAAIAAYagAAAAEAAzwIIJ7o+25+Nli/i/63N8avxOZfm83jrXrIIjDRaVoEoLkKdOuHfV2GyG5qyk7A==",
                SecurityStamp = "JH55KYKEOCNN43P2CQ74KMJN5PCLTBQN",
                ConcurrencyStamp = "91707dbb-f012-4c89-9e3c-842fd7b4a4cf"
            }
        });
        
        base.OnModelCreating(modelBuilder);
        modelBuilder.Ignore<IdentityUserLogin<string>>();
    }
}