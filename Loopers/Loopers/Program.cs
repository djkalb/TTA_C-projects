using System;

namespace Loopers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = 0;
            while (number < 11)
            {
                Console.WriteLine("Hello World! " + number);
                number++;
            }
            
            number = -5;
            do
            {
                Console.WriteLine(number);
                number++;
            } while (number < 15);
        }
    }
}
