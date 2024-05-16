using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<string> promptList = new List<string>
    {
        "What was one thing you saw today",
        "How are you feeling about classes",
        "If you could live in a fantasy world, which one and why?",
        "What would your dream date be?",
        "What are your thoughts on the Roman Empire",
        "What is your favorite movie and why?",
        "What is your favorite video game and why?",
        "Why do you fight?",
    };

    private List<Entry> entries = new List<Entry>();
    private const string FilePath = "journal.txt";

    public void AddEntry()
    {
        // Automatically select a random prompt
        Random random = new Random();
        string randomPrompt = promptList[random.Next(0, promptList.Count)];

        int id = entries.Count + 1; // Generate ID automatically
        DateTime currentDate = DateTime.Now; // Get the current date and time
        string dateText = currentDate.ToShortDateString(); // Convert to short date string

        Console.WriteLine($"Random Prompt: {randomPrompt}");
        Console.WriteLine($"Current Date: {dateText}");

        Console.Write("Enter Text: ");
        string text = Console.ReadLine();

        Console.Write("Enter Tags (comma-separated): ");
        List<string> tags = Console.ReadLine().Split(',').ToList();

        Entry newEntry = new Entry(id, currentDate, randomPrompt, text, tags); // Use currentDate as the date
        entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("===========");
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"Id:{entry.Id}");
                writer.WriteLine($"Date:{entry.Date.ToString("MM/dd/yyyy H")}");
                writer.WriteLine($"Prompt:{entry.Prompt}");
                writer.WriteLine($"Text:{entry.Text}");
                writer.WriteLine($"Tags:{string.Join(",", entry.Tags)}");
                writer.WriteLine("===END===");
            }
        }

        Console.WriteLine("Entries saved to file.");
    }

    public void LoadFromFile()
    {
        entries.Clear(); // Clear existing entries before loading from file
        using (StreamReader reader = new StreamReader(FilePath))
        {
            Entry entry = null;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.StartsWith("Id:"))
                {
                    string idStr = line.Split(':')[1];
                    int id = int.Parse(idStr);

                    string dateStr = reader.ReadLine().Split(':')[1];
                    DateTime date = DateTime.ParseExact(dateStr, "M/d/yyyy H", null); // Updated format

                    string prompt = reader.ReadLine().Split(':')[1];
                    string text = reader.ReadLine().Split(':')[1];

                    string tagsStr = reader.ReadLine().Split(':')[1];
                    List<string> tags = tagsStr.Split(',').ToList();

                    reader.ReadLine(); // Read the "===END===" line

                    entry = new Entry(id, date, prompt, text, tags);
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine("Entries loaded from file.");
    }

    public void DisplayMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;

                case "2":
                    DisplayAllEntries();
                    break;

                case "3":
                    SaveToFile();
                    break;

                case "4":
                    LoadFromFile();
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
