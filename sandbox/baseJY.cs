using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Entry
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Text { get; set; }
    public List<string> Tags { get; set; }

    public Entry(int id, DateTime date, string prompt, string text, List<string> tags)
    {
        Id = id;
        Date = date;
        Prompt = prompt;
        Text = text;
        Tags = tags;
    }

    public override string ToString()
    {
        string tagsString = Tags != null && Tags.Any() ? string.Join(", ", Tags) : "No tags";
        return $"Entry ID: {Id}\nDate: {Date}\nPrompt: {Prompt}\nTags: {tagsString}\nText:\n{Text}";
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"Id:{Id}");
            writer.WriteLine($"Date:{Date}");
            writer.WriteLine($"Prompt:{Prompt}");
            writer.WriteLine($"Text:{Text}");
            writer.WriteLine($"Tags:{string.Join(",", Tags)}");
            writer.WriteLine("===END===");
        }
    }

    public static List<Entry> LoadFromFile(string filePath)
    {
        List<Entry> entries = new List<Entry>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            Entry entry = null;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.StartsWith("Id:"))
                {
                    entry = new Entry(
                        int.Parse(line.Split(':')[1]),
                        DateTime.Parse(reader.ReadLine().Split(':')[1]),
                        reader.ReadLine().Split(':')[1],
                        reader.ReadLine().Split(':')[1],
                        reader.ReadLine().Split(':')[1].Split(',').ToList()
                    );
                    entries.Add(entry);
                }
            }
        }
        return entries;
    }
}
