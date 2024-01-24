# CSharp 11

## [Required Members](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required)
>You can add the **_required_** modifier to properties and fields to enforce constructors and callers to initialize those values.

The required is useful in the case of DTO’s, where there is no need to create a constructor, instead, we mark the property as required and whenever a new instance is being created it will validate this field.
Example:

```csharp
    public class CustomerDto
    {
        public int Code { get; set; }
        public required int YearOfBirth { get; set; }
    }
```
![Screenshot 2024-01-20 at 12.24.06.png](..%2F..%2F..%2FScreenshot%202024-01-20%20at%2012.24.06.png)



Check also the use of required with init-only [**here**](../CSharp9/InitSetter.md)