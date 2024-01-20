# CSharp 10

## [Required Members](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/init)
>You can add the **_required_** modifier to properties and fields to enforce constructors and callers to initialize those values.

The required is useful in the case of DTO’s, where there is no need to create a constructor, instead, we mark the property as required and whenever a new instance is being created it will validate this field.
Example:

```csharp

```