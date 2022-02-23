using System;
//The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”

//The user must then be prompted for the package weight.

//If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.

//The user must then be prompted for the package width.

//Then the package height.

//Then the package length.

//If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.

//Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.

//The result of that calculation is the quote.

//Display the quote to the user as a dollar amount.
namespace Planet_express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Planet Express. Please follow the instructions below.");
            Console.WriteLine("how much does the package weigh?");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Planet Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the package width?");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package height");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((length + width + height > 50) ? "Item is too large to ship" : "The total comes too $" + (width * length * height * weight) / 100);
            }
            
        }
    }
}
