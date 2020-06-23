/*
1. Create a class. In that class, create three methods, each of which will take one 
integer parameter in and return an integer. The methods should do some math operation 
on the received parameter. Put this class in a separate .cs file in the application.

2. In the Main() program, ask the user what number they want to do the math operations on.

3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen. 
*/


using CS___Class_and_Methods___Step_161;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number and I'll perform 3 math functions with it");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + " + 100 = " + MathOP.Add(num1));
            Console.WriteLine(num1 + " x 50 = " + MathOP.Mult(num1));
            Console.WriteLine(num1 + " - 10 = " + MathOP.Subtract(num1));
            Console.ReadLine();

        }
    }
}

