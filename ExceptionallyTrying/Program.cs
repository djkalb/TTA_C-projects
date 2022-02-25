using System;

//Ask the user for their age.

//Display the year the user was born.

//Exceptions must be handled using “try/catch.”

//Display appropriate error messages if the user enters zero or negative numbers.

//Display a general message if an exception was caused by anything else.

//Add comments to each line or block of your code to explain what it does exactly,
//so that another developer could read and understand your code.

//Upload your code to GitHub.
namespace ExceptionallyTrying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                int age = 0;
                bool validAnswer = false;
                while(!validAnswer)
                {
                    
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    Console.WriteLine("input a valid age");
                }
                if(age < 1)
                {
                    throw new ArgumentException();
                }
                var date = DateTime.Now;
                int yearBorn = date.Year - age;
                Console.WriteLine("you were born in {0}", yearBorn);
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("you werent born yesterday. input a valid year");
            }
            catch (Exception)
            {
                Console.WriteLine("not sure how you did it but you did. please contact customer service");
                return;
            }
        }
    }
}
