# CSharp 12

## [Primary Constructors](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/primary-constructors)

>Primary constructors put the parameters of one constructor in scope for the whole class or struct to be used for initialization or directly as object state. The trade-off is that any other constructors must call through the primary constructor.

From:

```csharp
public class Customer
{
    private Customer()
    {
    }
    
    public Customer(string firstName, int yearOfBirth)
    {
         this.FirstName = firstName;
         this.YearOfBirth = yearOfBirth;
    }

    public string FirstName { get; private set; }

    public int YearOfBirth { get; private set; }
}
```

To:

```csharp
public class Customer(string firstName, int yearOfBirth)
{
    public string FirstName { get; init; } = firstName;
    public int YearOfBirth { get; init; } = yearOfBirth;
}
```
No need to create a new constructor, similar to record types.

---

If it were a record type then there is no need to create each property, 
but notice that the following code will generate a ctor to initialize both properties, meaning that no empty constructor will be available.

```csharp
public record Customer(string FirstName, int YearOfBirth);
```

If you still need a parameterless constructor, then you can create your record using required+init keyword:
```csharp
public record Customer
{
    public required string FirstName { get; init; }

    public required int YearOfBirth { get; init; }
}
```