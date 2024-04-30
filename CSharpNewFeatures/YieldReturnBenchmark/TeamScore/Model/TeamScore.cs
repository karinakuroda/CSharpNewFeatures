namespace TeamScore.Model;

public class TeamScore
{
    public required string Name { get; init; }
    public required int P { get; init; }
    public required int W { get; init; }
    public required int L { get; init; }
    public required int D { get; init; }
    public required int F { get; init; }
    public required int A { get; init; }
    public required int P2 { get; init; }

    public int Diff => this.F - this.A;
}