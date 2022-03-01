using System;
using System.Collections.Generic;
//Create a list of integers. Ask the user for a number to divide each number in the list by.
//Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

//Run the code, entering in non-zero numbers as the user. Look at the displayed results.

//Run the code again, entering in zero as the number to divide by. Note any error messages you get.

//Run the code once again, entering in a string as the number to divide by. Note any error messages you get.

//Now put the loop in a try/catch block. Below and outside of the try/catch block,
//make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbs = new List<int> { 11, 44, 30, 60 };
            Console.WriteLine("input a number to divide some numbers by");
            // makes errors look prettier but doesnt help them
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                foreach (int numb in numbs)
                {
                    Console.WriteLine(numb + "divided by " + input + " equals " + numb / input);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("WORDS ARE NOT NUMBERS");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("NEVER DIVIDE BY ZERO");
            }
            finally
            {
                Console.WriteLine("since numbers are hard were just gonna skip this whole thing. please tyope beter");
            }

        }
    }
}
