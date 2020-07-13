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
            Console.WriteLine("Type in a number");
            string answer = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Daisy\Documents\Logs\Step218.txt", answer);

            using (StreamReader r = File.OpenText(@"C:\Users\Daisy\Documents\Logs\Step218.txt"))
            {
                File.ReadAllText(@"C:\Users\Daisy\Documents\Logs\Step218.txt");
                Console.WriteLine(File.OpenText(@"C:\Users\Daisy\Documents\Logs\Step218.txt"));
            }
            Console.ReadLine();


        }
    }
}

