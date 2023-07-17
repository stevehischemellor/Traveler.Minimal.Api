// implement REPR pattern

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (IHttpClientFactory httpClientFactory) => "Hello World!");

app.Run();
