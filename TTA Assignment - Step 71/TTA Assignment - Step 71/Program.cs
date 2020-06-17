
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("What page number are you on?");
        string page = Console.ReadLine();
        Console.WriteLine("Do you need anything? Please answer \"true\" or \"false\"");
        string needAnything = Console.ReadLine();
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
        string positiveExperiences = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hoursStudy = Console.ReadLine();
        Console.WriteLine("Thank you for your answers. An Instructor will respond to you shortly.  Have a great day!");
        Console.ReadLine();


    }
}

