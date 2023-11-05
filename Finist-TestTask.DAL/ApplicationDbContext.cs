using Finist_TestTask.Domain.Models.Account.Base;
using Finist_TestTask.Domain.Models.Account.Implementation;
using Finist_TestTask.Domain.Models.Client;
using Microsoft.EntityFrameworkCore;

namespace Finist_TestTask.DAL;

public class ApplicationDbContext : DbContext
{
    public virtual DbSet<CardAccount> CardAccounts { get; set; } = null!;
    public virtual DbSet<DemandAccount> DemandAccounts { get; set; } = null!;
    public virtual DbSet<ExpressAccount> ExpressAccounts { get; set; } = null!;
    public virtual DbSet<Client> Clients { get; set; } = null!;
    
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public ApplicationDbContext()
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardAccount>().HasData(new CardAccount[]
        {
            new CardAccount
            {
                AccountNumber = "42305840513000000112",
                Id = Guid.Parse("17a390db-bcbb-40e1-a4d8-fca984296efd"),
                UserId = Guid.Parse("9e8aab80-4ab5-4177-99e8-0bdeed2885cd")
            },
            new CardAccount
            {
                AccountNumber = "93567840589112300112",
                Id = Guid.Parse("762728d8-fbe2-4374-9968-8131aa57b8f2"),
                UserId = Guid.Parse("46a7b9cd-1de8-4777-aa4e-edff233d3550")
            },
        });
        
        modelBuilder.Entity<DemandAccount>().HasData(new DemandAccount[]
        {
            new DemandAccount
            {
                AccountNumber = "71642567061085536844",
                Id = Guid.Parse("f64cad21-cb98-4d23-bd43-ee483ac6ee9f"),
                UserId = Guid.Parse("9e8aab80-4ab5-4177-99e8-0bdeed2885cd")
            },
            new DemandAccount
            {
                AccountNumber = "69756952598567995321",
                Id = Guid.Parse("05f3c60f-f9fa-401e-ad0f-b2202a538371"),
                UserId = Guid.Parse("46a7b9cd-1de8-4777-aa4e-edff233d3550")
            },
        });
        
        modelBuilder.Entity<ExpressAccount>().HasData(new ExpressAccount[]
        {
            new ExpressAccount
            {
                AccountNumber = "70152631400678905460",
                Id = Guid.Parse("20229757-84fd-4c55-946e-c5c65ab7d093"),
                UserId = Guid.Parse("9e8aab80-4ab5-4177-99e8-0bdeed2885cd")
            },
            new ExpressAccount
            {
                AccountNumber = "00365680679007776789",
                Id = Guid.Parse("3e13e435-573a-4513-96d8-0cb5e7f43750"),
                UserId = Guid.Parse("46a7b9cd-1de8-4777-aa4e-edff233d3550")
            },
        });

        modelBuilder.Entity<Client>().HasData(new Client[]
        {
            new Client
            {
                Id = Guid.Parse("9e8aab80-4ab5-4177-99e8-0bdeed2885cd"),
                CardAccountId = Guid.Parse("17a390db-bcbb-40e1-a4d8-fca984296efd"),
                DemandAccountId = Guid.Parse("f64cad21-cb98-4d23-bd43-ee483ac6ee9f"),
                ExpressAccountId = Guid.Parse("20229757-84fd-4c55-946e-c5c65ab7d093"),
                Name = "Тест2",
                SecondName = "Тестов2",
                Patronymic = "Тестович2",
                PhoneNumber = "+79980007633"
            },
            new Client
            {
                Id = Guid.Parse("46a7b9cd-1de8-4777-aa4e-edff233d3550"),
                CardAccountId = Guid.Parse("762728d8-fbe2-4374-9968-8131aa57b8f2"),
                DemandAccountId = Guid.Parse("05f3c60f-f9fa-401e-ad0f-b2202a538371"),
                ExpressAccountId = Guid.Parse("3e13e435-573a-4513-96d8-0cb5e7f43750"),
                Name = "Тест",
                SecondName = "Тестов",
                Patronymic = "Тестович",
                PhoneNumber = "+79992223344"
            }
        });
        
        modelBuilder.HasDefaultSchema("public");
        base.OnModelCreating(modelBuilder);
    }
}