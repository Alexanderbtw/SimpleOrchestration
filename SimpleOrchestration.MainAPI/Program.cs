using SimpleOrchestration.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/", (HttpRequest request) => $"Hello, World from MainAPI! This is visible from route {request.Path}");
app.MapDefaultEndpoints();

app.Run();