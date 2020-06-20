using System;

namespace TTA_Assignment___Shipping_Quote___C_Sharp_Step_117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below");
            Console.WriteLine("Please enter your package weight");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            if (pkgWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of your package?");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                int pkgLength = Convert.ToInt32(Console.ReadLine());

                if (pkgWidth + pkgHeight + pkgLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    decimal quote = (pkgWidth * pkgHeight * pkgLength) / 100;
                    Console.WriteLine("Your cost to ship this package is $" + quote);

                }
            }
        }
    }
}