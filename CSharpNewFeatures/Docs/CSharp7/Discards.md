# CSharp 7

## [Discards](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/discards)
>Discards (_) are placeholder variables that are intentionally 
> unused in application code. Discards are equivalent to 
> unassigned variables; they don't have a value. 
> A discard communicates intent to the compiler and others that 
> read your code: You intended to ignore the result of an 
> expression.

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
