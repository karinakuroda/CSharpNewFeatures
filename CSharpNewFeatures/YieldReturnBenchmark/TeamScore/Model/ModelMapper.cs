namespace TeamScore.Model;

public static class ModelMapper
{
    public static TeamScores ToTeamScores(IEnumerable<string[]> translatedFile)
    {
        return new TeamScores(translatedFile.Select(row => 
            new TeamScore
        {
            Name = row[0],
            P = int.Parse(row[1]),
            W = int.Parse(row[2]),
            L = int.Parse(row[3]),
            D = int.Parse(row[4]),
            F = int.Parse(row[5]),
            A = int.Parse(row[6]),
            P2 = int.Parse(row[7])
        }));
    }
}