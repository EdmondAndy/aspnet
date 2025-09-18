var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

//data
Dictionary<int, string> countries = new()
{
    {1, "USA"},
    {2, "Canada"},
    {3, "Mexico"},
    {4, "Brazil"},
    {5, "Argentina"}
};

//endpoints
app.UseEndpoints(endpoints =>
{
    //Route 1: when request path is "/countries" (list all countries)
    endpoints.MapGet("/countries", async context =>
    {
        foreach (var country in countries)
        {
            await context.Response.WriteAsync($"Id: {country.Key}, Name: {country.Value}");
        }
    });

    //Route 2: when request path is "/countries/{countryID}" (get country by ID)
    endpoints.MapGet("/countries/{countryID:int:range(1,100)}", async context =>
    {
        //read countryID from RouteValues
        int countryID = Convert.ToInt32(context.Request.RouteValues["countryID"]);
        if (countries.ContainsKey(countryID))
        {
            await context.Response.WriteAsync($"Id: {countryID}, Name: {countries[countryID]}");
        }
        else
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync("Country not found");
        }

        //Route 3: when request path is "/countries/{countryID}" for IDs greater than 100
        endpoints.MapGet("/countries/{countryID:int:min(101)}", async context =>
        {
            context.Response.StatusCode = 400;
            await context.Response.WriteAsync("Country ID must be between 1 and 100");
        });

        //Default middleware
        app.Run(async context =>
        {
            await context.Response.WriteAsync("No Response");
        });
    });
});

app.Run();
