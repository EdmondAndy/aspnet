# ASP.NET Core Sample Projects

This repository contains multiple ASP.NET Core projects and examples, demonstrating middleware, routing, controllers, static files, and more. Each folder is a self-contained sample or learning module.

### UseWhen

- Demonstrates conditional middleware logic using the `UseWhen` extension.

### WebApp

- A simple web application for further extension and experimentation.

### Environments

- Demonstrates environment-specific configuration and usage in ASP.NET Core projects. See `Environments/MyEnvironments` for examples of using `appsettings.json` and `appsettings.Development.json` to manage settings for different environments (Development, Production, etc).

### SocialMediaLinks

- Contains examples for managing and displaying social media links in ASP.NET Core apps. See `SocialMediaLinks/MySocialMediaLinks` for sample code and configuration for handling social media URLs, icons, and environment-specific settings.


-### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- macOS, Windows, or Linux

-### Build and Run

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


-### Folder Details
- `appsettings.json` and `appsettings.Development.json`: Configuration files for each project.
- `Program.cs`: Main entry point for each application.
- `Properties/launchSettings.json`: Debug and launch settings.
- `Controllers/`: Contains controller classes for handling HTTP requests.
- `wwwroot/`: Static files (PDFs, images, etc.) served by the app.

- `Environments/`: Contains projects and examples for environment-based configuration and settings.


-### Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

-### License
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
