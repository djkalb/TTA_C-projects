using System;
using System.Collections.Generic;
//Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

//Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

//Add in a message that displays when the user selects an index that doesn’t exist.

//Create a list of strings. Ask the user to select an index of the list
//and then display the content at that index on the screen.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 
namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {
            string[] stringer = { "strinig 0", "this is one", "here is a two", "lastly a tree" };
            Console.WriteLine("input a number from 0 to 3 to see that string");
            int userInput = Convert.ToInt32(Console.ReadLine());
            // validates user input if incorrect prints first item instead
            if (userInput > 3)
            {
                Console.WriteLine("that number is too big do better next time here is the first item instead");
                userInput = 0;
            }
            Console.WriteLine(stringer[userInput]);
            int[] inter = { 0, 1, 25, 50, 100, 500 };
            Console.WriteLine("input a number from 0 to 5 to see that number");
            userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput > 5)
            {
                Console.WriteLine("that number is too big do better next time here is the first item instead"); 
                userInput = 0;
            }
            Console.WriteLine(inter[userInput]);

            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            Console.WriteLine("input a number from 0 to 3 to see a city");
            userInput = Convert.ToInt32(Console.ReadLine());
            // validates user input if incorrect prints first item instead
            if (userInput > 3)
            {
                Console.WriteLine("that number is too big do better next time here is the first item instead");
                userInput = 0;
            }
            Console.WriteLine(cities[userInput]);

        }
    }
}
