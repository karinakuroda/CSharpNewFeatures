# CSharp 7

## [Anonymous Types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types)
>Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object without having to explicitly define a type first.

It can be useful when performing validations:

From:
```csharp
if (timesheet == null)
{
    throw new NotFoundException(Messages<Timesheet>.IsNull());
}
```
To:
```csharp
_ = timesheet ?? throw new NotFoundException(Messages<Timesheet>.IsNull());
```


Before:


```csharp
[InlineData(null, new int[] { 9053 })]
```
After:


```csharp
[InlineData(null, new[] { 9053 })]
```
Before:


```csharp
private readonly Fixture fixture = new Fixture();
```
After:


```csharp
private readonly Fixture fixture = new();
```
Before:


```csharp
private readonly List<string> locationIdsFromGateway = new List<string>();
```
After:


```csharp
private readonly List<string> locationIdsFromGateway = new();
```
 