using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates new struct number with amount of 50.00
            Number number = new Number() { Amount = 50.00m};

            Console.WriteLine(number.Amount);
        }
    }
}
