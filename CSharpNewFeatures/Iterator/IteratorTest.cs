namespace Iterator;

public class IteratorTest
{
    [Fact]
    public void TestComparison()
    {
        foreach (int i in TestIterator.GetValuesWithoutIterator())
        { 
            Console.WriteLine(i); 
        }

        foreach (int i in TestIterator.GetValuesWithIterator())
        { 
            Console.WriteLine(i); 
        }
    }
}

public static class TestIterator
{
    public static IEnumerable<int> GetValuesWithoutIterator()
    {
        return new List<int>() { 1, 2, 3 };
    }

    public static IEnumerable<int> GetValuesWithIterator()
    {
        // This method returns values lazily using an iterator
        // It reads values one at a time and continues from where it left off
        // This can be useful when you have a large list that needs to be read sequentially
        // and you only need to process a portion of it at a time
        yield return 1;
        yield return 2;
        yield return 3;
    }
}