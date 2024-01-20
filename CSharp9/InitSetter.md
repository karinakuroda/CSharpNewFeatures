# CSharp 10

## [Init-only Setter](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/init)
>An init-only setter assigns a value to the property or the indexer element **_only_** during object construction. 
> 
>An init enforces **_immutability_** so that once the object is initialized, it can't be changed. 
> 
>An init accessor enables calling code to use an object initializer to set the initial value.

### Example:
I want to make the property "YearOfBirth" immutable, meaning that you can only initialize when creating the object, after that you cannot change it anymore:

From:
```csharp
public class Customer
{
    public int YearOfBirth { get; private set; }
}
```
To:
```csharp
public class Customer
{
    public int YearOfBirth { get; init; }
}
```


------
### Another example:
When using the "**required**" keyword your property must be public or init-only:

From:
```csharp
public class Customer
{
    public Customer(int yearOfBirth)
    {
        this.YearOfBirth = yearOfBirth;
    }

    public int YearOfBirth { get; }
}
```
To:
```csharp
public class Customer
{
    public required int YearOfBirth { get; init; }
}

```
The code after is equivalent to the code before.

By making the property **required** I'm now able to remove the constructor.

The property is also immutable.