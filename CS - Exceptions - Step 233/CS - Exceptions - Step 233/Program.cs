/*
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

1. Ask the user for their age.

2. Display the year the user was born.

3. Exceptions must be handled using "try .. catch".

4. Display appropriate error messages if the user enters zero or negative numbers.

5. Display a general message if an exception was caused by anything else.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS___Exceptions___Step_233
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                    
                if (age < 1)
                {
                    Console.WriteLine("Please enter digit(s) above 0.");
                    age = Convert.ToInt32(Console.ReadLine());
                    return;
                }

                int yearBorn = 2020 - age;
                int yearBorn2 = yearBorn - 1;
                Console.WriteLine("If you had a birthday this year, you were born in " + yearBorn +
                    ". Otherwise, you were born in " + yearBorn2);
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured.  Please only enter digits for age.");
                Console.ReadLine();
                return;
            }
                           
        }
    }
}
