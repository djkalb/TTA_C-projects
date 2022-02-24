using System;
//Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as
//the property value of Things.

//Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the
//property value of Things.

//Create a loop that prints all of the Things to the Console.
namespace Abstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees employee = new Employees { LastName = "Student", FirstName = "Sample", Id = 10 };
            //// calls parent Person method inside employee with instanciated employees information i think
            ////employee.SayName();
            ////employee.Quit();
            //Employees employee2 = new Employees { Id = 11 };
            //// custom comparison throws error if IDs match else returns the first employee
            //Console.WriteLine(employee == employee2);
            Employees<string> employee = new Employees<string>();
            employee.Things.Add("strings");
            employee.Things.Add("morbid");
            employee.Things.Add("obesity");
            employee.Things.Add("stings");
            foreach (string item in employee.Things)
            {
                Console.WriteLine(item);
            }



        }
    }
}
