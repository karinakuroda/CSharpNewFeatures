# CSharp 11

## [Raw String Literals](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#raw-string-literals)

> Raw string literals are a new format for string literals. 
> 
>Raw string literals can contain arbitrary text, including whitespace, new lines, embedded quotes, and other special characters without requiring escape sequences. 
> 
>A raw string literal starts with at least three double-quote (""") characters. It ends with the same number of double-quote characters.

Example using interpolated raw string literals

From:
```csharp
var firstName = "Karina";
var jsonTextOld = $"{{\n" +
                  $"\"firstName\": \"{firstName}\"" +
                  $"\n}}";
```

To:
```csharp
var firstName = "Karina";
var jsonTextNew = $$"""
                {
                    "firstName": "{{firstName}}"
                }
                """;
```

>To embed { and } characters in the result string, start an interpolated raw string literal with multiple $ characters. When you do that, any sequence of { or } characters shorter than the number of $ characters is embedded in the result string.

Its easier to understand and not only that, it keeps the identation as you can see below:

jsonTextOld:
```csharp
"{\n\"firstName\": \"Karina\"\n}"
```

jsonTextNew
```csharp
" {\n     \"firstName\": \"Karina\"\n }"
```