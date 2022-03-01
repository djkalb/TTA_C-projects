using System;

namespace code_first
{
    class Program
    {
        static void Main()
        {

            using (var ctx = new StudentContext())
            {
                var student = new Student() { 
                    StudentName = "Bill Withers",
                    DateOfBirth = DateTime.Now,
                    Course = "Cursive"};

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
