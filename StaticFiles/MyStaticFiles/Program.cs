var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // For the wwwroot folder

app.MapGet("/", () => "Hello World!");

app.Run();
