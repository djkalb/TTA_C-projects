
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace code_first
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
