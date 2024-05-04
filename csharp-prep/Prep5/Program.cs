using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("What can I call you?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}, I am designated Prep Program 5.");
        
        Console.WriteLine("Weird question, but what is your favorite number?");
        int favoriteNumber = int.Parse(Console.ReadLine()); 

        int favoriteSquared = favoriteNumber * favoriteNumber; 
        
        Console.WriteLine($"Oh, interesting! So {favoriteNumber} is your favorite.");
        Console.WriteLine($"Did you know that your favorite number squared is {favoriteSquared}");
    }
}
