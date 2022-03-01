using System;
using System.Collections.Generic;
using System.Text;

//
//Make the Employee class take a generic type parameter.

//Add a property to the Employee class called “things” and have its data type be a generic list
//matching the generic type of the class.



//Add comments to each line or block of your code to explain what it does exactly, 
//so that another developer could read and understand your code.
namespace Abstractions
{
    public class Employees : Person//, IQuittable
    {
        
        public int Id { get; set; }

        public static bool IdsAreEqual { get; set; }
        public override void SayName()
        {
            base.SayName();
        }
        //public void Quit()
        //{
        //    Console.WriteLine(FirstName + " says fuck this shit im outta here");
        //}
        //public static Employees operator== (Employees employee1, Employees employee2)
        //{
        //    if(employee1.Id == employee2.Id)
        //    {
        //        throw new InvalidOperationException("employee id's cannot match");
                
        //    }
        //    else
        //    {
        //        return employee1;
        //    }
        //}
        //public static Employees operator !=(Employees employee1, Employees employee2)
        //{
        //    if (employee1.Id == employee2.Id)
        //    {
        //        return employee1;

        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("employee id's cannot match");
                
        //    }
        //}

    }
}
