using TeamScore.Model;
using TeamScore.ProcessLine;
using TeamScore.ReadFile;

const string path = "./TeamScore/ReadFile/socker.dat";

var rawLines = new ReadDatFile(path).ReadFile(); //It will Keep the file open while iterating, good when you have a huge file that would occupy a lot of mem space, otherwise add the ToList()
var lines = new RemoveUnwantedCharacters(rawLines).Apply();
var teamScores = ModelMapper.ToTeamScores(lines);
var teamScoresOrdered = teamScores.GetScoresOrderByMinDiff().ToList();

Console.WriteLine($"The smallest difference between F and A is { teamScoresOrdered.First().Name }");
foreach (var teamScore in teamScoresOrdered)
{
    Console.WriteLine("{0,11}{1,5} - {2,5} = {3,5}",
        teamScore.Name,
        teamScore.F,
        teamScore.A,
        teamScore.Diff);
}