public record Member(string Name, string PhoneNumber);
public record House
{
    public IEnumerable<Member> GetMembers()
    {
        //Console.WriteLine("Called GetMembers()"); //Will be called just in the first time!
        var fileRead = File.ReadAllLines("./Members.csv");
        return fileRead.Select(s =>
        {
            // Console.WriteLine("Called GetMembers select"); //Will be called every time 
            var line = s.Split(",");
            return new Member(line[0], line[1]);
        });
    }
    
    public IEnumerable<Member> GetMembersYieldReturn()
    {
        // Console.WriteLine($"Called {nameof(this.GetMembersYieldReturn)}"); //Will be called every time

        var fileRead = File.ReadAllLines("./Members.csv");

        foreach (var file in fileRead)
        {
            var line = file.Split(",");
            // Console.WriteLine($"Called {nameof(this.GetMembersYieldReturn)} yield return");
            yield return new Member(line[0], line[1]);
        }
    }
}