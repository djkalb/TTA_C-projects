using System;
//Prints the current date and time to the console.

//Asks the user for a number.

//Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer
//could read and understand your code.
namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number of hours?");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime dateTime = DateTime.Now;
            dateTime = dateTime.AddHours(hours);
            Console.WriteLine(dateTime.ToString());
        }
    }
}
