using System;

//Create an enum for the days of the week.

//Prompt the user to enter the current day of the week.

//Assign the value to a variable of that enum data type you just created.

//Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

//Upload your code to GitHub and submit the link below:
namespace enumerations
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the current day of the week");
            string inputDay = Console.ReadLine();
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), inputDay);
            }
            catch
            {
                Console.WriteLine("could not find that day");
            }
            
            


        }
    }
}
