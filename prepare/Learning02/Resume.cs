using System;
using System.Collections.Generic;

namespace Learning02
{
    public class Resume
    {
        public string Name { get; set; }
        public List<Job> Jobs { get; }

        public Resume(string name)
        {
            Name = name;
            Jobs = new List<Job>();
        }

        public void AddJob(Job job)
        {
            Jobs.Add(job);
        }

        public void DisplayResume()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Jobs:");
            foreach (var job in Jobs)
            {
                Console.WriteLine(job.Display());
            }
        }
    }
}
