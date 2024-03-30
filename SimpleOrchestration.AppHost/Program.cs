var builder = DistributedApplication.CreateBuilder(args);

var main = builder.AddProject<Projects.SimpleOrchestration_MainAPI>("main");
var admin = builder.AddProject<Projects.SimpleOrchestration_AdminAPI>("admin");

var apiGateway = builder.AddProject<Projects.SimpleOrchestration_APIGateway>("api-gateway")
    .WithReference(admin)
    .WithReference(main);

builder.Build().Run();