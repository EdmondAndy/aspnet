namespace MiddlewareExample.CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Custom logic before the next middleware
            await context.Response.WriteAsync("Hello from MyCustomMiddleware - Starts!\n");

            // Call the next middleware in the pipeline
            await next(context);
            await context.Response.WriteAsync("Hello from MyCustomMiddleware - Ends!\n");
            // Custom logic after the next middleware (if needed)
        }
    }

    // Custom Middleware Extension Method
    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyCustomMiddleware>();
        }
    }
}