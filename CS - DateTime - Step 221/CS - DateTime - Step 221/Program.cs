/*
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

1. Prints the current date and time to the console.

2. Asks the user for a number.

3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS___DateTime___Step_221
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today = " + DateTime.Now);

            Console.WriteLine("Pick a number");
            int answer = Convert.ToInt32(Console.ReadLine());

            TimeSpan duration = new TimeSpan(0, answer, 0, 0);
            DateTime futureTime = today.Add(duration);
            Console.WriteLine("In " + answer + " hours, it will be: " + futureTime);
            Console.ReadLine();
 
        }
     }
}
