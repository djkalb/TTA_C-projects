using System;
using System.Collections.Generic;
using System.Linq;
//In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name,
//as well as an Id. At least two employees should have the first name “Joe”.

//Using a foreach loop, create a new list of all employees with the first name “Joe”.

//Perform the same action again, but this time with a lambda expression.

//Using a lambda expression, make a list of all employees with an Id number greater than 5.

//Add comments to each line or block of your code to explain what it does exactly, so that another 
//developer could read and understand your code.
namespace Abstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();
            // generates list of employees IDS are unique, but sadly names are shared lots of Joes in my company
            for (int i = 0; i < 10; i++)
            {
                Employees employee = new Employees { FirstName = "Joe", LastName = "Joe", Id = i };
                employees.Add(employee);
            }
            // makes list of employees where id > 5
            List<Employees> listIds = employees.Where(x => x.Id > 5).ToList();
            // makes list of employees where name is joe ie just remaking the whole list
            List<Employees> listName = employees.Where(x => x.FirstName == "Joe").ToList();
            // makes list of employees where name is joe ie just remaking the whole list but in a different way this time
            List<Employees> listName1 = new List<Employees>(); 
            foreach (Employees employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    listName1.Add(employee);
                }
            }
            foreach(Employees employee in listIds)
            {
                Console.WriteLine(employee.Id + " " + employee.FirstName);
            }
            foreach (Employees employee in listName)
            {
                Console.WriteLine(employee.Id + " " + employee.FirstName);
            }
            foreach (Employees employee in listName1)
            {
                Console.WriteLine(employee.Id + " " + employee.FirstName);
            }










        }
    }
}
