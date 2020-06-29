using System;
using System.Collections.Generic;

namespace CS___enums___Step_195
{

    class Program
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(@"
                0 - Monday
                1 - Tuesday
                2 - Wednesday
                3 - Thursday
                4 - Friday
                5 - Saturday
                6 - Sunday

                Based on the list above, select the current day by only using its corresponding number 0-6: ");

                string day = Console.ReadLine();
                int dayInt = Int32.Parse(day);

                DaysOfWeek Today = (DaysOfWeek)dayInt;
 
                if (dayInt < 0 || dayInt > 6 )
                    {
                        Console.WriteLine("Please select a number between 0-6");
                        return;
                    }

                switch (Today)
                {
                    case DaysOfWeek.Monday:
                        Console.WriteLine("Today is Monday");
                        break;
                    case DaysOfWeek.Tuesday:
                        Console.WriteLine("Today is Tuesday.");
                        break;
                    case DaysOfWeek.Wednesday:
                        Console.WriteLine("Today is Wednesday.");
                        break;
                    case DaysOfWeek.Thursday:
                        Console.WriteLine("Today is Thursday.");
                        break;
                    case DaysOfWeek.Friday:
                        Console.WriteLine("Today is Friday.");
                        break;
                    case DaysOfWeek.Saturday:
                        Console.WriteLine("Today is Saturday.");
                        break;
                    case DaysOfWeek.Sunday:
                        Console.WriteLine("Today is Sunday.");
                        break;
                }

            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Please select a number between 0-6");
                return;
            }

            finally
            {
                Console.ReadLine();
            }

        }
    }
}

