# .NET 8

## [System.Random.GetItems](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/discards)
>The new System.Random.GetItems and System.Security.Cryptography.RandomNumberGenerator.GetItems methods let you randomly choose a specified number of items from an input set

Example of use:
```csharp
public static class StringGenerator
{
    private static string chars = "ABCDEF12345";

    public static string Generate(int limitChars)
    {
        var randomChars = System.Random.Shared.GetItems(chars.ToCharArray(), limitChars);
        return new(randomChars);
    }
}
```