using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    var firstNumber = "";
    var secondNumber = "";
    var operation = "";
    // System.IO.StreamReader reader = new StreamReader(context.Request.Body);
    // var body = await reader.ReadToEndAsync();
    context.Response.StatusCode = 200;
    // context.Response.Headers["Name"] = "Edmond";
    context.Response.ContentType = "text/plain";
    // await context.Response.WriteAsync("<h1>Hello World</h1>");
    // if (context.Request.Method == "GET")
    // {
    //     if (context.Request.Query.ContainsKey("name"))
    //     {
    //         context.Request.Query.TryGetValue("name", out var name);
    //         await context.Response.WriteAsync($"<p>Hello, {name}!</p>");
    //     }
    // }
    if (context.Request.Method == "GET")
    {
        if (context.Request.Query.ContainsKey("firstNumber"))
        {
            context.Request.Query.TryGetValue("firstNumber", out var value);
            firstNumber = value;
        }
        else
        {
            if (context.Response.StatusCode == 200)
            { 
                context.Response.StatusCode = 400;
            }
            string firstNumberResponseString = "Invalid input for 'firstNumber'\n";
            byte[] bytes = Encoding.UTF8.GetBytes(firstNumberResponseString);
            await context.Response.Body.WriteAsync(bytes);
        }
        if (context.Request.Query.ContainsKey("secondNumber"))
        {
            context.Request.Query.TryGetValue("secondNumber", out var value);
            secondNumber = value;
        }
        else
        {
            if (context.Response.StatusCode == 200)
            { 
                context.Response.StatusCode = 400;
            }
            string secondNumberResponseString = "Invalid input for 'secondNumber'\n";
            byte[] bytes = Encoding.UTF8.GetBytes(secondNumberResponseString);
            await context.Response.Body.WriteAsync(bytes);
        }
        if (context.Request.Query.ContainsKey("operation"))
        {
            context.Request.Query.TryGetValue("operation", out var value);
            operation = value;
        }
        else
        {
            if (context.Response.StatusCode == 200)
            { 
                context.Response.StatusCode = 400;
            }
            string operationResponseString = "Invalid input for 'operation'\n";
            byte[] bytes = Encoding.UTF8.GetBytes(operationResponseString);
            await context.Response.Body.WriteAsync(bytes);
        }
        if (int.TryParse(firstNumber, out _) && int.TryParse(secondNumber, out _)) {
            int num1 = int.Parse(firstNumber);
            int num2 = int.Parse(secondNumber);
            int result = 0;
            switch (operation)
            { 
                case "add":
                    result = num1 + num2;
                    await context.Response.WriteAsync($"<p>The result of adding {num1} and {num2} is {result}.</p>");
                    break;
                case "subtract":
                    result = num1 - num2;
                    await context.Response.WriteAsync($"<p>The result of subtracting {num2} from {num1} is {result}.</p>");
                    break;
                case "multiply":
                    result = num1 * num2;
                    await context.Response.WriteAsync($"<p>The result of multiplying {num1} and {num2} is {result}.</p>");
                    break;
                case "divide":
                    if (num2 != 0)
                    {
                        double divisionResult = (double)num1 / num2;
                        await context.Response.WriteAsync($"<p>The result of dividing {num1} by {num2} is {divisionResult}.</p>");
                    }
                    else
                    {
                        await context.Response.WriteAsync("<p>Error: Division by zero is not allowed.</p>");
                    }
                    break;
                default:
                    await context.Response.WriteAsync("<p>Invalid operation. Please use 'add', 'subtract', 'multiply', or 'divide'.</p>");
                    break;
            }
        }
    }
});

app.Run();