
using Traveler.Minimal.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<JournalsService>();

var app = builder.Build();


app.MapPost("/", () => "Hello World!");



app.Run();


//builder.Services.AddAuthentication();

//var app = builder.Build();

//app.UseAuthentication();
//app.UseAuthorization();

//app.Run();
