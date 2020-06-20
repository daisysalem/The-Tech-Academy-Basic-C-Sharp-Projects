using System;

namespace CS___While_Do___Step_121
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;

            }

            Console.WriteLine("Guess what number I'm thinking of between 1-100");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 9;

            do
            {
                switch (number)
                {
                    case 80:
                        Console.WriteLine("Way too high. Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("Too high. Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Too low but close. Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Yes, number 9! You are correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope. Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed); 

            Console.Read();
        }
    }
}
