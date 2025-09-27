var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("redis")
    .WithRedisCommander();

var apiService = builder.AddProject<Projects.AspireStarterApp_ApiService>("apiservice")
    .WithHttpHealthCheck("/health")
    .WithReference(cache);

builder.AddProject<Projects.AspireStarterApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
