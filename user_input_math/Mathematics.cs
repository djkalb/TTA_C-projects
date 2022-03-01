using System;
using System.Collections.Generic;
using System.Text;
//Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional.
//Have the method do a math operation and return an integer result.

//In the Main() method of the console app, instantiate the class.

//Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

//Call the method in the class, passing in the one or two numbers entered.

//Try various combinations of numbers on the code, including having no second number.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer
//could read and understand your code.

//Upload your code to GitHub and submit the link below:
namespace user_input_math
{
    class Mathematics
    {
        public int Math (int num1, int num2 = 2)
        {
            return num1 + num2;
        }
    }
}
