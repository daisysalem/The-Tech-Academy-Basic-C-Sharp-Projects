﻿/*
 1. Create a class. In that class, create a method that will take in an integer, 
create a math operation for this integer (addition, subtraction, etc.), then return 
the answer as an integer.

2. In the Main() method of the console app, instantiate the class and call the 
one method, passing in an integer. Display the result to the screen.

3. Add a second method to the class with the same name that will take in a decimal,
create a different math operation for it, then return the answer as an integer.

4. In the Main() method of the console app, instantiate the class and call the second method, 
passing in a decimal. Display the result to the screen.

5. Add a third method to the class, with the same name, that will take in a string, 
convert it to an integer if possible, do a different math operation to it, then return 
the answer as an integer.

6. In the Main() method of the console app, instantiate the class and call the third method, 
passing in a string that equates to an integer. Display the result to the screen.
*/

using CS___Class_and_Methods_2___Step_164;
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
            int num1 = 5;
            decimal num2 = 10;
            //string num3 = Convert.ToInt32(20);

            //Console.WriteLine(num1Result);
            //Console.WriteLine(num2Result);
            //Console.WriteLine(num3Result);

            MathOp FirstOperation = new MathOp();
            Console.WriteLine(FirstOperation.MathMethod(5));
            Console.ReadLine();

        }
    }
}

