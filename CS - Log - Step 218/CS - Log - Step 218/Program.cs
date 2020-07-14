/*
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

1. Ask the user for a number.

2. Log that number to a text file.

3. Print the text file back to the user.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS___Log___Step_218
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Daisy\Documents\Logs\Step218.txt";
            Console.WriteLine("Type in a number");
            string inputNum = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(inputNum);
            }
            using (StreamReader file = new StreamReader(filePath, true))
            {
                string returnText = file.ReadToEnd().ToString();
                Console.WriteLine(returnText);
            }

            Console.ReadLine();


        }
    }
}
