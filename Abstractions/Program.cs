using System;
//Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
//Call the SayName() method on the object.
namespace Abstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees { LastName = "Student", FirstName = "Sample", Id = 10 };
            // calls parent Person method inside employee with instanciated employees information i think
            //employee.SayName();
            //employee.Quit();
            Employees employee2 = new Employees { Id = 11 };
            Console.WriteLine(employee == employee2);

            
        }
    }
}
