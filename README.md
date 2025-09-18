# ASP.NET Middleware and WebApp Examples

This repository contains sample ASP.NET Core projects demonstrating custom middleware, conditional request handling, and basic web application setup. It is organized into three main folders:

## Structure

- **MiddleWare/**
  - `MyMiddleware/`: Example of custom middleware implementation.
  - `CustomMiddleware/`: Contains custom middleware classes.
- **UseWhen/**
  - `MyUseWhen/`: Demonstrates conditional middleware execution using `UseWhen`.
- **WebApp/**
  - `MyWebApp/`: Basic ASP.NET Core web application.

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
