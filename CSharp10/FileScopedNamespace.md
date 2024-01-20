# CSharp 10

## [File Scoped Namespace Declaration](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#file-scoped-namespace-declaration)
>You can use a new form of the namespace declaration to declare that all declarations that follow are members of the declared namespace
No need to add the namespace curly braces
Before


From:
```csharp
namespace Farfetch.MerchantTenant.Presentation.Messaging.Consumers.Handlers.MerchantLegal.V1
{
using System.Threading.Tasks;

    public class MerchantLegalDocumentHandler : IMessageHandler<MerchantLegalDocument>
    {
    }
}
```

To:
```csharp
namespace Farfetch.MerchantTenant.Presentation.Messaging.Consumers.Handlers.MerchantLegal.V1;

using System.Threading.Tasks;

public class MerchantLegalDocumentHandler : IMessageHandler<MerchantLegalDocument>
{
}
```