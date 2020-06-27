/*
 1. Create an abstract class called Person with two properties: string firstName and string lastName.

2. Give it the method SayName().

3. Create another class called Employee and have it inherit from the Person class.

4. Implement the SayName() method inside of the Employee class.

5. Inside the Main() method, instantiate an Employee object with 
firstName "Sample" and lastName "Student". Call the SayName() method on the object.
*/

using System;
using System.Collections.Generic;

namespace CS___Abstract_Class___Step_179
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.FirstName = new string("Sample");
            Person.LastName = new string("Student");
            Person.SayName();
            Console.ReadLine();

            //IQuittable.Resign = "John";
            //Console.WriteLine(IQuittable.Quit(Resign());

        }
    }
}
