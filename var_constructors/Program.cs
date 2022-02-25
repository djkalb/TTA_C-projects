using System;

//Create a const variable.

//Create a variable using the keyword “var.”

//Chain two constructors together.

//Add comments to each line or block of your code to explain what it does exactly,
//so that another developer could read and understand your code.

//Upload your code to GitHub and submit the link below:
namespace var_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "David";
            var newName = "david";
            Constructed person = new Constructed("david");
            Console.WriteLine(person.firstName);
            
            Console.WriteLine(person.lastName);

        }
        
    }
    class Constructed
    {
        public Constructed(string fName, string lName) 
        {
            firstName = fName;
            lastName = lName;
        }
        public Constructed (string firstName) : this(firstName, "mine") { }

        public string firstName { get; set; }
        public string lastName { get; set; }


    }


}
