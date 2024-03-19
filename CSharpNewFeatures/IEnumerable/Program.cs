var test = new Tests();
test.TestUsingIEnumerable();
//test.TestUsingIEnumerableYieldReturn();
//test.TestUsingIEnumerableMaterialized();

public class Tests
{
    public void TestUsingIEnumerable()
    {
        var house = new House();
        var members = house.GetMembers();
        
        //.Count() and Foreach loop will call the GetMembers() method again
        Console.WriteLine("total members:" + members.Count());
        foreach (var member in members)
        {
            Console.WriteLine(member.Name);
            Console.WriteLine(member.PhoneNumber);
        }
    }

    public void TestUsingIEnumerableYieldReturn()
    {
        var house = new House();
        var members = house.GetMembersYieldReturn();
        Console.WriteLine("total members:" + members.Count());
        foreach (var member in members)
        {
            Console.WriteLine(member.Name);
            Console.WriteLine(member.PhoneNumber);
        }
    }

    public void TestUsingIEnumerableMaterialized()
    {
        var house = new House();
        var members = house.GetMembers().ToList();
        Console.WriteLine("total members:" + members.Count());
        foreach (var member in members)
        {
            Console.WriteLine(member.Name);
            Console.WriteLine(member.PhoneNumber);
        }
    }
}