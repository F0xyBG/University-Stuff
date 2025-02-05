namespace ArenaConsoleGame;

internal class FileStatistics
{
    string fileName { get; set; }

    public FileStatistics(string fileName)
    {
        this.fileName = fileName;    
    }

    public void UpdateStatistic(string winnerClass)
    {
        using var stream = File.Open(fileName, FileMode.OpenOrCreate);
        using var reader = new StreamReader (stream);
        var strContent = reader.ReadToEnd();
        Dictionary<string, int> data = new();
        foreach (var line in strContent.Split(['\r', '\n']))
        {
            if (String.IsNullOrEmpty (line)) continue;
            var items = line.Split([':']);
            data.Add(items[0], int.Parse(items[1]));
        }
        if (!data.ContainsKey(winnerClass))
        {
            data.Add(winnerClass, 1);
        }
        else
        {
            data[winnerClass]++;
        }
        stream.Close();
        using var streamWrite = File.Open(fileName, FileMode.Create);
        using var writer = new StreamWriter(streamWrite);
        foreach (var item in data)
        {
            writer.WriteLine ($"{item.Key}:{item.Value}");
        }
        streamWrite.Flush();
    }
}
