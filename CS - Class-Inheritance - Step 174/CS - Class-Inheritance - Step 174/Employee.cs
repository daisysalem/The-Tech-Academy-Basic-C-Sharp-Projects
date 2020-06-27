/*
3. Create another class called Employee and have it inherit from the Person class. 
Give the Employee class a property called Id and have it be of data type int.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CS___Class_Inheritance___Step_174
{
    public class Employee : Person
    {
        public int ID { get; set; }
    }
}
