namespace TeamScore.ProcessLine;

public class RemoveUnwantedCharacters
{
    private const int NumberOfColumns = 9;
    private IEnumerable<string[]> Lines { get; }

    public RemoveUnwantedCharacters(IEnumerable<string[]>? lines)
    {
        ArgumentNullException.ThrowIfNull(lines);

        this.Lines = lines;
    }
    
    public IEnumerable<string[]> Apply()
    {
        foreach (var line in this.Lines)
        {
            if (IsInvalidRow(line))
                continue;

            var filteredLine = RemoveCharacters(line);
            
            if (this.HasNameWithWhiteSpace(filteredLine))
            {
                filteredLine = new ArrayJoin(filteredLine).JoinNameWithWhitespace();
            }

            yield return filteredLine;
        }
    }

    private bool HasNameWithWhiteSpace(IReadOnlyCollection<string> line)
    {
        return line.Count >= NumberOfColumns;
    }

    private static bool IsInvalidRow(IEnumerable<string> result)
    {
        return !result.Any(a => a.Any(char.IsDigit));
    }

    private static string[] RemoveCharacters(IEnumerable<string> result)
    {
        return result.Where(x =>
                !string.IsNullOrEmpty(x) &&
                x != "-" &&
                x.All(a => a != '.'))
            .ToArray();
    }
}