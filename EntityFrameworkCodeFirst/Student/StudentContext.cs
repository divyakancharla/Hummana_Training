using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Student> Employees { get; set; }
    }
}
