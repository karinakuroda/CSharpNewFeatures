# CSharp 7

## [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask-1?view=net-8.0)

> ValueTask is a struct, which means it is copied by value rather than by reference. 
> This can lead to unexpected behavior if you try to await it multiple times, store it in a field, or pass it around12. 

>You should only await a ValueTask once, and only directly after obtaining it from the source method.
  
>Should every new asynchronous API return ValueTask / ValueTask<TResult>?
> 
>In short, no: the default choice is still Task / Task<TResult>.

>Task and Task<TResult> are easier to use correctly than are ValueTask and ValueTask<TResult>, 
and so unless the performance implications outweigh the usability implications, Task / Task<TResult>are still preferred.
From:
```csharp
public async Task<bool> AnyWithTheSameNameAsync(string name)
{
    return await this.Context.Set<Customer>()
                             .AsQueryable()
                             .AnyAsync(cust => EF.Functions.Like(cust.Name, name));
}
```
To:
```csharp
public async ValueTask<bool> AnyWithTheSameNameAsync(string name)
{
    return await this.Context.Set<Customer>()
                             .AsQueryable()
                             .AnyAsync(cust => EF.Functions.Like(cust.Name, name));
}
```
### Reference:
https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new
https://devblogs.microsoft.com/dotnet/understanding-the-whys-whats-and-whens-of-valuetask/