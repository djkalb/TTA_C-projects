﻿using System;

//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
//The methods should do some math operation on the received parameter. Put this class in a separate.cs file in the application.

//In the Main() program, ask the user what number they want to do the math operations on.

//Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematical maths = new Mathematical();
            Console.WriteLine("input a number i will do some maths to it");
            maths.Integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Mathematical.Add(maths.Integer1));
            Console.WriteLine(Mathematical.Subtract(maths.Integer1));
            Console.WriteLine(Mathematical.Multiply(maths.Integer1));
        }
    }
}
