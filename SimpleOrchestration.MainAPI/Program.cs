using SimpleOrchestration.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/", () => "Hello, World from MainAPI!");
app.MapDefaultEndpoints();

app.Run();