using System;


//Create a class. In that class, create a method that will take in an integer, create a math operation for this integer
//(addition, subtraction, etc.), then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the one method, passing in an integer.
//Display the result to the screen.

//Add a second method to the class with the same name that will take in a decimal, create a different math operation for it,
//then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal.
//Display the result to the screen.

//Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible,
//do a different math operation to it, then return the answer as an integer.

//In the Main() method of the console app, instantiate the class and call the third method, passing in a string that
//equates to an integer. Display the result to the screen.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer
//could read and understand your code.

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematical maths = new Mathematical();
            int intNum = 30;
            decimal decNumber = 100.05m;
            string stringNum = "50";
            // calls all those fancy methods i wrote
            Console.WriteLine(Mathematical.Add(intNum));
            Console.WriteLine(Mathematical.Add(decNumber));
            Console.WriteLine(Mathematical.Add(stringNum));
            
        }
    }
}
