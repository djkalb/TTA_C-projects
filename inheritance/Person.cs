using System;
using System.Collections.Generic;
using System.Text;
//Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.

//Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the
//console in the format of: “Name: [full name]”.


namespace inheritance
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public void sayName()
        {
            Console.WriteLine("Name: "  + FirstName + LastName);
        }
    }
}
