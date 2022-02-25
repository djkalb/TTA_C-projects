using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 50.00m};

            Console.WriteLine(number.Amount);
        }
    }
}
