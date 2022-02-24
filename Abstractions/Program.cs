using System;
//Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
//Call the SayName() method on the object.
namespace Abstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees { LastName = "Student", FirstName = "Sample" };
            // calls parent Person method inside employee with instanciated employees information i think
            employee.SayName();
            
        }
    }
}
