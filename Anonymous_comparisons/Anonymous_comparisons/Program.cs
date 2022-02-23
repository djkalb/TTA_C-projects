using System;
//The program must start by printing “Anonymous Income Comparison Program” to the screen.

//It must then print “Person 1” to the screen and get the following details from user input:
//Hourly Rate
//Hours worked per week

//It must then print “Person 2” to the screen and then get the following details from user input:
//Hourly rate
//Hours worked per week

//It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.

//It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.

//It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
namespace Anonymous_comparisons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: \n input hourly rate: \n now input hours worked this week");
            string input1Rate = Console.ReadLine();
            string input1Hours = Console.ReadLine();
            Console.WriteLine("Person 2: \n input hourly rate: \n now input hours worked this week");
            string input2Rate = Console.ReadLine();
            string input2Hours = Console.ReadLine();
            // figures weekly wage multiplies by number of weeks for both inputs
            decimal person1Salary = decimal.Parse(input1Rate) * decimal.Parse(input1Hours) * 52;
            decimal person2Salary = decimal.Parse(input2Rate) * decimal.Parse(input2Hours) * 52;
            Console.WriteLine("Annual salary of Person 1: \n" + person1Salary + "\nAnnual salary of Person 2: \n" + person2Salary);
            bool salaryComparison = person1Salary > person2Salary;
            Console.WriteLine("does person 1 make more money? \n" + salaryComparison);
        }
    }
}
