namespace ValueTaskBenchmark;

public class ValueTaskBenchmark
{
    public Task<bool> GetValueFromTask()
    {
        return Task.Run(() =>
        {
            Thread.Sleep(20);
            return true;
        });
    }
    
    // public async ValueTask<bool> GetValueFromValueTask()
    // {
    //     var result = await Task.Run(() =>
    //     {
    //         Thread.Sleep(20);
    //         return true;
    //     });
    //     return new ValueTask<bool>(result);
    // }
}