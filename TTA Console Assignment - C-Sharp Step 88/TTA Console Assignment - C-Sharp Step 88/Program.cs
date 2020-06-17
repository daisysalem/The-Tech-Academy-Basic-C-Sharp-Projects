using System;

namespace TTA_Console_Assignment___C_Sharp_Step_88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            int product = yourNumber * 50;
            Console.WriteLine(product);

            Console.WriteLine("Pick a number");
            int yourNumber2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = yourNumber2 + 25;
            Console.WriteLine(sum1);

            Console.WriteLine("Pick a number");
            int yourNumber3 = Convert.ToInt32(Console.ReadLine());
            double divide1 = yourNumber3 / 12.5;
            Console.WriteLine(divide1);

            Console.WriteLine("Pick a number");
            int yourNumber4 = Convert.ToInt32(Console.ReadLine());
            bool reply1 = yourNumber4 > 50;
            Console.Write(reply1.ToString());
       
            Console.WriteLine("Pick a number");
            int yourNumber5 = Convert.ToInt32(Console.ReadLine());
            int remainder = yourNumber5 % 7;
            Console.WriteLine(remainder);

   

        }
    }
}
