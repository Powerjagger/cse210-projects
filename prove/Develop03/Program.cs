using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the reference and scripture
        Reference refer = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(refer);

        // Define the verse text
        string verseText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string[] wordList = verseText.Split(' ');

        // Add words to the scripture
        foreach (string word in wordList)
        {
            scripture.AddWord(word);
        }

        // Main program loop
        string userInput = "";
        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("Press enter to hide 3 words, type 'reshow' to show all words, or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput == "")
            {
                if (!scripture.AllWordsHidden())
                {
                    scripture.HideRandomWords(3);
                }
                else
                {
                    break; // All words are hidden, end the program
                }
            }
            else if (userInput.ToLower() == "reshow")
            {
                scripture.ReshowAllWords();
            }
        }

        Console.WriteLine("PROGRAM ENDED.");
    }
}
