namespace TeamScore.ProcessLine;

using System.Collections;

public class ArrayJoin
{
    public ArrayJoin(IReadOnlyList<string> filteredLine)
    {
        this.FilteredLine = filteredLine;
    }
    private IReadOnlyList<string> FilteredLine { get; }
    
    public string[] JoinNameWithWhitespace()
    {
        var result = new ArrayList();
        for (var i = 0; i < this.FilteredLine.Count; i++)
        {
            if (this.CurrentAndNextHasLetter(i))
            {
                result.Add($"{this.FilteredLine[i]} {this.FilteredLine[i + 1]}");
                continue;
            }

            if (this.FilteredLine[i].Any(char.IsNumber))
            {
                result.Add(this.FilteredLine[i]);
            }
        }

        return (string[])result.ToArray(typeof(string));
    }

    private bool CurrentAndNextHasLetter(int i)
    {
        return this.FilteredLine[i].Any(char.IsLetter) && 
               this.FilteredLine[i + 1].Any(char.IsLetter);
    }
}