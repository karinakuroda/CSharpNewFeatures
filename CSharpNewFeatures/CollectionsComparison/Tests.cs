using AutoFixture;
using BenchmarkDotNet.Attributes;

public class House
{
    public string Name { get; set; }
    public int Number { get; set; }
    public string Street { get; set; }
    public ICollection<Member> Members { get; set; }
}

public class Member
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Job> Jobs { get; set; }
}

public class Job
{
    public string Name { get; set; }
    public double Salary { get; set; }
    
}

public class Tests
{
    private readonly Fixture _fixture = new();
    private const int HousesCount = 1500;

    private void PrintValues(House house)
    {
        Console.WriteLine(house.Name);
        foreach (var member in house.Members)
        {
            Console.WriteLine(member.Name);
            foreach (var job in member.Jobs)
            {
                Console.WriteLine(job.Name); 
            }
           
        }
    }
    [Benchmark]
    public void TestUsingIEnumerable()
    {
        IEnumerable<House> _houses = this._fixture.CreateMany<House>(HousesCount);
        foreach (var house in _houses)
        {
            this.PrintValues(house);
        }
    }
    
    [Benchmark]
    public void TestUsingIEnumerableMaterialized()
    {
        IEnumerable<House> _houses = this._fixture.CreateMany<House>(HousesCount);
        foreach (var house in _houses.ToList())
        {
            this.PrintValues(house);  
        }
    }
    
    [Benchmark]
    public void TestUsingICollection()
    {
        ICollection<House> _houses = this._fixture.CreateMany<House>(HousesCount).ToList();
        foreach (var house in _houses)
        {
            this.PrintValues(house);  
        }
    }
    
    [Benchmark]
    public void TestUsingIList()
    {
        IList<House> _houses = this._fixture.CreateMany<House>(HousesCount).ToList();
        foreach (var house in _houses)
        {
            this.PrintValues(house);  
        }
    }
}