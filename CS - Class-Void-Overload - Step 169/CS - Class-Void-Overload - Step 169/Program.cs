/*
1. Create a class. In that class, create a void method that outputs an integer. 
Have the method divide the data passed to it by 2.

2. In the Main() method, instantiate that class.

3. Have the user enter a number. Call the method on that number. 
Display the output to the screen. It should be the entered number, divided by two.

4. Create a method with output parameters.

5. Overload a method.

6. Declare a class to be static.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS___Class_Void_Overload___Step_169
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Pick a number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 10;
            int dog = 100;
            int cat = 7;

            MathOp FirstOp = new MathOp();
            FirstOp.MathMethodFirst(num1, num2);
            FirstOp.MathMethodSecond(dog, cat);
   
            Console.ReadLine();
        }
    }
}
