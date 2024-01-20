# CSharp 10

## [Record Struct](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#record-structs)
>C#10 adds record structs so that you can define records as value types.


E.g:
```csharp
public readonly record struct Money(double amount, string currency);
```
