var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Routing is automatically enabled.
//Endpoints are defined directly on the app object

app.MapGet("/map1", async (context) =>
{ 
    await context.Response.WriteAsync("Hello from Map 1!");
});

app.MapGet("/map2", async (context) =>
{
    await context.Response.WriteAsync("Hello from Map 2!");
});

// Eg: files/sample.txt
app.Map("/files/{filename}.{extension}", async (context) =>
{
    string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
    string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
    await context.Response.WriteAsync($"You requested the file: {filename}.{extension}");
});

app.Map("/employee/profile/{employeename=scott}", async (context) =>
{
    string? employeename = Convert.ToString(context.Request.RouteValues["employeename"]);
    await context.Response.WriteAsync($"Employee Profile Page of {employeename}");
});

app.Map("/product/details/{id=1}" , async (context) =>
{
    string? id = Convert.ToString(context.Request.RouteValues["id"]);
    await context.Response.WriteAsync($"Product Details of ID: {id}");
});

// optional route parameter
app.Map("/product/detail/{id?}", async (context) =>
{
    if (!context.Request.RouteValues.ContainsKey("id"))
    {
        await context.Response.WriteAsync("No ID was provided");
        return;
    }
    string? id = Convert.ToString(context.Request.RouteValues["id"]);
    await context.Response.WriteAsync($"Product Details of ID: {id}");
});

//Fallback for any other requests
app.MapFallback(async (context) =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();
