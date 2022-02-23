using System;

//The program must start by printing “The Tech Academy.”

//The next line must be “Student Daily Report.”

//You must ask and save your data according to its proper data type and with clearly labeled variables.

//The DR must contain the following questions:

//What is your name ?

//What course are you on?

//What page number?

//Do you need help with anything? Please answer “true” or “false.”

//Were there any positive experiences you’d like to share? Please give specifics.

//Is there any other feedback you’d like to provide? Please be specific.

//How many hours did you study today?

//After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 
class Program
{
    static void Main()
    {   // trying to type less fingers are sore
        Console.WriteLine("The Tech Academy \nStudent Daily Report:\n\nWhat is your name?");
        string studentName = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string studentCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        string studentPage = Console.ReadLine();
        byte pageNumber = byte.Parse(studentPage);
        Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
        string studentHelp = Console.ReadLine();
        bool trueHelp = Convert.ToBoolean(studentHelp);
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string studentExperiences = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string studentFeedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string studentHours = Console.ReadLine();
        byte studyHours = byte.Parse(studentHours);
        Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This is the end of the program.");

    }   
}