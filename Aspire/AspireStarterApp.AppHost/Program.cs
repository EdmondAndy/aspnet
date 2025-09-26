var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireStarterApp_ApiService>("apiservice")
    .WithHttpsHealthCheck("/health");

builder.AddProject<Projects.AspireStarterApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpsHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
