using RoutingExample.CustomConstraints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(
    options =>
    {
        options.ConstraintMap.Add("months", typeof(MonthsCustomConstraint));
    }
);
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

app.Map("/employee/profile/{employeename:minlength(3)=scott}", async (context) =>
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
// route constraints
app.Map("/product/detail/{id:int?}", async (context) =>
{
    if (!context.Request.RouteValues.ContainsKey("id"))
    {
        await context.Response.WriteAsync("No ID was provided");
        return;
    }
    string? id = Convert.ToString(context.Request.RouteValues["id"]);
    await context.Response.WriteAsync($"Product Details of ID: {id}");
});

app.Map("/order/details/{id:guid}", async (context) =>
{
    string? id = Convert.ToString(context.Request.RouteValues["id"]);
    await context.Response.WriteAsync($"Order Details of ID: {id}");
});

app.Map("sales-report/{year:int:min(1900)}/{month:months}", async (context) =>
{
    string? year = Convert.ToString(context.Request.RouteValues["year"]);
    string? month = Convert.ToString(context.Request.RouteValues["month"]);
    await context.Response.WriteAsync($"Sales Report of {month}, {year}");
});

//Fallback for any other requests
app.MapFallback(async (context) =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();
