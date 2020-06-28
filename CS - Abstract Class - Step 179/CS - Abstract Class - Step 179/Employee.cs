/*
 1. Create an interface called IQuittable and have it define a void method called Quit().

2. Have your Employee class from the previous drill inherit that interface and implement 
the Quit() method in any way you choose.

3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
Hint: an object can be of an interface type if it implements that specific interface.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CS___Abstract_Class___Step_179
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);

        }
        public void Quit(Person FirstName, Person LastName)
        {
            throw new NotImplementedException();
        }

        int n;
        public Employee()
        {
            n = 0;
        }
        public Employee(int EmpId1)
        {
            n = EmpId1;
        }

        public static bool operator ==(Employee EmpId1, Employee EmpId2)
        {
            if (EmpId1.n == EmpId2.n)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee EmpId1, Employee EmpId2)
        {
            if (EmpId1.n != EmpId2.n)
                return true;
            else
                return false;
        }

        public int getValue()
        {
            return n;
        }
    }
}
