using System;
using System.Collections.Generic;
using System.Text;

//Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

//In the Main() method, instantiate that class.

//Have the user enter a number. Call the method on that number. Display the output to the screen.
//It should be the entered number, divided by two.

//Create a method with output parameters.

//Overload a method.

//Declare a class to be static.

//Add comments to each line or block of your code to explain what it does exactly,
//so that another developer could read and understand your code.
namespace method_practice
{
    class Methods
    {
        public void Divider(int num)
        {
            Console.WriteLine(num / 2);
        }
        static public void Outputted (out int count, int times = 2)
        {
            count = 0;
            while(count < times)
            {
                count++;
                Console.WriteLine(count);
            }

        }
    }
}
