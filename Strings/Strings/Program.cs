using System;
using System.Text;
//Concatenates three strings.

//Converts a string to uppercase.

//Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

//Upload your code to GitHub.
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string concatted = "this is a string " + "just string it along " + "tired of strings.";
            string upperred = "can i do it like this?".ToUpper();
            StringBuilder builded = new StringBuilder();
            builded.Append(concatted + "\n");
            builded.Append(upperred + "\n");
            builded.Append("one more string");
            Console.WriteLine(builded);
        }
    }
}
