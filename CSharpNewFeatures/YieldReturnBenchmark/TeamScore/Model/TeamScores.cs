namespace TeamScore.Model;

public class TeamScores
{
    public IEnumerable<TeamScore> Scores { get; }
    
    public TeamScores(IEnumerable<TeamScore>? scores)
    {
        ArgumentNullException.ThrowIfNull(scores);
        
        this.Scores = scores;
    }
    
    public IOrderedEnumerable<TeamScore> GetScoresOrderByMinDiff()
    {
        return this.Scores.OrderBy(o => (Math.Abs(o.Diff)));
    }
}