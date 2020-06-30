/*
1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

2. In the Main() method, create an object of data type Number and assign an amount to it.

3. Print this amount to the console.
*/

using System;

namespace CS___Struct___Step_200
{
    class Program
    {
        static void Main(string[] args)
        {
            Number s;
            s.Amount = 10;

            Console.WriteLine(s.Amount);
        }
    }
}

