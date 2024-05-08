using System.ComponentModel.DataAnnotations;

class Courses
{
    public string courseCode;

    public string className;

    public int _numberOfCredits;
    
    public string _color;

  // meathod
    public void Display ()
{
    Console.WriteLine($"{_courseCode} {_className} {_numberOfCredits} {_color}");
}
}