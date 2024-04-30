namespace TeamScore.ReadFile;

using System.IO;
using System.Text;

public class ReadDatFile
{
    private string Path { get; }

    public ReadDatFile(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new ArgumentNullException(nameof(path));
        }
        
        this.Path = path;
    }
    
    public IEnumerable<string[]> ReadFile()
    {
        if (!File.Exists(this.Path))
        {
            throw new FileNotFoundException("File not found", this.Path);
        }
        
        const int bufferSize = 128;
        using (var fileStream = File.OpenRead(this.Path))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
        {
            while (streamReader.ReadLine() is { } line)
            {
                yield return line.Split(' ');
            }
        }
    }
}