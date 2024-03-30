using SimpleOrchestration.ServiceDefaults;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/", (HttpRequest request) => $"Hello, Admin from AdminAPI! This is visible from route {request.Path}");

app.MapGet("/about", (HttpRequest request) => $"This is about endpoint! This is visible from route {request.Path}");

app.Run();