using System;
using System.Collections.Generic;
using System.Text;
//Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id
//and have it be of data type int.

//Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of
//“Student”.

//Call the superclass method SayName() on the Employee object.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and
//understand your code.
//namespace inheritance
namespace inheritance
{
    class Employee : Person
    {
        public int Id { get; set; }
    }
}
