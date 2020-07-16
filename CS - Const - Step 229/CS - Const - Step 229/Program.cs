/*
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

1. Create a const variable.

2. Create a variable using the keyword "var".

3. Chain two constructors together.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS___Const___Step_229
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MovieTitle = "Jumanji";
            var PaidSeat = "Row 5, Seat 3";
            Console.WriteLine("Enjoy today's feature film, {0}", MovieTitle);
            Console.WriteLine("You seat is " + PaidSeat);
            Console.ReadLine();
     
        }
    }
}

