# CSharp 7

## [Anonymous Types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types)
>Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object without having to explicitly define a type first.

Before:

```csharp
[InlineData(null, new int[] { 9999 })]
```
After:
```csharp
[InlineData(null, new[] { 9999 })]
```

---

Before:
```csharp
private readonly Fixture fixture = new Fixture();
```
After:
```csharp
private readonly Fixture fixture = new();
```

---
Before:
```csharp
private readonly List<string> names = new List<string>();
```
After:
```csharp
private readonly List<string> names = new();
```

---
Before:
```csharp
var v = new Customer { Title = "Hello", Age = 24 };
```
After:
```csharp
var v = new { Title = "Hello", Age = 24 };
```

