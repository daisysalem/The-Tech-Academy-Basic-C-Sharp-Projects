using System;

namespace TTA_Assignment___C_Sharp_Step_89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: What is your hourly rate?");
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 1: How many hours do you work per week?");
            decimal person1Hours = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2: What is your hourly rate?");
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2: How many hours do you work per week?");
            decimal person2Hours = Convert.ToDecimal(Console.ReadLine());
            decimal person1Annual = person1HourlyRate * person1Hours * 52;
            decimal person2Annual = person2HourlyRate * person2Hours * 52;
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(person1Annual);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(person2Annual);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool person1MoreMoney = person1Annual > person2Annual;
            Console.WriteLine(person1MoreMoney);




        }
    }
}
