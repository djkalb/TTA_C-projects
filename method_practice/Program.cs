using System;

namespace method_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods divide = new Methods();

            Console.WriteLine("input an integer");
            int input = Convert.ToInt32(Console.ReadLine());
            divide.Divider(input);
            int output = 0;
            Methods.Outputted(out output);
            Console.WriteLine(output);

        }
    }
}
