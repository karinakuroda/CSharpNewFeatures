
# .NET 8

## [.NET ASPIRE](https://learn.microsoft.com/en-us/dotnet/aspire/)
>.NET Aspire is an opinionated, cloud ready stack for building observable, production ready, distributed applications.​ .NET Aspire is delivered through a collection of NuGet packages that handle specific cloud-native concerns. Cloud-native apps often consist of small, interconnected pieces or microservices rather than a single, monolithic code base. Cloud-native apps generally consume a large number of services, such as databases, messaging, and caching.

>.NET Aspire is designed to improve the experience of building .NET cloud-native apps. It provides a consistent, opinionated set of tools and patterns that help you build and run distributed apps.

>.NET Aspire components are NuGet packages designed to simplify connections to popular services and platforms, such as Redis or PostgreSQL. .NET Aspire components handle many cloud-native concerns for you through standardized configuration patterns, such as adding health checks and telemetry.

Example of adding Redis to your application:
```csharp
// Create a distributed application builder given the command line arguments.
var builder = DistributedApplication.CreateBuilder(args);

// Add a Redis server to the application.
var cache = builder.AddRedis("cache");
```

Another example
```csharp
builder.AddServiceDefaults();
```
>The AddServiceDefaults method handles the following concerns for you:
> - Configures OpenTelemetry metrics and tracing.
> - Add default health check endpoints.
> - Add service discovery functionality.
> - Configures HttpClient to work with service discovery.

Steps to create a demo:

```shell
dotnet workload update
dotnet workload install aspire
dotnet new aspire-starter --use-redis-cache --output AspireSample
dotnet run --project AspireSample/AspireSample.AppHost
  ```
- ### References:
- [Service Defaults](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/service-defaults)
- https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/setup-tooling?tabs=dotnet-cli#install-net-aspire
- https://learn.microsoft.com/en-us/dotnet/aspire/get-started/build-your-first-aspire-app?tabs=dotnet-cli#tabpanel_1_dotnet-cli
- 