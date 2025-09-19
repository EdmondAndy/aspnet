var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //add all controllers classes as services

var app = builder.Build();
app.MapControllers(); //map all controller classes to routes
app.Run();
