using System;
using System.Collections.Generic;
using System.Text;

//Create an abstract class called Person with two properties: string firstName and string lastName. *

//Give it the method SayName().

//Create another class called Employee and have it inherit from the Person class.

//Implement the SayName() method inside of the Employee class.

//Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.

//Add comments to each line or block of your code to explain what it does exactly, 
//so that another developer could read and understand your code.
namespace Abstractions
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
