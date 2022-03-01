using System;

namespace variables_datatypes
{
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
}
