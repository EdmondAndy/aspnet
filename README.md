# ASP.NET Core Sample Projects

This repository contains multiple ASP.NET Core projects and examples, demonstrating middleware, routing, controllers, static files, and more. Each folder is a self-contained sample or learning module.

## Structure

- **Controllers/**
  - `MyBankingApp/`: Banking app with controllers for account details and statements.
  - `MyControllers/`: Example controllers and models.
  - `MyIActionResult/`: Demonstrates IActionResult usage in controllers.
- **MiddleWare/**
  - `MyMiddleware/`: Custom middleware implementation and usage.
  - `CustomMiddleware/`: Contains custom middleware classes (e.g., HelloCustomMiddleware).
- **Routing/**
  - `MyRouting/`: Custom routing and constraints examples.
- **StaticFiles/**
  - `MyStaticFiles/`: Serving static files in ASP.NET Core.
- **UseWhen/**
  - `MyUseWhen/`: Conditional middleware execution using `UseWhen`.
- **WebApp/**
  - `MyWebApp/`: Basic ASP.NET Core web application.

## Projects

### Controllers
- Demonstrates controller actions, route parameters, returning JSON, files, and custom responses.

### Middleware
- Shows how to create and use custom middleware in ASP.NET Core.

### Routing
- Examples of custom routing, constraints, and route handling.

### Static Files
- How to serve static files (e.g., PDFs, images) from the `wwwroot` folder.

### UseWhen
- Demonstrates conditional middleware logic using the `UseWhen` extension.

### WebApp
- A simple web application for further extension and experimentation.

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- macOS, Windows, or Linux

### Build and Run

1. Clone the repository:

   ```sh
   git clone https://github.com/EdmondAndy/aspnet.git
   cd aspnet
   ```

2. Build a project (example for MyMiddleware):

   ```sh
   dotnet build MiddleWare/MyMiddleware/MyMiddleware.csproj
   ```

   You can build other projects similarly by specifying their `.csproj` file.

3. Run a project (example for MyWebApp):

   ```sh
   dotnet run --project WebApp/MyWebApp/MyWebApp.csproj
   ```

   Replace the project path as needed for other samples.

## Folder Details

- `appsettings.json` and `appsettings.Development.json`: Configuration files for each project.
- `Program.cs`: Main entry point for each application.
- `Properties/launchSettings.json`: Debug and launch settings.
- `Controllers/`: Contains controller classes for handling HTTP requests.
- `wwwroot/`: Static files (PDFs, images, etc.) served by the app.

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License.

## Projects


### 1. MyMiddleware

Implements custom middleware components for ASP.NET Core. Useful for learning how to intercept and process HTTP requests.

### 2. MyUseWhen

Shows how to use the `UseWhen` extension to conditionally apply middleware based on request criteria.

### 3. MyWebApp

A simple web application built with ASP.NET Core, suitable for further extension and experimentation.

## Getting Started


### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- macOS, Windows, or Linux

### Build and Run


1. Clone the repository:

  ```sh
  git clone https://github.com/EdmondAndy/aspnet.git
  cd aspnet
  ```

2. Build a project:

  ```sh
  dotnet build MiddleWare/MyMiddleware/MyMiddleware.csproj
  dotnet build UseWhen/MyUseWhen/MyUseWhen.csproj
  dotnet build WebApp/MyWebApp/MyWebApp.csproj
  ```

3. Run a project:

  ```sh
  dotnet run --project MiddleWare/MyMiddleware/MyMiddleware.csproj
  dotnet run --project UseWhen/MyUseWhen/MyUseWhen.csproj
  dotnet run --project WebApp/MyWebApp/MyWebApp.csproj
  ```

## Folder Details


- `appsettings.json` and `appsettings.Development.json`: Configuration files for each project.
- `Program.cs`: Main entry point for each application.
- `Properties/launchSettings.json`: Debug and launch settings.

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License.
