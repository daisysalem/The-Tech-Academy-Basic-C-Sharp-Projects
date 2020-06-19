using System;

namespace TTA_Assigment___Car_Insurance___C_Sharp_Step_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Evaluation");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Answer Yes or No.");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for Insurance?");

            bool qualify = (age >= 15 && (dui == "no" || dui == "No") && tickets <= 3);

            Console.WriteLine(qualify);

           
        }
    }
}
