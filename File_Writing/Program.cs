using System;
using System.IO;

//Asks the user for a number.

//Logs that number to a text file.

//Prints the text file back to the user.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

//Upload your code to GitHub.
namespace File_Writing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a number");
            string number = Console.ReadLine();
            // creates file in current folder puts the inputted number in it
            File.WriteAllText(@".\number.txt", (number + 10));
            // prints file contents to screen
            Console.WriteLine(File.ReadAllText(@".\number.txt"));
        }
    }
}
