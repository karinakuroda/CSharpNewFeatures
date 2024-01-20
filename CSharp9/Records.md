# CSharp 9

## [Records](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record)
>Records are types that use value-based equality (Note:  is still a reference type!)
You use the record modifier to define a reference type that provides built-in functionality for encapsulating data. C# 10 allows the record class syntax as a synonym to clarify a reference type, and record struct to define a value type with similar functionality.

The record type is useful whenever we are dealing with a value object:
From

From:
```csharp
public class Money : ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return this.Amount;
        yield return this.Currency;
    }
...
```

To:
```csharp
public record Money
{
...
}
```
**No need to manually implement the properties comparison, operators, or even the Equals() override.** 

Note: ValueObject.cs class and GetEquality methods now can be removed!