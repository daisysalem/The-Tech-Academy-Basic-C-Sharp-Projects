using System;
using System.Collections.Generic; // use for lists


class Program
{
    static void Main()
    {
        string[] fruit = { "Apple", "Orange", "Blueberries", "Peach", "Banana" };
        Console.WriteLine("Choose a number from 0-4 and that will be your fruit at today's lunch");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 == 0 || number1 == 1 || number1 == 2 || number1 == 3 || number1 == 4)
        {
            Console.WriteLine("You will have " + fruit[number1] + " for lunch today!");
        }
        else
        {
            Console.WriteLine("That's not a valid choice.");
        }


        int[] numArray = {3, 9, 25, 42, 55, 7};
        Console.WriteLine("Choose a number from 0-5 and that will reveal your mystery lucky number for the day");
        int luckyNum = Convert.ToInt32(Console.ReadLine());
        if (luckyNum == 0 || luckyNum == 1 || luckyNum == 2 || luckyNum == 3 || luckyNum == 4 || luckyNum == 5)
        {
            Console.WriteLine("Your lucky number for today is " + numArray[luckyNum]);
        } 
        else
        {
            Console.WriteLine("That's not a valid choice.");
           
        }

        List<string> intList = new List<string> { "Blue", "Red", "Purple", "Yellow", "Orange" };

        Console.WriteLine("Choose a number from 0-4 and that will be your color");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0 || number == 1 || number == 2 || number == 3 || number == 4)
        {
            Console.WriteLine("The number you chose is the color " + intList[number]);
        }
        else
        {
            Console.WriteLine("That's not a valid choice.");
        }

    }
}
