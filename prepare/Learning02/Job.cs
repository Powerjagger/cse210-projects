using System;

namespace Learning02
{
    public class Job
    {
        public string _company { get; set; }
        public string _jobtitle { get; set; }
        public int _startYear { get; set; }
        public int _endYear { get; set; }

        public string Display()
        {
            return $"{_jobtitle} ({_company}) {_startYear}-{_endYear}";
        }
    }
}
