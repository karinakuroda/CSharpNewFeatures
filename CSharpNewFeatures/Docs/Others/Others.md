
# Others

## Declaration and type patterns
>You use declaration and type patterns to check if the run-time type of an expression is compatible with a given type. With a declaration pattern, you can also declare a new local variable. When a declaration pattern matches an expression, that variable is assigned a converted expression result
```csharp
object greeting = "Hello, World!";
if (greeting is string message)
{
    Console.WriteLine(message.ToLower());  // output: hello, world!
}
```

## Using Null check pattern C#8

```csharp
if (value is {}) 
{
    Console.WriteLine(“value is not null.”);
}
```

- ### References:
- [Microsoft learn](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#declaration-and-type-patterns)
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is