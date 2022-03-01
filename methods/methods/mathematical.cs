using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class Mathematical
    {
        public int Integer1  { get; set; }
        

        public static int Add(int number)
        {
            return number + 10;
        }
        public static decimal Add(decimal number)
        {
            return Convert.ToInt32(number - 10);
        }
        public static int Add(string number)

        {
            int newNumber = Int32.Parse(number);
            
            return newNumber + 10;
        }
        public static int Multiply(int number)
        {
            return number * 10;
        }
    }

}
