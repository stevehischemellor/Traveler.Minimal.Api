global using FastEndpoints;
using Traveler.Minimal.Api.Data;
using Traveler.Minimal.Api.Services;

// implement REPR pattern

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("JournalsDatabase"));
builder.Services.AddSingleton<JournalsService>();

var app = builder.Build();

app.MapGet("/", (IHttpClientFactory httpClientFactory) => "Hello World!");

app.UseFastEndpoints();

app.Run();
