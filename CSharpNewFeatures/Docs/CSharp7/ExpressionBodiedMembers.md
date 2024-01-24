# CSharp 7

## [Expression-bodied members](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members)

>Expression body definitions let you provide a member's implementation in a concise, readable form. You can use an expression body definition whenever the logic for any supported member
>

Example in a constructor:

Before:

```csharp
public TimeEntry(TimeOnly start, TimeOnly end)
{
    this.SetTime(start, end);
}
```

After:
```csharp
public TimeEntry(TimeOnly start, TimeOnly end) => this.SetTime(start, end);
```


