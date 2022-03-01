using System;
//Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).

//Takes an input from the user, adds 25 to it, then prints the result to the console.

//Takes an input from the user, divides it by 12.5, then prints the result to the console.

//Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.

//Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code
namespace math_operators
{
    class Program
    {
        static void Main()
        {   
            //does some mathematics and prints/ reads from console
            Console.WriteLine("input a number");
            string inputNumber = Console.ReadLine();
            int addToNumber = Int32.Parse(inputNumber) + 25;
            Console.WriteLine(addToNumber);

            Console.WriteLine("input a number");
            inputNumber = Console.ReadLine();
            double divideNumber = Double.Parse(inputNumber) / 12.5;
            Console.WriteLine(divideNumber);

            Console.WriteLine("input a number");
            inputNumber = Console.ReadLine();
            bool compareNumber = Int16.Parse(inputNumber) > 50;
            Console.WriteLine("greater than 50? " + compareNumber);

            Console.WriteLine("input a number");
            inputNumber = Console.ReadLine();
            int remainder = Int16.Parse(inputNumber) % 7;
            Console.WriteLine(remainder);
        }
    }
}
