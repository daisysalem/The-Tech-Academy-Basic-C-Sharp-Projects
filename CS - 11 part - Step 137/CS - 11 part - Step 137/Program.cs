using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        //************************************************************
        // PART 1 - Create a one-dimensional Array of strings.
        // Ask the user to input some text. Create a loop that goes through each string in the Array,
        // adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.
        //************************************************************

        Console.WriteLine("What is your first name?");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lname = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine("Your name is " + fname + " " + lname + " and your favorite color is " + color);


        //**********************************
        // PART 2 - Cfreat an Infinite Loop
        //**********************************

        //while (true)
        //{
        //    Console.WriteLine("This will never end. Just close the window.");

        //}

        //********************************************************
        // PART 3 - Fix the infinite loop so that it will execute
        //********************************************************

        //while (true)
        //{
        //    Console.WriteLine("This Read Line will stop the infinite loop.");
        //    Console.ReadLine();

        //}

        //********************************************************************
        // PART 4 - Create a loop where the comparison that’s used to 
        //   determine whether to continue iterating the loop is a “<” operator.
        //*********************************************************************

        //string[] names = { "Jeff", "Zack", "John", "Dwayne", "Mary", "Steve", "Homer" };

        //for (int j = 0; j < 4; j++)
        //{

        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}
        //Console.ReadLine();


        //*********************************************************************
        // PART 5 - Create a loop where the comparison that’s used to 
        // determine whether to continue iterating the loop is a “<=” operator.
        //**********************************************************************

        //string[] names = { "Jeff", "Zack", "John", "Dwayne", "Mary", "Steve", "Homer" };

        //for (int j = 0; j <= 4; j++)
        //{
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}
        //Console.ReadLine();


        //********************************************************************************
        // PART 6, 7, & 8 - Create a List of strings where each item in the list is unique.
        // Ask the user to input text to search for  in the List. 
        // Create a loop that iterates through the loop and then displays 
        // the index of the array that contains matching text on the screen.
        // Add code to that above loop that tells a user if they put in text that isn’t in the List.
        // Add code to that above loop that stops it from executing once a match has been found.
        //********************************************************************************

        //string[] animals = { "elephant", "zebra", "lion", "tiger", "monkey", "giraffe" };
        //Console.WriteLine("What zoo animal are you looking for?");
        //string animalChoice = Console.ReadLine();
        //bool isFound = false;
        //int counter = 0;

        //while (isFound == false && counter < animals.Length)
        //{
        //    if (animals[counter] == animalChoice)
        //    {
        //        Console.WriteLine("The animal, " + animalChoice + ", is located at Index #" + counter);
        //        isFound = true;
        //    }
        //    counter++;
        //}
        //if (isFound == false)
        //{
        //    Console.WriteLine("We don't have that animal at this zoo.");
        //}
        //Console.ReadLine();


        //***************************************************************************************
        // PART 9 & 10 - Create a List of strings that has at least two identical strings in the List. 
        // Ask the user to select text to search for in the List. Create a loop that iterates through 
        // the loop and then displays the indices of the array that contain matching text on the screen.
        // Add code to that above loop that tells a user if they put in text that isn’t in the List.
        //******************************************************************************************

        //List<string> names = new List<string>() { "Jeff", "Zack", "John", "Jeff", "Dwayne" };
        //Console.WriteLine("What name are you searching for?");
        //string nameSelect = Console.ReadLine();
        //bool isFound = false;

        //for (int j = 0; j < names.Count; j++)
        //{
        //    if (names[j] == nameSelect)
        //    {
        //        Console.WriteLine("We found the name, " + nameSelect + ", in the following index: " + j);
        //        isFound = true;
        //    }

        //}
        //if (isFound == false)
        //{
        //    Console.WriteLine("A match wasn't found.");
        //}
        //Console.ReadLine();


        //********************************************************************************************
        // PART 11 - Create a List of strings that has at least two identical strings in the List. 
        // Create a foreach loop that evaluates each item in the list, and displays a message showing 
        // the string and whether or not it has already appeared in the list.
        //********************************************************************************************

        //List<string> food = new List<string>() { "lobster", "crab", "steak", "pasta", "crab", "lobster" };
        //List<string> foodBackup = new List<string>();

        //foreach (var element in food)
        //{
        //    foreach (var element2 in foodBackup)
        //    {
        //        if (element == element2)
        //        {
        //            Console.WriteLine("This item, " + element + ", has been found on the list");
        //        }

        //    }
        //    foodBackup.Add(element);

        //}

    }
}

