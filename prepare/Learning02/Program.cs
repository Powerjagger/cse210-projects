using System;

namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job { _company = "Microsoft", _jobtitle = "Software Engineer", _startYear = 2019, _endYear = 2022 };
            Job job2 = new Job { _company = "Google", _jobtitle = "Data Analyst", _startYear = 2022, _endYear = 2023 };

            Resume resume = new Resume("Allison Rose");
            resume.AddJob(job1);
            resume.AddJob(job2);

            resume.DisplayResume();
        }
    }
}
