using System;
//Your application must ask these questions:

//What is your age ?

//Have you ever had a DUI?

//How many speeding tickets do you have?

//Use the following qualification rules to determine if the applicant qualifies for car insurance:

//Applicants must be over 15 years old.

//Applicants must not have any DUI’s.

//Applicants must not have more than 3 speeding tickets.
namespace Boolean_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("submit some information to see if you qualify for car insurance");
            Console.WriteLine("what is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? true or false only");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            Console.WriteLine("Do you qualify for insurance??");
            // prints true or false depending on if they meet the criteeria for insurance did conversions inline
            // cause lazy
            Console.WriteLine(Int16.Parse(age) > 14 && Convert.ToBoolean(dui) && Int16.Parse(tickets) < 3);
        }
    }
}
