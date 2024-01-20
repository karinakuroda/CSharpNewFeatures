# CSharp 10

## [Implicit Global Using Directive](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview#implicit-using-directives)

>C# 10 includes a new global using directive and implicit usings to reduce the number of usings you need to specify at the top of each file.

>Implicit global using directives are added for projects that use one of the following SDKs:
> - Microsoft.NET.Sdk
> - Microsoft.NET.Sdk.Web
> - Microsoft.NET.Sdk.Worker
> - Microsoft.NET.Sdk.WindowsDesktop

>A global using directive is added for each namespace in a set of default namespaces that are based on the project's SDK. 

So, by changing the csproj file:

From:
```csharp
<PropertyGroup>
	<ImplicitUsings>enable</ImplicitUsings>
</PropertyGroup>
```

I’m now able to remove the System using's from the namespace:

To:
```csharp
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
 ```



| SDK               | Default namespaces |
|-------------------| ------ |
| Microsoft.NET.Sdk |System|
|                   |System.Collections.Generic|
|                   |System.IO|
|                   |System.Linq|
|                   |System.Net.Http|
|                   |System.Threading|
|                   |System.Threading.Tasks |
| Microsoft.NET.Sdk.Web |System.Net.Http.Json|
|                   |Microsoft.AspNetCore.Builder|
|                   |Microsoft.AspNetCore.Hosting|
|                   |Microsoft.AspNetCore.Http|
|                   |Microsoft.AspNetCore.Routing|
|                   |Microsoft.Extensions.Configuration|
|                   |Microsoft.Extensions.DependencyInjection|
|                   |Microsoft.Extensions.Hosting|
|                   |Microsoft.Extensions.Logging|

>Check the complete default namespaces table here: https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview#implicit-using-directives
