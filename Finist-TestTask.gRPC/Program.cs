using Finist_TestTask.BLL.DI;
using Finist_TestTask.DAL.DI;
using Finist_TestTask.gRPC.Services;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services
    .AddApplicationServices()
    .AddApplicationDataBase(builder.Configuration.GetConnectionString("ApplicationDatabase")!);

builder.Services.AddGrpc();

var app = builder.Build();

//Применение новых миграций автоматически
app.Services.ApplyMigrations();

// Configure the HTTP request pipeline.
app.MapGrpcService<ClientService>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();