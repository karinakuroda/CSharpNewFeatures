# CSharp 10

## [File Scoped Namespace Declaration](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#file-scoped-namespace-declaration)
>You can use a new form of the namespace declaration to declare that all declarations that follow are members of the declared namespace

>No need to add the namespace curly braces!

From:
```csharp
namespace Customers
{
    using System.Threading.Tasks;

    public class CustomerDocumentHandler : IMessageHandler<CustomerDocument>
    {
    }
}
```

To:
```csharp
namespace Customers;

using System.Threading.Tasks;

public class CustomersDocumentHandler : IMessageHandler<CustomerDocument>
{
}
```


> File scoped namespaces can't include additional namespace declarations. You cannot declare a nested namespace or a second file-scoped namespace!

