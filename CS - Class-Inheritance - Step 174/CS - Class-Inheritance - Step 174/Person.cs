/*
1. Create a class called Person and give it two properties, each of data type string. 
One called FirstName, the other LastName.

2. Give this class a void method called SayName() that takes no parameters and simply
writes the person's full name to the console in the format of: "Name: [full name]".
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CS___Class_Inheritance___Step_174
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()  
        {
                Console.WriteLine("Name: " + FirstName + " " + LastName);
            
        }

    }
}
