using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Grade:");
        string gradeInput = Console.ReadLine();

        char gradeLetter; // Declare gradeLetter variable

        if (int.TryParse(gradeInput, out int grade))
        {
            if (grade >= 90)
            {
                gradeLetter = 'A';
            }
            else if (grade >= 80 && grade < 90)
            {
                gradeLetter = 'B';
            }
            else if (grade >= 70 && grade < 80)
            {
                gradeLetter = 'C';
            }
            else if (grade >= 60 && grade < 70)
            {
                gradeLetter = 'D';
            }
            else // For grades below 60
            {
                gradeLetter = 'F';
            }

            if (grade >= 70)
            {
                Console.WriteLine($"Congratulations! You have passed. Your grade is {gradeLetter}");
            }
            else // For grades below 70
            {
                Console.WriteLine($"Sorry, but you didn't pass. Better luck next time. Your grade is {gradeLetter}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer grade.");
        }
    }
}
