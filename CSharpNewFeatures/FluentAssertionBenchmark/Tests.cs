using BenchmarkDotNet.Attributes;
using FluentAssertions;
using Xunit;

public class House
{
    public string Name { get; set; }
    public int Number { get; set; }
    public string Street { get; set; }
}

public class HouseDto
{
    public string name { get; set; }
    public int number { get; set; }
    public string street { get; set; }
}

public class Tests
{
    private readonly House _house = new() { Name = "House1", Number = 1, Street = "Street123"};
    private readonly HouseDto _houseDto = new() { name = "House1", number = 1, street = "Street123" };
    
    [Benchmark]
    public void TestUsingBeEquivalentTo()
    {
        this._house.Should()
            .BeEquivalentTo(this._houseDto, opt => opt
                .WithMapping<HouseDto, House>(p=>p.name, exp=>exp.Name)
                .WithMapping<HouseDto, House>(p=>p.street, exp=>exp.Street)
                .WithMapping<HouseDto, House>(p=>p.number, exp=>exp.Number));
    }
    
    [Benchmark]
    public void TestUsingBe()
    {
        this._houseDto.name.Should().Be(this._house.Name);
        this._houseDto.number.Should().Be(this._house.Number);
        this._houseDto.street.Should().Be(this._house.Street);
    }
    
    [Benchmark]
    public void TestUsingOnlyXUnit()
    { 
        Assert.Equal( this._houseDto.name, this._house.Name);
        Assert.Equal( this._houseDto.number, this._house.Number);
        Assert.Equal( this._houseDto.street, this._house.Street);
    }
}