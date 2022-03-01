using System;
using System.Collections.Generic;
//A one-dimensional array of strings.

//Ask the user to input some text.

//A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.

//Then create a loop that prints off each string in the array on a separate line.
namespace iteratives
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringers = { "string one ", "string 2 ", "string 3 " };
            Console.WriteLine("write some text to append to some strings");
            string userText = Console.ReadLine();
            for (int i = 0; i < stringers.Length; i++)
            {
                stringers[i] += userText;
            }
            for (int i = 0; i < stringers.Length; i++)
            {
                Console.WriteLine(stringers[i]);
            }
            bool choice = true;
            while (choice)
            {

                choice = false;
            }
            List<int> numbers = new List<int>() { 0, 10, 50, 40, 1000 };
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 40)
                {
                    numbers[i] = numbers[i] * 5;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= 40)
                {
                    numbers[i] = numbers[i] * 5;
                }
            }
            List<string> fruits = new List<string>() { "apple", "pear", "banana", "orange" };
            Console.WriteLine("type in a fruit");
            bool found = false;
            string userInput = Console.ReadLine();
            foreach (string fruit in fruits)
            {
                if (userInput == fruit)
                {
                    Console.WriteLine(fruit);
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                Console.WriteLine("your fruit was not on the list. spell better or select better fruit");

            }
            List<string> veggies = new List<string>() { "onions", "tomatos", "peppers", "onions" };
            Console.WriteLine("type in a veggie || onions are in there twice just FYI");
            found = false;
            userInput = Console.ReadLine();
            List<int> indexes = new List<int>();
            for (int i = 0; i < veggies.Count; i++)
            {
                if (userInput == veggies[i])
                {
                    indexes.Add(i);
                    found = true;

                }

            }
            if (!found)
            {
                Console.WriteLine("your veggie was not on the list. spell better or select better veggies");

            }
            foreach (int index in indexes)
            {
                Console.WriteLine(index);
            }

            for (int i = 0; i < veggies.Count; i++)
            {
                // checks to see if the string was already iterated over  
                if (veggies.IndexOf(veggies[i]) < i)
                {
                    Console.WriteLine(veggies[i] + " has already appeared in the list");
                }
                // prints all the strings that arent doubles
                else
                {
                    Console.WriteLine(veggies[i]);
                }
            }


        }
    }
}
