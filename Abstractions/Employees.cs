using System;
using System.Collections.Generic;
using System.Text;

//Perform these actions and create a console app that includes the following:


//Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

//Upload your code to GitHub and submit the link below:
namespace Abstractions
{
    public class Employees : Person, IQuittable
    {
        public int Id { get; set; }

        public static bool IdsAreEqual { get; set; }
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " says fuck this shit im outta here");
        }
        public static Employees operator== (Employees employee1, Employees employee2)
        {
            if(employee1.Id == employee2.Id)
            {
                throw new InvalidOperationException("employee id's cannot match");
                
            }
            else
            {
                return employee1;
            }
        }
        public static Employees operator !=(Employees employee1, Employees employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return employee1;

            }
            else
            {
                throw new InvalidOperationException("employee id's cannot match");
                
            }
        }

    }
}
