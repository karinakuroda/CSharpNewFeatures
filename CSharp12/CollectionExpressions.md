# CSharp 12

## [Collection Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12#collection-expressions)

>Collection expressions introduce a new terse syntax to create common collection values. Inlining other collections into these values is possible using a spread operator ...

>You can use collection expressions anywhere you need a collection of elements. They can specify the initial value for a collection or be passed as arguments to methods that take collection types.

From:
```csharp
string[] actions = new[] { Actions.Read, Actions.ReadAll }
```
To:
```csharp
string[] actions = [Actions.Read, Actions.ReadAll]
```
---

Note: Is not possible to use with `var` keyword:
![Screenshot 2024-01-20 at 12.38.08.png](..%2F..%2F..%2FScreenshot%202024-01-20%20at%2012.38.08.png)