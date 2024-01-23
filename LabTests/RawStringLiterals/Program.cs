const string firstName="Karina";
const string jsonTextNew=$$"""
                         {
                         "firstName":"{{firstName}}"
                         }
                         """;

const string jsonTextOld=$"{{\n"+
                       $"\"firstName\":\"{firstName}\""+
                       $"\n}}";


Console.WriteLine("jsonTextNew:\n"+jsonTextNew);
Console.WriteLine("jsonTextOld:\n"+jsonTextOld);