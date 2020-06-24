/*
1. Create a class. In that class, create a void method that takes two integers as parameters. 
Have the method do a math operation on the first integer and display the second integer to the screen.

2. In the Main() method of the console app, instantiate the class.

3. Call the method in the class, passing in two numbers.

4. Call the method in the class, specifying the parameters by name.
*/
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS___Class_and_Methods_4___Step_166
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            MathOp FirstOp = new MathOp();
            FirstOp.MathMethod(num1, num2);
            
            Console.ReadLine();
        }
    }
}
