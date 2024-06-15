using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new BreathingActivity("Breathing Exercise", "Take deep breaths and relax."),
            new ReflectActivity("Reflect Activity", "Reflect on your emotions and thoughts."),
            new ListActivity("List Activity", "List positive things in your life.")
        };

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].GetType().Name}");
            }

            Console.WriteLine("0. Quit");

            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int activityIndex))
            {
                if (activityIndex == 0)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else if (activityIndex >= 1 && activityIndex <= activities.Count)
                {
                    Activity selectedActivity = activities[activityIndex - 1];
                    selectedActivity.Start();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid activity number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid activity number or 0 to quit.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
