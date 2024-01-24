namespace ValueTaskBenchmark;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class ValueTaskBenchmark
{
    [Benchmark]
    public Task<bool> GetValueFromTask()
    {
        return Task.Run(() =>
        {
            Task.Delay(20);
            return true;
        });
    }
    
    [Benchmark]
    public ValueTask<bool> GetValueFromValueTask()
    {
        return new ValueTask<bool>(Task.Run(() =>
        {
            Task.Delay(20);
            return true;
        }));
    }
}